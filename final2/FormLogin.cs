using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace test1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblError.Text = "Please enter both username and password.";
                lblError.Visible = true;
                return;
            }

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT u.UserID, u.Username, u.FullName, u.Role, u.IsActive, u.SupplierID, s.SupplierName 
                                     FROM Users u 
                                     LEFT JOIN Suppliers s ON u.SupplierID = s.SupplierID 
                                     WHERE u.Username = @Username AND u.Password = @Password";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                bool isActive = Convert.ToBoolean(reader["IsActive"]);
                                if (!isActive)
                                {
                                    lblError.Text = "This account is deactivated. Contact Admin.";
                                    lblError.Visible = true;
                                    return;
                                }

                                // Set user session details
                                UserSession.UserID = Convert.ToInt32(reader["UserID"]);
                                UserSession.Username = reader["Username"].ToString();
                                UserSession.FullName = reader["FullName"].ToString();
                                UserSession.Role = reader["Role"].ToString();

                                if (reader["SupplierID"] != DBNull.Value)
                                {
                                    UserSession.SupplierID = Convert.ToInt32(reader["SupplierID"]);
                                    UserSession.SupplierName = reader["SupplierName"]?.ToString();
                                }
                                else
                                {
                                    UserSession.SupplierID = null;
                                    UserSession.SupplierName = null;
                                }

                                // Launch Appropriate Window based on Role
                                if (UserSession.IsSupplier)
                                {
                                    FormSupplierPortal portal = new FormSupplierPortal();
                                    portal.FormClosed += (s, args) => this.Close();
                                    this.Hide();
                                    portal.Show();
                                }
                                else
                                {
                                    FormMain main = new FormMain();
                                    main.FormClosed += (s, args) => this.Close();
                                    this.Hide();
                                    main.Show();
                                }
                            }
                            else
                            {
                                lblError.Text = "Invalid username or password!";
                                lblError.Visible = true;
                                txtPassword.Clear();
                                txtPassword.Focus();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection error: " + ex.Message, "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '●';
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void lblError_Click(object sender, EventArgs e)
        {

        }
    }
}
