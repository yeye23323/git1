using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace test1
{
    public partial class FormNewSale : Form
    {
        private DataTable dtCustomers = new DataTable();
        private DataTable dtACUnits = new DataTable();
        private int selectedCustomerId = 0;
        private int selectedItemId = 0;
        private decimal unitPrice = 0m;

        public FormNewSale()
        {
            InitializeComponent();
        }

        private void FormNewSale_Load(object sender, EventArgs e)
        {
            if (cmbTerms.Items.Count > 0) cmbTerms.SelectedIndex = 2; 
            dtpContractDate.Value = DateTime.Now;
            numericUpDown1.ValueChanged += (s, ev) => UpdateSummaryLabels(GetCurrentDownPayment());
            numericUpDown1.TextChanged += (s, ev) => UpdateSummaryLabels(GetCurrentDownPayment());
            LoadCustomers();
            LoadBrandFilter();
            LoadAvailableACUnits();
            LoadTechnicians();
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
                                            SerialNumber, InstallmentPrice, StockQty 
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

                        // Auto-widen the dropdown so long names are never cut off
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

                        cmbSelectACUnit.SelectedIndex = -1; // Start blank until user picks a model
                        lblBrandDisplay.Text = "-";
                        lblHPDisplay.Text = "-";
                        lblSerialDisplay.Text = "-";
                        lblPriceDisplay.Text = "₱0.00";
                        selectedItemId = 0;
                        unitPrice = 0m;
                        dgvSchedulePreview.DataSource = null;
                        UpdateSummaryLabels(nudDownPayment.Value);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading AC stock: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                // Unlock fields – white background, editable
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

                    // Lock fields – grey background signals read-only
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

                unitPrice = Convert.ToDecimal(row["InstallmentPrice"]);
                lblPriceDisplay.Text = "₱" + unitPrice.ToString("N2");

                dgvSchedulePreview.DataSource = null;
                UpdateSummaryLabels(GetCurrentDownPayment());
            }
        }

        private void nudDownPayment_ValueChanged(object sender, EventArgs e)
        {
            UpdateSummaryLabels(nudDownPayment.Value);
        }

        private void nudDownPayment_TextChanged(object sender, EventArgs e)
        {
            UpdateSummaryLabels(GetCurrentDownPayment());
        }

        private void cmbTerms_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSummaryLabels(GetCurrentDownPayment());
        }

        private decimal GetCurrentDownPayment()
        {
            string raw = nudDownPayment.Text.Replace(",", "").Trim();
            if (string.IsNullOrEmpty(raw)) return 0m;
            return decimal.TryParse(raw, out decimal val) ? Math.Max(0m, val) : nudDownPayment.Value;
        }
        private decimal GetTotalPayable(decimal balance, int months)
        {
            decimal ratePercent = numericUpDown1.Value;
            return balance + (balance * (ratePercent / 100m) * months);
        }

        private void UpdateSummaryLabels(decimal downPayment)
        {
            decimal balance = Math.Max(0m, unitPrice - downPayment);
            int months = GetSelectedMonths();
            decimal totalPayable = GetTotalPayable(balance, months);
            decimal monthlyDue = months > 0 ? Math.Round(totalPayable / months, 2) : 0m;

            lblRemainingBalance.Text = "₱" + totalPayable.ToString("N2");
            lblMonthlyDue.Text = "₱" + monthlyDue.ToString("N2") + " / month";
        }

        private void GenerateSchedulePreview()
        {
            decimal downPayment = GetCurrentDownPayment();
            decimal balance = Math.Max(0m, unitPrice - downPayment);
            int months = GetSelectedMonths();
            decimal totalPayable = GetTotalPayable(balance, months);
            decimal monthlyDue = months > 0 ? Math.Round(totalPayable / months, 2) : 0m;

            UpdateSummaryLabels(downPayment);

            DataTable dt = new DataTable();
            dt.Columns.Add("Month #", typeof(string));
            dt.Columns.Add("Due Date", typeof(string));
            dt.Columns.Add("Amount Due", typeof(string));
            dt.Columns.Add("Status", typeof(string));

            DateTime startDate = dtpContractDate.Value;
            for (int i = 1; i <= months; i++)
            {
                DateTime dueDate = startDate.AddMonths(i);

                // Last month absorbs rounding so the preview adds up to totalPayable
                decimal amountDue = i == months
                    ? totalPayable - (monthlyDue * (months - 1))
                    : monthlyDue;

                dt.Rows.Add("Month " + i, dueDate.ToString("MMM dd, yyyy"), "₱" + amountDue.ToString("N2"), "Scheduled");
            }

            dgvSchedulePreview.DataSource = dt;
        }

        private int GetSelectedMonths()
        {
            if (cmbTerms.SelectedItem == null) return 6;
            string selected = cmbTerms.SelectedItem.ToString();
            string digits = "";
            foreach (char c in selected)
            {
                if (char.IsDigit(c)) digits += c;
                else if (digits.Length > 0) break;
            }

            return int.TryParse(digits, out int m) && m > 0 ? m : 6;
        }

        private void btnPreviewSchedule_Click(object sender, EventArgs e)
        {
            if (selectedItemId <= 0)
            {
                MessageBox.Show("Please select an AC unit first.", "Select AC Unit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GenerateSchedulePreview();
        }

        private void btnSaveContract_Click(object sender, EventArgs e)
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

            decimal downPayment = nudDownPayment.Value;
            decimal balance = Math.Max(0m, unitPrice - downPayment);
            int months = GetSelectedMonths();
            decimal monthlyAmortization = months > 0 ? Math.Round(balance / months, 2) : 0m;

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

                            // 2. Insert Sales Contract (Note: Stock is NOT deducted yet per SAP SD; deducts upon installation!)
                            string assignedTech = (cmbTechnician.SelectedIndex > 0 && cmbTechnician.SelectedItem != null)
                                ? cmbTechnician.SelectedItem.ToString()
                                : null;

                            string insertContract = @"INSERT INTO SalesContracts 
                                                     (CustomerID, ItemID, ContractDate, TotalAmount, DownPayment, RemainingBalance, TermsMonths, MonthlyAmortization, ContractStatus, InstallationNotes, AssignedTechnician, CreatedAt, InstallationStatus)
                                                     OUTPUT INSERTED.ContractID
                                                     VALUES 
                                                     (@CustomerID, @ItemID, @ContractDate, @TotalAmount, @DownPayment, @RemainingBalance, @TermsMonths, @MonthlyAmortization, 'Active', @InstallationNotes, @AssignedTechnician, GETDATE(), 'Pending Installation')";

                            int contractId = 0;
                            using (SqlCommand cmdContract = new SqlCommand(insertContract, conn, trans))
                            {
                                cmdContract.Parameters.AddWithValue("@CustomerID", customerId);
                                cmdContract.Parameters.AddWithValue("@ItemID", selectedItemId);
                                cmdContract.Parameters.AddWithValue("@ContractDate", dtpContractDate.Value.Date);
                                cmdContract.Parameters.AddWithValue("@TotalAmount", unitPrice);
                                cmdContract.Parameters.AddWithValue("@DownPayment", downPayment);
                                cmdContract.Parameters.AddWithValue("@RemainingBalance", balance);
                                cmdContract.Parameters.AddWithValue("@TermsMonths", months);
                                cmdContract.Parameters.AddWithValue("@MonthlyAmortization", monthlyAmortization);
                                cmdContract.Parameters.AddWithValue("@InstallationNotes", string.IsNullOrWhiteSpace(txtInstallationNotes.Text) ? (object)DBNull.Value : txtInstallationNotes.Text.Trim());
                                cmdContract.Parameters.AddWithValue("@AssignedTechnician", string.IsNullOrWhiteSpace(assignedTech) ? (object)DBNull.Value : assignedTech);

                                contractId = (int)cmdContract.ExecuteScalar();
                            }

                            // 3. Generate Installment Schedule rows
                            DateTime startDate = dtpContractDate.Value.Date;
                            for (int i = 1; i <= months; i++)
                            {
                                DateTime dueDate = startDate.AddMonths(i);
                                // Keep the schedule total equal to the exact balance.
                                // The final month absorbs any currency rounding difference.
                                decimal amountDue = i == months
                                    ? balance - (monthlyAmortization * (months - 1))
                                    : monthlyAmortization;
                                string insertSched = @"INSERT INTO InstallmentSchedule (ContractID, MonthNumber, DueDate, AmountDue, AmountPaid, Status)
                                                      VALUES (@ContractID, @MonthNumber, @DueDate, @AmountDue, 0.00, 'UNPAID')";

                                using (SqlCommand cmdSched = new SqlCommand(insertSched, conn, trans))
                                {
                                    cmdSched.Parameters.AddWithValue("@ContractID", contractId);
                                    cmdSched.Parameters.AddWithValue("@MonthNumber", i);
                                    cmdSched.Parameters.AddWithValue("@DueDate", dueDate);
                                    cmdSched.Parameters.AddWithValue("@AmountDue", amountDue);
                                    cmdSched.ExecuteNonQuery();
                                }
                            }

                            // 4. Record down payment transaction if > 0
                            if (downPayment > 0)
                            {
                                string insertDownPayment = @"INSERT INTO PaymentTransactions (ContractID, ScheduleID, PaymentDate, Amount, PaymentType, PaymentMethod, ReferenceReceipt, ReceivedBy)
                                                            VALUES (@ContractID, NULL, GETDATE(), @Amount, 'Down Payment', 'Cash', 'DOWN-PAYMENT', @ReceivedBy)";

                                using (SqlCommand cmdDown = new SqlCommand(insertDownPayment, conn, trans))
                                {
                                    cmdDown.Parameters.AddWithValue("@ContractID", contractId);
                                    cmdDown.Parameters.AddWithValue("@Amount", downPayment);
                                    cmdDown.Parameters.AddWithValue("@ReceivedBy", UserSession.FullName ?? "Staff");
                                    cmdDown.ExecuteNonQuery();
                                }
                            }

                            trans.Commit();

                            MessageBox.Show(
                                string.Format("Installment Contract #{0} successfully created!\n\nCustomer: {1}\nTotal: ₱{2:N2}\nDown Payment: ₱{3:N2}\nRemaining Balance: ₱{4:N2}\n\nA Job Order has been queued in 'Job Orders & Installation'. Physical stock will deduct when the technician confirms installation.",
                                    contractId, txtCustomerName.Text.Trim(), unitPrice, downPayment, balance),
                                "Contract Created", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Refresh available stock
                            txtInstallationNotes.Clear();
                            LoadCustomers();
                            LoadBrandFilter();
                            LoadAvailableACUnits();
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
                MessageBox.Show("Failed to save installment contract: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblRemainingBalance_Click(object sender, EventArgs e)
        {

        }

        private void lblInterestRate_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            UpdateSummaryLabels(GetCurrentDownPayment());
        }
    }
}
