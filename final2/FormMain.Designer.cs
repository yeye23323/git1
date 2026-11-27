namespace test1
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.pnlSubAdmin = new System.Windows.Forms.Panel();
            this.btnSubUsers = new System.Windows.Forms.Button();
            this.btnSubMasterData = new System.Windows.Forms.Button();
            this.btnNavAdmin = new System.Windows.Forms.Button();
            this.pnlSubProcurement = new System.Windows.Forms.Panel();
            this.btnSubPOs = new System.Windows.Forms.Button();
            this.btnNavProcurement = new System.Windows.Forms.Button();
            this.pnlSubInventory = new System.Windows.Forms.Panel();
            this.btnSubStocks = new System.Windows.Forms.Button();
            this.btnNavInventory = new System.Windows.Forms.Button();
            this.pnlSubSales = new System.Windows.Forms.Panel();
            this.btnSubCustomers = new System.Windows.Forms.Button();
            this.btnSubInstallations = new System.Windows.Forms.Button();
            this.btnSubTransactionLog = new System.Windows.Forms.Button();
            this.btnSubPayments = new System.Windows.Forms.Button();
            this.btnSubFullSale = new System.Windows.Forms.Button();
            this.btnSubNewSale = new System.Windows.Forms.Button();
            this.btnNavSales = new System.Windows.Forms.Button();
            this.btnNavDashboard = new System.Windows.Forms.Button();
            this.pnlBrand = new System.Windows.Forms.Panel();
            this.lblBrandSub = new System.Windows.Forms.Label();
            this.lblBrandTitle = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.lblCurrentViewTitle = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.dgvUpcomingDues = new System.Windows.Forms.DataGridView();
            this.colCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmountDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblUpcomingTitle = new System.Windows.Forms.Label();
            this.grpMetricOverdue = new System.Windows.Forms.GroupBox();
            this.lblCountOverdue = new System.Windows.Forms.Label();
            this.grpMetricContracts = new System.Windows.Forms.GroupBox();
            this.lblCountContracts = new System.Windows.Forms.Label();
            this.grpMetricStock = new System.Windows.Forms.GroupBox();
            this.lblCountStock = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.pnlSubAdmin.SuspendLayout();
            this.pnlSubProcurement.SuspendLayout();
            this.pnlSubInventory.SuspendLayout();
            this.pnlSubSales.SuspendLayout();
            this.pnlBrand.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpcomingDues)).BeginInit();
            this.grpMetricOverdue.SuspendLayout();
            this.grpMetricContracts.SuspendLayout();
            this.grpMetricStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.AutoScroll = true;
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(61)))), ((int)(((byte)(115)))));
            this.pnlSidebar.Controls.Add(this.btnSignOut);
            this.pnlSidebar.Controls.Add(this.pnlSubAdmin);
            this.pnlSidebar.Controls.Add(this.btnNavAdmin);
            this.pnlSidebar.Controls.Add(this.pnlSubProcurement);
            this.pnlSidebar.Controls.Add(this.btnNavProcurement);
            this.pnlSidebar.Controls.Add(this.pnlSubInventory);
            this.pnlSidebar.Controls.Add(this.btnNavInventory);
            this.pnlSidebar.Controls.Add(this.pnlSubSales);
            this.pnlSidebar.Controls.Add(this.btnNavSales);
            this.pnlSidebar.Controls.Add(this.btnNavDashboard);
            this.pnlSidebar.Controls.Add(this.pnlBrand);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(240, 720);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(45)))), ((int)(((byte)(85)))));
            this.btnSignOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSignOut.FlatAppearance.BorderSize = 0;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnSignOut.Location = new System.Drawing.Point(0, 765);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSignOut.Size = new System.Drawing.Size(223, 45);
            this.btnSignOut.TabIndex = 10;
            this.btnSignOut.Text = "🚪  Sign Out / Switch User";
            this.btnSignOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // pnlSubAdmin
            // 
            this.pnlSubAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(45)))), ((int)(((byte)(85)))));
            this.pnlSubAdmin.Controls.Add(this.btnSubUsers);
            this.pnlSubAdmin.Controls.Add(this.btnSubMasterData);
            this.pnlSubAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubAdmin.Location = new System.Drawing.Point(0, 685);
            this.pnlSubAdmin.Name = "pnlSubAdmin";
            this.pnlSubAdmin.Size = new System.Drawing.Size(223, 80);
            this.pnlSubAdmin.TabIndex = 9;
            // 
            // btnSubUsers
            // 
            this.btnSubUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubUsers.FlatAppearance.BorderSize = 0;
            this.btnSubUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubUsers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.btnSubUsers.Location = new System.Drawing.Point(0, 40);
            this.btnSubUsers.Name = "btnSubUsers";
            this.btnSubUsers.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSubUsers.Size = new System.Drawing.Size(223, 40);
            this.btnSubUsers.TabIndex = 1;
            this.btnSubUsers.Text = "👥 User Accounts && Roles";
            this.btnSubUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubUsers.UseVisualStyleBackColor = true;
            this.btnSubUsers.Click += new System.EventHandler(this.btnSubUsers_Click);
            // 
            // btnSubMasterData
            // 
            this.btnSubMasterData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMasterData.FlatAppearance.BorderSize = 0;
            this.btnSubMasterData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMasterData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMasterData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.btnSubMasterData.Location = new System.Drawing.Point(0, 0);
            this.btnSubMasterData.Name = "btnSubMasterData";
            this.btnSubMasterData.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSubMasterData.Size = new System.Drawing.Size(223, 40);
            this.btnSubMasterData.TabIndex = 0;
            this.btnSubMasterData.Text = "🏷️ Master Data Maintenance";
            this.btnSubMasterData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubMasterData.UseVisualStyleBackColor = true;
            this.btnSubMasterData.Click += new System.EventHandler(this.btnSubMasterData_Click);
            // 
            // btnNavAdmin
            // 
            this.btnNavAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavAdmin.FlatAppearance.BorderSize = 0;
            this.btnNavAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavAdmin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavAdmin.ForeColor = System.Drawing.Color.White;
            this.btnNavAdmin.Location = new System.Drawing.Point(0, 640);
            this.btnNavAdmin.Name = "btnNavAdmin";
            this.btnNavAdmin.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnNavAdmin.Size = new System.Drawing.Size(223, 45);
            this.btnNavAdmin.TabIndex = 8;
            this.btnNavAdmin.Text = "⚙️  Administration && Files  ▾";
            this.btnNavAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavAdmin.UseVisualStyleBackColor = true;
            this.btnNavAdmin.Click += new System.EventHandler(this.btnNavAdmin_Click);
            // 
            // pnlSubProcurement
            // 
            this.pnlSubProcurement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(45)))), ((int)(((byte)(85)))));
            this.pnlSubProcurement.Controls.Add(this.btnSubPOs);
            this.pnlSubProcurement.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubProcurement.Location = new System.Drawing.Point(0, 600);
            this.pnlSubProcurement.Name = "pnlSubProcurement";
            this.pnlSubProcurement.Size = new System.Drawing.Size(223, 40);
            this.pnlSubProcurement.TabIndex = 7;
            // 
            // btnSubPOs
            // 
            this.btnSubPOs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubPOs.FlatAppearance.BorderSize = 0;
            this.btnSubPOs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubPOs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubPOs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.btnSubPOs.Location = new System.Drawing.Point(0, 0);
            this.btnSubPOs.Name = "btnSubPOs";
            this.btnSubPOs.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSubPOs.Size = new System.Drawing.Size(223, 40);
            this.btnSubPOs.TabIndex = 0;
            this.btnSubPOs.Text = "📑 Purchase Orders && Delivery";
            this.btnSubPOs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubPOs.UseVisualStyleBackColor = true;
            this.btnSubPOs.Click += new System.EventHandler(this.btnSubPOs_Click);
            // 
            // btnNavProcurement
            // 
            this.btnNavProcurement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavProcurement.FlatAppearance.BorderSize = 0;
            this.btnNavProcurement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavProcurement.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavProcurement.ForeColor = System.Drawing.Color.White;
            this.btnNavProcurement.Location = new System.Drawing.Point(0, 555);
            this.btnNavProcurement.Name = "btnNavProcurement";
            this.btnNavProcurement.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnNavProcurement.Size = new System.Drawing.Size(223, 45);
            this.btnNavProcurement.TabIndex = 6;
            this.btnNavProcurement.Text = "🏭  Procurement  ▾";
            this.btnNavProcurement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavProcurement.UseVisualStyleBackColor = true;
            this.btnNavProcurement.Click += new System.EventHandler(this.btnNavProcurement_Click);
            // 
            // pnlSubInventory
            // 
            this.pnlSubInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(45)))), ((int)(((byte)(85)))));
            this.pnlSubInventory.Controls.Add(this.btnSubStocks);
            this.pnlSubInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubInventory.Location = new System.Drawing.Point(0, 515);
            this.pnlSubInventory.Name = "pnlSubInventory";
            this.pnlSubInventory.Size = new System.Drawing.Size(223, 40);
            this.pnlSubInventory.TabIndex = 5;
            // 
            // btnSubStocks
            // 
            this.btnSubStocks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubStocks.FlatAppearance.BorderSize = 0;
            this.btnSubStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubStocks.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubStocks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.btnSubStocks.Location = new System.Drawing.Point(0, 0);
            this.btnSubStocks.Name = "btnSubStocks";
            this.btnSubStocks.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSubStocks.Size = new System.Drawing.Size(223, 40);
            this.btnSubStocks.TabIndex = 0;
            this.btnSubStocks.Text = "📦 Stock Availability";
            this.btnSubStocks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubStocks.UseVisualStyleBackColor = true;
            this.btnSubStocks.Click += new System.EventHandler(this.btnSubStocks_Click);
            // 
            // btnNavInventory
            // 
            this.btnNavInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavInventory.FlatAppearance.BorderSize = 0;
            this.btnNavInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavInventory.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavInventory.ForeColor = System.Drawing.Color.White;
            this.btnNavInventory.Location = new System.Drawing.Point(0, 470);
            this.btnNavInventory.Name = "btnNavInventory";
            this.btnNavInventory.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnNavInventory.Size = new System.Drawing.Size(223, 45);
            this.btnNavInventory.TabIndex = 4;
            this.btnNavInventory.Text = "📦  Inventory Management  ▾";
            this.btnNavInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavInventory.UseVisualStyleBackColor = true;
            this.btnNavInventory.Click += new System.EventHandler(this.btnNavInventory_Click);
            // 
            // pnlSubSales
            // 
            this.pnlSubSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(45)))), ((int)(((byte)(85)))));
            this.pnlSubSales.Controls.Add(this.btnSubCustomers);
            this.pnlSubSales.Controls.Add(this.btnSubInstallations);
            this.pnlSubSales.Controls.Add(this.btnSubTransactionLog);
            this.pnlSubSales.Controls.Add(this.btnSubPayments);
            this.pnlSubSales.Controls.Add(this.btnSubFullSale);
            this.pnlSubSales.Controls.Add(this.btnSubNewSale);
            this.pnlSubSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubSales.Location = new System.Drawing.Point(0, 230);
            this.pnlSubSales.Name = "pnlSubSales";
            this.pnlSubSales.Size = new System.Drawing.Size(223, 240);
            this.pnlSubSales.TabIndex = 3;
            // 
            // btnSubCustomers
            // 
            this.btnSubCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubCustomers.FlatAppearance.BorderSize = 0;
            this.btnSubCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubCustomers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.btnSubCustomers.Location = new System.Drawing.Point(0, 200);
            this.btnSubCustomers.Name = "btnSubCustomers";
            this.btnSubCustomers.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSubCustomers.Size = new System.Drawing.Size(223, 40);
            this.btnSubCustomers.TabIndex = 3;
            this.btnSubCustomers.Text = "👥 Customer Directory";
            this.btnSubCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubCustomers.UseVisualStyleBackColor = true;
            this.btnSubCustomers.Click += new System.EventHandler(this.btnSubCustomers_Click);
            // 
            // btnSubInstallations
            // 
            this.btnSubInstallations.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubInstallations.FlatAppearance.BorderSize = 0;
            this.btnSubInstallations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubInstallations.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubInstallations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.btnSubInstallations.Location = new System.Drawing.Point(0, 160);
            this.btnSubInstallations.Name = "btnSubInstallations";
            this.btnSubInstallations.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSubInstallations.Size = new System.Drawing.Size(223, 40);
            this.btnSubInstallations.TabIndex = 2;
            this.btnSubInstallations.Text = "🔧 Installations && Stock Issue";
            this.btnSubInstallations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubInstallations.UseVisualStyleBackColor = true;
            this.btnSubInstallations.Click += new System.EventHandler(this.btnSubInstallations_Click);
            // 
            // btnSubTransactionLog
            // 
            this.btnSubTransactionLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubTransactionLog.FlatAppearance.BorderSize = 0;
            this.btnSubTransactionLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubTransactionLog.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubTransactionLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.btnSubTransactionLog.Location = new System.Drawing.Point(0, 120);
            this.btnSubTransactionLog.Name = "btnSubTransactionLog";
            this.btnSubTransactionLog.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSubTransactionLog.Size = new System.Drawing.Size(223, 40);
            this.btnSubTransactionLog.TabIndex = 4;
            this.btnSubTransactionLog.Text = "📜 Transaction Log";
            this.btnSubTransactionLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubTransactionLog.UseVisualStyleBackColor = true;
            this.btnSubTransactionLog.Click += new System.EventHandler(this.btnSubTransactionLog_Click);
            // 
            // btnSubPayments
            // 
            this.btnSubPayments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubPayments.FlatAppearance.BorderSize = 0;
            this.btnSubPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubPayments.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubPayments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.btnSubPayments.Location = new System.Drawing.Point(0, 80);
            this.btnSubPayments.Name = "btnSubPayments";
            this.btnSubPayments.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSubPayments.Size = new System.Drawing.Size(223, 40);
            this.btnSubPayments.TabIndex = 1;
            this.btnSubPayments.Text = "💳 Payment Collections";
            this.btnSubPayments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubPayments.UseVisualStyleBackColor = true;
            this.btnSubPayments.Click += new System.EventHandler(this.btnSubPayments_Click);
            // 
            // btnSubFullSale
            // 
            this.btnSubFullSale.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubFullSale.FlatAppearance.BorderSize = 0;
            this.btnSubFullSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubFullSale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubFullSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.btnSubFullSale.Location = new System.Drawing.Point(0, 40);
            this.btnSubFullSale.Name = "btnSubFullSale";
            this.btnSubFullSale.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSubFullSale.Size = new System.Drawing.Size(223, 40);
            this.btnSubFullSale.TabIndex = 5;
            this.btnSubFullSale.Text = "💵 Full Payment / Cash Sale";
            this.btnSubFullSale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubFullSale.UseVisualStyleBackColor = true;
            this.btnSubFullSale.Click += new System.EventHandler(this.btnSubFullSale_Click);
            // 
            // btnSubNewSale
            // 
            this.btnSubNewSale.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubNewSale.FlatAppearance.BorderSize = 0;
            this.btnSubNewSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubNewSale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubNewSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.btnSubNewSale.Location = new System.Drawing.Point(0, 0);
            this.btnSubNewSale.Name = "btnSubNewSale";
            this.btnSubNewSale.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSubNewSale.Size = new System.Drawing.Size(223, 40);
            this.btnSubNewSale.TabIndex = 0;
            this.btnSubNewSale.Text = "🛒 New Installment Contract";
            this.btnSubNewSale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubNewSale.UseVisualStyleBackColor = true;
            this.btnSubNewSale.Click += new System.EventHandler(this.btnSubNewSale_Click);
            // 
            // btnNavSales
            // 
            this.btnNavSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavSales.FlatAppearance.BorderSize = 0;
            this.btnNavSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavSales.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavSales.ForeColor = System.Drawing.Color.White;
            this.btnNavSales.Location = new System.Drawing.Point(0, 185);
            this.btnNavSales.Name = "btnNavSales";
            this.btnNavSales.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnNavSales.Size = new System.Drawing.Size(223, 45);
            this.btnNavSales.TabIndex = 2;
            this.btnNavSales.Text = "🛒  Sales && Contracts  ▾";
            this.btnNavSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavSales.UseVisualStyleBackColor = true;
            this.btnNavSales.Click += new System.EventHandler(this.btnNavSales_Click);
            // 
            // btnNavDashboard
            // 
            this.btnNavDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavDashboard.FlatAppearance.BorderSize = 0;
            this.btnNavDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavDashboard.ForeColor = System.Drawing.Color.White;
            this.btnNavDashboard.Location = new System.Drawing.Point(0, 140);
            this.btnNavDashboard.Name = "btnNavDashboard";
            this.btnNavDashboard.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnNavDashboard.Size = new System.Drawing.Size(223, 45);
            this.btnNavDashboard.TabIndex = 1;
            this.btnNavDashboard.Text = "📊  Dashboard Overview";
            this.btnNavDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavDashboard.UseVisualStyleBackColor = true;
            this.btnNavDashboard.Click += new System.EventHandler(this.btnNavDashboard_Click);
            // 
            // pnlBrand
            // 
            this.pnlBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(45)))), ((int)(((byte)(85)))));
            this.pnlBrand.Controls.Add(this.lblBrandSub);
            this.pnlBrand.Controls.Add(this.lblBrandTitle);
            this.pnlBrand.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBrand.Location = new System.Drawing.Point(0, 0);
            this.pnlBrand.Name = "pnlBrand";
            this.pnlBrand.Size = new System.Drawing.Size(223, 140);
            this.pnlBrand.TabIndex = 0;
            // 
            // lblBrandSub
            // 
            this.lblBrandSub.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrandSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(215)))), ((int)(((byte)(250)))));
            this.lblBrandSub.Location = new System.Drawing.Point(3, 65);
            this.lblBrandSub.Name = "lblBrandSub";
            this.lblBrandSub.Size = new System.Drawing.Size(220, 60);
            this.lblBrandSub.TabIndex = 1;
            this.lblBrandSub.Text = "REFRIGERATION && AIRCONDITIONING\r\nSales •  Installation • Inventory\r\n";
            this.lblBrandSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBrandTitle
            // 
            this.lblBrandTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrandTitle.ForeColor = System.Drawing.Color.White;
            this.lblBrandTitle.Location = new System.Drawing.Point(3, 22);
            this.lblBrandTitle.Name = "lblBrandTitle";
            this.lblBrandTitle.Size = new System.Drawing.Size(220, 45);
            this.lblBrandTitle.TabIndex = 0;
            this.lblBrandTitle.Text = "COLLAINE";
            this.lblBrandTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblUserInfo);
            this.pnlHeader.Controls.Add(this.lblCurrentViewTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(240, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1040, 65);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(61)))), ((int)(((byte)(115)))));
            this.lblUserInfo.Location = new System.Drawing.Point(700, 22);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(325, 23);
            this.lblUserInfo.TabIndex = 1;
            this.lblUserInfo.Text = "👤 Engr. Nicdao (Admin)";
            this.lblUserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCurrentViewTitle
            // 
            this.lblCurrentViewTitle.AutoSize = true;
            this.lblCurrentViewTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentViewTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(61)))), ((int)(((byte)(115)))));
            this.lblCurrentViewTitle.Location = new System.Drawing.Point(20, 19);
            this.lblCurrentViewTitle.Name = "lblCurrentViewTitle";
            this.lblCurrentViewTitle.Size = new System.Drawing.Size(412, 25);
            this.lblCurrentViewTitle.TabIndex = 0;
            this.lblCurrentViewTitle.Text = "Dashboard Overview && Operations Summary";
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.pnlContent.Controls.Add(this.pnlDashboard);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(240, 65);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1040, 655);
            this.pnlContent.TabIndex = 2;
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Controls.Add(this.btnSearch);
            this.pnlDashboard.Controls.Add(this.txtSearch);
            this.pnlDashboard.Controls.Add(this.lblSearch);
            this.pnlDashboard.Controls.Add(this.dgvUpcomingDues);
            this.pnlDashboard.Controls.Add(this.lblUpcomingTitle);
            this.pnlDashboard.Controls.Add(this.grpMetricOverdue);
            this.pnlDashboard.Controls.Add(this.grpMetricContracts);
            this.pnlDashboard.Controls.Add(this.grpMetricStock);
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashboard.Location = new System.Drawing.Point(0, 0);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Padding = new System.Windows.Forms.Padding(25);
            this.pnlDashboard.Size = new System.Drawing.Size(1040, 655);
            this.pnlDashboard.TabIndex = 0;
            this.pnlDashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDashboard_Paint);
            // 
            // dgvUpcomingDues
            // 
            this.dgvUpcomingDues.AllowUserToAddRows = false;
            this.dgvUpcomingDues.AllowUserToDeleteRows = false;
            this.dgvUpcomingDues.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUpcomingDues.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUpcomingDues.BackgroundColor = System.Drawing.Color.White;
            this.dgvUpcomingDues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpcomingDues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCustomer,
            this.colUnit,
            this.colDueDate,
            this.colAmountDue,
            this.colContact});
            this.dgvUpcomingDues.Location = new System.Drawing.Point(25, 205);
            this.dgvUpcomingDues.Name = "dgvUpcomingDues";
            this.dgvUpcomingDues.ReadOnly = true;
            this.dgvUpcomingDues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUpcomingDues.Size = new System.Drawing.Size(990, 420);
            this.dgvUpcomingDues.TabIndex = 4;
            // 
            // colCustomer
            // 
            this.colCustomer.HeaderText = "Customer Name";
            this.colCustomer.Name = "colCustomer";
            this.colCustomer.ReadOnly = true;
            // 
            // colUnit
            // 
            this.colUnit.HeaderText = "Unit Purchased";
            this.colUnit.Name = "colUnit";
            this.colUnit.ReadOnly = true;
            // 
            // colDueDate
            // 
            this.colDueDate.HeaderText = "Due Date";
            this.colDueDate.Name = "colDueDate";
            this.colDueDate.ReadOnly = true;
            // 
            // colAmountDue
            // 
            this.colAmountDue.HeaderText = "Amount Due";
            this.colAmountDue.Name = "colAmountDue";
            this.colAmountDue.ReadOnly = true;
            // 
            // colContact
            // 
            this.colContact.HeaderText = "Contact #";
            this.colContact.Name = "colContact";
            this.colContact.ReadOnly = true;
            // 
            // lblUpcomingTitle
            // 
            this.lblUpcomingTitle.AutoSize = true;
            this.lblUpcomingTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpcomingTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(61)))), ((int)(((byte)(115)))));
            this.lblUpcomingTitle.Location = new System.Drawing.Point(22, 168);
            this.lblUpcomingTitle.Name = "lblUpcomingTitle";
            this.lblUpcomingTitle.Size = new System.Drawing.Size(430, 21);
            this.lblUpcomingTitle.TabIndex = 3;
            this.lblUpcomingTitle.Text = "Upcoming Collections Due (Collections Alert Schedule)";
            // 
            // grpMetricOverdue
            // 
            this.grpMetricOverdue.BackColor = System.Drawing.Color.White;
            this.grpMetricOverdue.Controls.Add(this.lblCountOverdue);
            this.grpMetricOverdue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMetricOverdue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.grpMetricOverdue.Location = new System.Drawing.Point(670, 25);
            this.grpMetricOverdue.Name = "grpMetricOverdue";
            this.grpMetricOverdue.Size = new System.Drawing.Size(300, 115);
            this.grpMetricOverdue.TabIndex = 2;
            this.grpMetricOverdue.TabStop = false;
            this.grpMetricOverdue.Text = "⚠️ Overdue Collections";
            // 
            // lblCountOverdue
            // 
            this.lblCountOverdue.AutoSize = true;
            this.lblCountOverdue.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
            this.lblCountOverdue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lblCountOverdue.Location = new System.Drawing.Point(25, 35);
            this.lblCountOverdue.Name = "lblCountOverdue";
            this.lblCountOverdue.Size = new System.Drawing.Size(50, 59);
            this.lblCountOverdue.TabIndex = 0;
            this.lblCountOverdue.Text = "0";
            // 
            // grpMetricContracts
            // 
            this.grpMetricContracts.BackColor = System.Drawing.Color.White;
            this.grpMetricContracts.Controls.Add(this.lblCountContracts);
            this.grpMetricContracts.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMetricContracts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(61)))), ((int)(((byte)(115)))));
            this.grpMetricContracts.Location = new System.Drawing.Point(345, 25);
            this.grpMetricContracts.Name = "grpMetricContracts";
            this.grpMetricContracts.Size = new System.Drawing.Size(300, 115);
            this.grpMetricContracts.TabIndex = 1;
            this.grpMetricContracts.TabStop = false;
            this.grpMetricContracts.Text = "📋 Active Installment Contracts";
            // 
            // lblCountContracts
            // 
            this.lblCountContracts.AutoSize = true;
            this.lblCountContracts.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
            this.lblCountContracts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(61)))), ((int)(((byte)(115)))));
            this.lblCountContracts.Location = new System.Drawing.Point(25, 35);
            this.lblCountContracts.Name = "lblCountContracts";
            this.lblCountContracts.Size = new System.Drawing.Size(50, 59);
            this.lblCountContracts.TabIndex = 0;
            this.lblCountContracts.Text = "0";
            // 
            // grpMetricStock
            // 
            this.grpMetricStock.BackColor = System.Drawing.Color.White;
            this.grpMetricStock.Controls.Add(this.lblCountStock);
            this.grpMetricStock.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMetricStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(128)))), ((int)(((byte)(61)))));
            this.grpMetricStock.Location = new System.Drawing.Point(25, 25);
            this.grpMetricStock.Name = "grpMetricStock";
            this.grpMetricStock.Size = new System.Drawing.Size(300, 115);
            this.grpMetricStock.TabIndex = 0;
            this.grpMetricStock.TabStop = false;
            this.grpMetricStock.Text = "📦 Physical Units in Stock";
            // 
            // lblCountStock
            // 
            this.lblCountStock.AutoSize = true;
            this.lblCountStock.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
            this.lblCountStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(128)))), ((int)(((byte)(61)))));
            this.lblCountStock.Location = new System.Drawing.Point(25, 35);
            this.lblCountStock.Name = "lblCountStock";
            this.lblCountStock.Size = new System.Drawing.Size(50, 59);
            this.lblCountStock.TabIndex = 0;
            this.lblCountStock.Text = "0";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(934, 170);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 24);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(687, 171);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(240, 20);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(636, 174);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(44, 13);
            this.lblSearch.TabIndex = 8;
            this.lblSearch.Text = "Search:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Collaine RAC Services - Enterprise Installment & Inventory ERP System";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSubAdmin.ResumeLayout(false);
            this.pnlSubProcurement.ResumeLayout(false);
            this.pnlSubInventory.ResumeLayout(false);
            this.pnlSubSales.ResumeLayout(false);
            this.pnlBrand.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpcomingDues)).EndInit();
            this.grpMetricOverdue.ResumeLayout(false);
            this.grpMetricOverdue.PerformLayout();
            this.grpMetricContracts.ResumeLayout(false);
            this.grpMetricContracts.PerformLayout();
            this.grpMetricStock.ResumeLayout(false);
            this.grpMetricStock.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlBrand;
        private System.Windows.Forms.Label lblBrandSub;
        private System.Windows.Forms.Label lblBrandTitle;
        private System.Windows.Forms.Button btnNavDashboard;
        private System.Windows.Forms.Button btnNavSales;
        private System.Windows.Forms.Panel pnlSubSales;
        private System.Windows.Forms.Button btnSubNewSale;
        private System.Windows.Forms.Button btnSubFullSale;
        private System.Windows.Forms.Button btnSubPayments;
        private System.Windows.Forms.Button btnSubTransactionLog;
        private System.Windows.Forms.Button btnSubInstallations;
        private System.Windows.Forms.Button btnSubCustomers;
        private System.Windows.Forms.Button btnNavInventory;
        private System.Windows.Forms.Panel pnlSubInventory;
        private System.Windows.Forms.Button btnSubStocks;
        private System.Windows.Forms.Button btnNavProcurement;
        private System.Windows.Forms.Panel pnlSubProcurement;
        private System.Windows.Forms.Button btnSubPOs;
        private System.Windows.Forms.Button btnNavAdmin;
        private System.Windows.Forms.Panel pnlSubAdmin;
        private System.Windows.Forms.Button btnSubMasterData;
        private System.Windows.Forms.Button btnSubUsers;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblCurrentViewTitle;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.GroupBox grpMetricStock;
        private System.Windows.Forms.Label lblCountStock;
        private System.Windows.Forms.GroupBox grpMetricContracts;
        private System.Windows.Forms.Label lblCountContracts;
        private System.Windows.Forms.GroupBox grpMetricOverdue;
        private System.Windows.Forms.Label lblCountOverdue;
        private System.Windows.Forms.Label lblUpcomingTitle;
        private System.Windows.Forms.DataGridView dgvUpcomingDues;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmountDue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContact;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
    }
}
