using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace test1
{
    public partial class FormPaymentLog : Form
    {
        private int _contractId;

        public FormPaymentLog() : this(0, "", "")
        {
        }

        public FormPaymentLog(int contractId, string customerName, string acUnit)
        {
            InitializeComponent();
            _contractId = contractId;
            if (_contractId > 0)
            {
                lblContractInfo.Text = string.Format("Contract #{0}  |  Customer: {1}  |  Unit: {2}", contractId, customerName, acUnit);
            }
            else
            {
                lblContractInfo.Text = "Showing all customer payment transactions across all contracts";
            }
        }

        private void FormPaymentLog_Load(object sender, EventArgs e)
        {
            if (cmbFilter.Items.Count > 0 && cmbFilter.SelectedIndex < 0)
                cmbFilter.SelectedIndex = 0;

            LoadLog();
        }

        public void LoadLog()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string search = txtSearch.Text.Trim();
                    string filter = cmbFilter.SelectedItem?.ToString() ?? "All Transactions";

                    string query = @"
                        SELECT  pt.PaymentID,
                                sc.ContractID,
                                cust.FullName AS CustomerName,
                                inv.Brand + ' ' + inv.Model + ' (' + inv.Horsepower + ')' AS ACUnit,
                                pt.PaymentDate,
                                pt.PaymentType,
                                pt.Amount,
                                pt.PaymentMethod,
                                ISNULL(NULLIF(pt.ReferenceReceipt, ''), 'CASH-' + RIGHT('000000' + CAST(pt.PaymentID AS VARCHAR(6)), 6)) AS RefReceipt,
                                pt.ReceivedBy,
                                sc.ContractStatus,
                                sc.TotalAmount,
                                sc.RemainingBalance,
                                CASE WHEN sc.ContractStatus = 'Completed'
                                     THEN (SELECT MAX(PaymentDate) FROM PaymentTransactions WHERE ContractID = sc.ContractID)
                                     ELSE NULL END AS FullyPaidDate
                        FROM    PaymentTransactions pt
                        INNER JOIN SalesContracts sc ON pt.ContractID = sc.ContractID
                        INNER JOIN Customers cust ON sc.CustomerID = cust.CustomerID
                        INNER JOIN Inventory inv ON sc.ItemID = inv.ItemID
                        WHERE   1 = 1";

                    if (_contractId > 0)
                    {
                        query += " AND pt.ContractID = @ContractID";
                    }

                    if (filter == "Fully Paid Only")
                    {
                        query += " AND sc.ContractStatus = 'Completed'";
                    }
                    else if (filter == "Active Only")
                    {
                        query += " AND sc.ContractStatus = 'Active'";
                    }

                    if (!string.IsNullOrWhiteSpace(search))
                    {
                        query += @" AND (cust.FullName LIKE @Search
                                      OR CAST(sc.ContractID AS NVARCHAR) LIKE @Search
                                      OR inv.Brand LIKE @Search
                                      OR inv.Model LIKE @Search
                                      OR pt.PaymentMethod LIKE @Search
                                      OR pt.ReferenceReceipt LIKE @Search)";
                    }

                    query += _contractId > 0
                        ? " ORDER BY pt.PaymentID ASC"
                        : " ORDER BY pt.PaymentDate DESC, pt.PaymentID DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (_contractId > 0)
                            cmd.Parameters.AddWithValue("@ContractID", _contractId);
                        if (!string.IsNullOrWhiteSpace(search))
                            cmd.Parameters.AddWithValue("@Search", "%" + search + "%");

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvLog.DataSource = dt;

                        if (dgvLog.Columns["Amount"] != null)
                            dgvLog.Columns["Amount"].DefaultCellStyle.Format = "₱#,##0.00";
                        if (dgvLog.Columns["TotalAmount"] != null)
                            dgvLog.Columns["TotalAmount"].DefaultCellStyle.Format = "₱#,##0.00";
                        if (dgvLog.Columns["RemainingBalance"] != null)
                            dgvLog.Columns["RemainingBalance"].DefaultCellStyle.Format = "₱#,##0.00";

                        if (dgvLog.Columns["PaymentID"] != null)        dgvLog.Columns["PaymentID"].HeaderText = "TX #";
                        if (dgvLog.Columns["ContractID"] != null)       dgvLog.Columns["ContractID"].HeaderText = "Contract #";
                        if (dgvLog.Columns["CustomerName"] != null)     dgvLog.Columns["CustomerName"].HeaderText = "Customer";
                        if (dgvLog.Columns["ACUnit"] != null)           dgvLog.Columns["ACUnit"].HeaderText = "AC Unit";
                        if (dgvLog.Columns["PaymentDate"] != null)      dgvLog.Columns["PaymentDate"].HeaderText = "Date Paid";
                        if (dgvLog.Columns["PaymentType"] != null)      dgvLog.Columns["PaymentType"].HeaderText = "Type";
                        if (dgvLog.Columns["Amount"] != null)           dgvLog.Columns["Amount"].HeaderText = "Amount Paid";
                        if (dgvLog.Columns["PaymentMethod"] != null)    dgvLog.Columns["PaymentMethod"].HeaderText = "Method";
                        if (dgvLog.Columns["RefReceipt"] != null)       dgvLog.Columns["RefReceipt"].HeaderText = "Ref / Receipt";
                        if (dgvLog.Columns["ReceivedBy"] != null)       dgvLog.Columns["ReceivedBy"].HeaderText = "Received By";
                        if (dgvLog.Columns["ContractStatus"] != null)   dgvLog.Columns["ContractStatus"].HeaderText = "Status";
                        if (dgvLog.Columns["TotalAmount"] != null)      dgvLog.Columns["TotalAmount"].HeaderText = "Contract Total";
                        if (dgvLog.Columns["RemainingBalance"] != null) dgvLog.Columns["RemainingBalance"].HeaderText = "Balance Left";
                        if (dgvLog.Columns["FullyPaidDate"] != null)    dgvLog.Columns["FullyPaidDate"].HeaderText = "Fully Paid Date";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading payment log: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadLog();
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLog();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadLog();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
