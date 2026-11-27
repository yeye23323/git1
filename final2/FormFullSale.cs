using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace test1
{
    public partial class FormFullSale : Form
    {
        private DataTable dtCustomers = new DataTable();
        private DataTable dtACUnits = new DataTable();
        private int selectedCustomerId = 0;
        private int selectedItemId = 0;
        private decimal unitPrice = 0m;

        public FormFullSale()
        {
            InitializeComponent();
        }

        private void FormFullSale_Load(object sender, EventArgs e)
        {
            dtpContractDate.Value = DateTime.Now;
            LoadCustomers();
            LoadBrandFilter();
            LoadAvailableACUnits();
            LoadPaymentMethods();
            LoadTechnicians();
            cmbPaymentMethod_SelectedIndexChanged(null, null);
        }

        private void LoadTechnicians()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    cmbTechnician.Items.Clear();
                    cmbTechnician.Items.Add("-- (Unassigned) --");
                    using (SqlCommand cmd = new SqlCommand("SELECT FullName FROM Users WHERE Role = 'Technician' ORDER BY FullName", conn))
                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                            cmbTechnician.Items.Add(r["FullName"].ToString());
                    }
                    cmbTechnician.SelectedIndex = cmbTechnician.Items.Count > 1 ? 1 : 0;
                }
            }
            catch
            {
                if (cmbTechnician.Items.Count == 0)
                {
                    cmbTechnician.Items.Add("-- (Unassigned) --");
                    cmbTechnician.SelectedIndex = 0;
                }
            }
        }

        private void LoadCustomers()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT CustomerID, FullName, ContactNumber, InstallationAddress, ValidIDInfo
                                     FROM Customers
                                     WHERE CustomerStatus <> 'Blacklisted'
                                     ORDER BY FullName ASC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        dtCustomers = new DataTable();
                        da.Fill(dtCustomers);

                        cmbCustomerList.Items.Clear();
                        cmbCustomerList.Items.Add("-- (New / Walk-in Customer) --");

                        foreach (DataRow row in dtCustomers.Rows)
                        {
                            cmbCustomerList.Items.Add(row["FullName"].ToString() + " (#" + row["CustomerID"].ToString() + ")");
                        }

                        cmbCustomerList.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customers: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadBrandFilter()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT DISTINCT Brand FROM Inventory WHERE StockQty > 0 ORDER BY Brand";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dtBrands = new DataTable();
                        da.Fill(dtBrands);

                        cmbBrandFilter.Items.Clear();
                        cmbBrandFilter.Items.Add("-- (All Brands) --");
                        foreach (DataRow row in dtBrands.Rows)
                        {
                            cmbBrandFilter.Items.Add(row["Brand"].ToString());
                        }

                        cmbBrandFilter.SelectedIndex = -1;
                    }
                }
            }
            catch
            {
            }
        }

        private void cmbBrandFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedBrand = null;
            if (cmbBrandFilter.SelectedIndex > 0)
            {
                selectedBrand = cmbBrandFilter.SelectedItem.ToString();
            }

            LoadAvailableACUnits(selectedBrand);
        }

        private void LoadAvailableACUnits(string brandFilter = null)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT ItemID, Brand, Model, UnitType, Horsepower, InverterStatus,
                                            SerialNumber, ISNULL(NULLIF(CashPrice, 0), InstallmentPrice) AS SalePrice, StockQty
                                     FROM Inventory
                                     WHERE StockQty > 0";

                    if (!string.IsNullOrWhiteSpace(brandFilter))
                    {
                        query += " AND Brand = @Brand";
                    }

                    query += " ORDER BY Brand, Horsepower";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (!string.IsNullOrWhiteSpace(brandFilter))
                        {
                            cmd.Parameters.AddWithValue("@Brand", brandFilter);
                        }

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        dtACUnits = new DataTable();
                        da.Fill(dtACUnits);

                        cmbSelectACUnit.Items.Clear();
                        foreach (DataRow row in dtACUnits.Rows)
                        {
                            string display = string.Format("{0} {1} ({2} {3}) - [Stock: {4}]",
                                row["Brand"], row["Model"], row["Horsepower"], row["UnitType"], row["StockQty"]);
                            cmbSelectACUnit.Items.Add(display);
                        }

                        if (cmbSelectACUnit.Items.Count > 0)
                        {
                            int maxWidth = cmbSelectACUnit.Width;
                            using (System.Drawing.Graphics g = cmbSelectACUnit.CreateGraphics())
                            {
                                foreach (string item in cmbSelectACUnit.Items)
                                {
                                    int w = (int)g.MeasureString(item, cmbSelectACUnit.Font).Width + 20;
                                    if (w > maxWidth) maxWidth = w;
                                }
                            }
                            cmbSelectACUnit.DropDownWidth = maxWidth;
                        }

                        cmbSelectACUnit.SelectedIndex = -1;
                        lblBrandDisplay.Text = "-";
                        lblHPDisplay.Text = "-";
                        lblSerialDisplay.Text = "-";
                        lblPriceDisplay.Text = "₱0.00";
                        lblTotalDueDisplay.Text = "₱0.00";
                        selectedItemId = 0;
                        unitPrice = 0m;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading AC stock: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPaymentMethods()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    cmbPaymentMethod.Items.Clear();
                    SqlDataAdapter da = new SqlDataAdapter(
                        "SELECT MethodName FROM PaymentMethods WHERE IsActive = 1 ORDER BY SortOrder, MethodName", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                            cmbPaymentMethod.Items.Add(row["MethodName"].ToString());
                    }
                    else
                    {
                        cmbPaymentMethod.Items.AddRange(new object[] { "Cash", "GCash", "Bank Transfer", "Check" });
                    }

                    int idx = cmbPaymentMethod.Items.IndexOf("Cash");
                    cmbPaymentMethod.SelectedIndex = idx >= 0 ? idx : 0;
                }
            }
            catch
            {
                if (cmbPaymentMethod.Items.Count == 0)
                    cmbPaymentMethod.Items.AddRange(new object[] { "Cash", "GCash", "Bank Transfer", "Check" });
                if (cmbPaymentMethod.SelectedIndex < 0) cmbPaymentMethod.SelectedIndex = 0;
            }
        }

        private void cmbCustomerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustomerList.SelectedIndex <= 0)
            {
                selectedCustomerId = 0;
                txtCustomerName.Clear();
                txtContactNumber.Clear();
                txtAddress.Clear();
                txtValidID.Clear();

                txtCustomerName.ReadOnly = false;
                txtContactNumber.ReadOnly = false;
                txtAddress.ReadOnly = false;
                txtValidID.ReadOnly = false;

                txtCustomerName.BackColor = System.Drawing.SystemColors.Window;
                txtContactNumber.BackColor = System.Drawing.SystemColors.Window;
                txtAddress.BackColor = System.Drawing.SystemColors.Window;
                txtValidID.BackColor = System.Drawing.SystemColors.Window;
            }
            else
            {
                int index = cmbCustomerList.SelectedIndex - 1;
                if (index >= 0 && index < dtCustomers.Rows.Count)
                {
                    DataRow row = dtCustomers.Rows[index];
                    selectedCustomerId = Convert.ToInt32(row["CustomerID"]);
                    txtCustomerName.Text = row["FullName"].ToString();
                    txtContactNumber.Text = row["ContactNumber"].ToString();
                    txtAddress.Text = row["InstallationAddress"].ToString();
                    txtValidID.Text = row["ValidIDInfo"].ToString();

                    txtCustomerName.ReadOnly = true;
                    txtContactNumber.ReadOnly = true;
                    txtAddress.ReadOnly = true;
                    txtValidID.ReadOnly = true;

                    System.Drawing.Color locked = System.Drawing.Color.FromArgb(235, 235, 235);
                    txtCustomerName.BackColor = locked;
                    txtContactNumber.BackColor = locked;
                    txtAddress.BackColor = locked;
                    txtValidID.BackColor = locked;
                }
            }
        }

        private void cmbSelectACUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelectACUnit.SelectedIndex >= 0 && cmbSelectACUnit.SelectedIndex < dtACUnits.Rows.Count)
            {
                DataRow row = dtACUnits.Rows[cmbSelectACUnit.SelectedIndex];
                selectedItemId = Convert.ToInt32(row["ItemID"]);
                lblBrandDisplay.Text = row["Brand"].ToString() + " (" + row["UnitType"].ToString() + ")";
                lblHPDisplay.Text = row["Horsepower"].ToString() + " (" + row["InverterStatus"].ToString() + ")";
                lblSerialDisplay.Text = string.IsNullOrWhiteSpace(row["SerialNumber"].ToString()) ? "Auto-assigned" : row["SerialNumber"].ToString();

                unitPrice = Convert.ToDecimal(row["SalePrice"]);
                lblPriceDisplay.Text = "₱" + unitPrice.ToString("N2");
                lblTotalDueDisplay.Text = "₱" + unitPrice.ToString("N2");
            }
        }

        private void cmbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isCash = cmbPaymentMethod.SelectedItem?.ToString()?.Equals("Cash", StringComparison.OrdinalIgnoreCase) ?? true;
            txtReceiptRef.Enabled = !isCash;
            txtReceiptRef.BackColor = isCash
                ? System.Drawing.Color.FromArgb(235, 235, 235)
                : System.Drawing.SystemColors.Window;
            txtReceiptRef.Text = isCash ? "(Auto-generated)" : "";
            lblReceipt.Text = isCash ? "Receipt / Ref #:" : "Receipt / Ref # *:";
        }

        private void btnCompleteSale_Click(object sender, EventArgs e)
        {
            //validate contact number format
            if (!Regex.IsMatch(txtContactNumber.Text.Trim(), @"^09[0-9]{9}$"))
            {
                MessageBox.Show("Contact number must be 11 digits, numbers only, and start with 09 (e.g. 09171234567).", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContactNumber.Focus();
                return;
            }

            if (selectedItemId <= 0)
            {
                MessageBox.Show("Please select an AC unit from the inventory.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                MessageBox.Show("Please specify the customer name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustomerName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtContactNumber.Text))
            {
                MessageBox.Show("Please specify the contact number.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContactNumber.Focus();
                return;
            }

            string paymentMethod = cmbPaymentMethod.SelectedItem != null ? cmbPaymentMethod.SelectedItem.ToString() : "Cash";
            bool isCash = paymentMethod.Equals("Cash", StringComparison.OrdinalIgnoreCase);
            string receiptRef = isCash
                ? "CASH-" + DateTime.Now.ToString("yyyyMMddHHmmss")
                : (string.IsNullOrWhiteSpace(txtReceiptRef.Text) ? "REF-" + DateTime.Now.ToString("yyyyMMddHHmmss") : txtReceiptRef.Text.Trim());

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (SqlTransaction trans = conn.BeginTransaction())
                    {
                        try
                        {
                            // 1. Ensure Customer exists
                            int customerId = selectedCustomerId;
                            if (customerId <= 0)
                            {
                                string insertCust = @"INSERT INTO Customers (FullName, ContactNumber, InstallationAddress, ValidIDInfo, DateRegistered, CustomerStatus)
                                                     OUTPUT INSERTED.CustomerID
                                                     VALUES (@FullName, @ContactNumber, @InstallationAddress, @ValidIDInfo, GETDATE(), 'Active')";

                                using (SqlCommand cmdCust = new SqlCommand(insertCust, conn, trans))
                                {
                                    cmdCust.Parameters.AddWithValue("@FullName", txtCustomerName.Text.Trim());
                                    cmdCust.Parameters.AddWithValue("@ContactNumber", txtContactNumber.Text.Trim());
                                    cmdCust.Parameters.AddWithValue("@InstallationAddress", string.IsNullOrWhiteSpace(txtAddress.Text) ? (object)DBNull.Value : txtAddress.Text.Trim());
                                    cmdCust.Parameters.AddWithValue("@ValidIDInfo", string.IsNullOrWhiteSpace(txtValidID.Text) ? (object)DBNull.Value : txtValidID.Text.Trim());
                                    customerId = (int)cmdCust.ExecuteScalar();
                                }
                            }

                            // 2. Insert Completed Sales Contract (Fully Paid, queued for installation)
                            string assignedTech = (cmbTechnician.SelectedIndex > 0 && cmbTechnician.SelectedItem != null)
                                ? cmbTechnician.SelectedItem.ToString()
                                : null;

                            string insertContract = @"INSERT INTO SalesContracts
                                                     (CustomerID, ItemID, ContractDate, TotalAmount, DownPayment, RemainingBalance, TermsMonths, MonthlyAmortization, ContractStatus, InstallationNotes, AssignedTechnician, CreatedAt, InstallationStatus)
                                                     OUTPUT INSERTED.ContractID
                                                     VALUES
                                                     (@CustomerID, @ItemID, @ContractDate, @TotalAmount, @TotalAmount, 0.00, 0, 0.00, 'Completed', @InstallationNotes, @AssignedTechnician, GETDATE(), 'Pending Installation')";

                            int contractId = 0;
                            using (SqlCommand cmdContract = new SqlCommand(insertContract, conn, trans))
                            {
                                cmdContract.Parameters.AddWithValue("@CustomerID", customerId);
                                cmdContract.Parameters.AddWithValue("@ItemID", selectedItemId);
                                cmdContract.Parameters.AddWithValue("@ContractDate", dtpContractDate.Value.Date);
                                cmdContract.Parameters.AddWithValue("@TotalAmount", unitPrice);
                                cmdContract.Parameters.AddWithValue("@InstallationNotes", string.IsNullOrWhiteSpace(txtInstallationNotes.Text) ? (object)DBNull.Value : txtInstallationNotes.Text.Trim());
                                cmdContract.Parameters.AddWithValue("@AssignedTechnician", string.IsNullOrWhiteSpace(assignedTech) ? (object)DBNull.Value : assignedTech);
                                contractId = (int)cmdContract.ExecuteScalar();
                            }

                            // 3. Record Full Payment straight into PaymentTransactions (goes directly to Transaction Log)
                            string insertPay = @"INSERT INTO PaymentTransactions (ContractID, ScheduleID, PaymentDate, Amount, PaymentType, PaymentMethod, ReferenceReceipt, ReceivedBy)
                                                 VALUES (@ContractID, NULL, GETDATE(), @Amount, 'Full Payment', @PaymentMethod, @ReferenceReceipt, @ReceivedBy)";

                            using (SqlCommand cmdPay = new SqlCommand(insertPay, conn, trans))
                            {
                                cmdPay.Parameters.AddWithValue("@ContractID", contractId);
                                cmdPay.Parameters.AddWithValue("@Amount", unitPrice);
                                cmdPay.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                                cmdPay.Parameters.AddWithValue("@ReferenceReceipt", receiptRef);
                                cmdPay.Parameters.AddWithValue("@ReceivedBy", UserSession.FullName ?? "Staff");
                                cmdPay.ExecuteNonQuery();
                            }

                            trans.Commit();

                            MessageBox.Show(
                                string.Format("Full Payment Sale #{0} completed!\n\nCustomer: {1}\nTotal Paid: ₱{2:N2}\nMethod: {3}\nRef #: {4}\n\nRecorded in Transaction Log and queued in 'Installations & Stock Issue'.",
                                    contractId, txtCustomerName.Text.Trim(), unitPrice, paymentMethod, receiptRef),
                                "Full Payment Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            txtInstallationNotes.Clear();
                            LoadCustomers();
                            LoadBrandFilter();
                            LoadAvailableACUnits();
                            cmbPaymentMethod_SelectedIndexChanged(null, null);
                        }
                        catch (Exception exInner)
                        {
                            trans.Rollback();
                            throw exInner;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to complete sale: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
