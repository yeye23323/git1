namespace test1
{
    partial class FormNewSale
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
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.txtValidID = new System.Windows.Forms.TextBox();
            this.lblValidID = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustName = new System.Windows.Forms.Label();
            this.cmbCustomerList = new System.Windows.Forms.ComboBox();
            this.lblExistingCust = new System.Windows.Forms.Label();
            this.grpACUnit = new System.Windows.Forms.GroupBox();
            this.cmbBrandFilter = new System.Windows.Forms.ComboBox();
            this.lblBrandFilter = new System.Windows.Forms.Label();
            this.lblPriceDisplay = new System.Windows.Forms.Label();
            this.lblPriceTag = new System.Windows.Forms.Label();
            this.lblSerialDisplay = new System.Windows.Forms.Label();
            this.lblSerialTag = new System.Windows.Forms.Label();
            this.lblHPDisplay = new System.Windows.Forms.Label();
            this.lblHPTag = new System.Windows.Forms.Label();
            this.lblBrandDisplay = new System.Windows.Forms.Label();
            this.lblBrandTag = new System.Windows.Forms.Label();
            this.cmbSelectACUnit = new System.Windows.Forms.ComboBox();
            this.lblSelectAC = new System.Windows.Forms.Label();
            this.grpTerms = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.btnPreviewSchedule = new System.Windows.Forms.Button();
            this.lblMonthlyDue = new System.Windows.Forms.Label();
            this.lblMonthlyDueTag = new System.Windows.Forms.Label();
            this.lblRemainingBalance = new System.Windows.Forms.Label();
            this.lblBalanceTag = new System.Windows.Forms.Label();
            this.cmbTerms = new System.Windows.Forms.ComboBox();
            this.lblTerms = new System.Windows.Forms.Label();
            this.nudDownPayment = new System.Windows.Forms.NumericUpDown();
            this.lblDownPayment = new System.Windows.Forms.Label();
            this.dtpContractDate = new System.Windows.Forms.DateTimePicker();
            this.lblSaleDate = new System.Windows.Forms.Label();
            this.grpSchedule = new System.Windows.Forms.GroupBox();
            this.dgvSchedulePreview = new System.Windows.Forms.DataGridView();
            this.lblInstallNotes = new System.Windows.Forms.Label();
            this.txtInstallationNotes = new System.Windows.Forms.TextBox();
            this.lblTechnician = new System.Windows.Forms.Label();
            this.cmbTechnician = new System.Windows.Forms.ComboBox();
            this.btnSaveContract = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpCustomer.SuspendLayout();
            this.grpACUnit.SuspendLayout();
            this.grpTerms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDownPayment)).BeginInit();
            this.grpSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedulePreview)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.txtValidID);
            this.grpCustomer.Controls.Add(this.lblValidID);
            this.grpCustomer.Controls.Add(this.txtAddress);
            this.grpCustomer.Controls.Add(this.lblAddress);
            this.grpCustomer.Controls.Add(this.txtContactNumber);
            this.grpCustomer.Controls.Add(this.lblContact);
            this.grpCustomer.Controls.Add(this.txtCustomerName);
            this.grpCustomer.Controls.Add(this.lblCustName);
            this.grpCustomer.Controls.Add(this.cmbCustomerList);
            this.grpCustomer.Controls.Add(this.lblExistingCust);
            this.grpCustomer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCustomer.Location = new System.Drawing.Point(17, 45);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(465, 230);
            this.grpCustomer.TabIndex = 1;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "1. Customer Information";
            // 
            // txtValidID
            // 
            this.txtValidID.Location = new System.Drawing.Point(135, 185);
            this.txtValidID.Name = "txtValidID";
            this.txtValidID.Size = new System.Drawing.Size(315, 23);
            this.txtValidID.TabIndex = 9;
            // 
            // lblValidID
            // 
            this.lblValidID.AutoSize = true;
            this.lblValidID.Location = new System.Drawing.Point(15, 188);
            this.lblValidID.Name = "lblValidID";
            this.lblValidID.Size = new System.Drawing.Size(87, 15);
            this.lblValidID.TabIndex = 8;
            this.lblValidID.Text = "Valid ID Details:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(135, 125);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAddress.Size = new System.Drawing.Size(315, 50);
            this.txtAddress.TabIndex = 7;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(15, 128);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(97, 15);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Installation Addr:";
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(135, 92);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(315, 23);
            this.txtContactNumber.TabIndex = 5;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(15, 95);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(99, 15);
            this.lblContact.TabIndex = 4;
            this.lblContact.Text = "Contact Number:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(135, 60);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(315, 23);
            this.txtCustomerName.TabIndex = 3;
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(15, 63);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(64, 15);
            this.lblCustName.TabIndex = 2;
            this.lblCustName.Text = "Full Name:";
            // 
            // cmbCustomerList
            // 
            this.cmbCustomerList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomerList.FormattingEnabled = true;
            this.cmbCustomerList.Location = new System.Drawing.Point(135, 27);
            this.cmbCustomerList.Name = "cmbCustomerList";
            this.cmbCustomerList.Size = new System.Drawing.Size(315, 23);
            this.cmbCustomerList.TabIndex = 1;
            this.cmbCustomerList.SelectedIndexChanged += new System.EventHandler(this.cmbCustomerList_SelectedIndexChanged);
            // 
            // lblExistingCust
            // 
            this.lblExistingCust.AutoSize = true;
            this.lblExistingCust.Location = new System.Drawing.Point(15, 30);
            this.lblExistingCust.Name = "lblExistingCust";
            this.lblExistingCust.Size = new System.Drawing.Size(85, 15);
            this.lblExistingCust.TabIndex = 0;
            this.lblExistingCust.Text = "Select Existing:";
            // 
            // grpACUnit
            // 
            this.grpACUnit.Controls.Add(this.cmbBrandFilter);
            this.grpACUnit.Controls.Add(this.lblBrandFilter);
            this.grpACUnit.Controls.Add(this.lblPriceDisplay);
            this.grpACUnit.Controls.Add(this.lblPriceTag);
            this.grpACUnit.Controls.Add(this.lblSerialDisplay);
            this.grpACUnit.Controls.Add(this.lblSerialTag);
            this.grpACUnit.Controls.Add(this.lblHPDisplay);
            this.grpACUnit.Controls.Add(this.lblHPTag);
            this.grpACUnit.Controls.Add(this.lblBrandDisplay);
            this.grpACUnit.Controls.Add(this.lblBrandTag);
            this.grpACUnit.Controls.Add(this.cmbSelectACUnit);
            this.grpACUnit.Controls.Add(this.lblSelectAC);
            this.grpACUnit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpACUnit.Location = new System.Drawing.Point(500, 45);
            this.grpACUnit.Name = "grpACUnit";
            this.grpACUnit.Size = new System.Drawing.Size(501, 230);
            this.grpACUnit.TabIndex = 2;
            this.grpACUnit.TabStop = false;
            this.grpACUnit.Text = "2. Select AC Unit from Stock";
            // 
            // cmbBrandFilter
            // 
            this.cmbBrandFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrandFilter.FormattingEnabled = true;
            this.cmbBrandFilter.Location = new System.Drawing.Point(140, 24);
            this.cmbBrandFilter.Name = "cmbBrandFilter";
            this.cmbBrandFilter.Size = new System.Drawing.Size(310, 23);
            this.cmbBrandFilter.TabIndex = 1;
            this.cmbBrandFilter.SelectedIndexChanged += new System.EventHandler(this.cmbBrandFilter_SelectedIndexChanged);
            // 
            // lblBrandFilter
            // 
            this.lblBrandFilter.AutoSize = true;
            this.lblBrandFilter.Location = new System.Drawing.Point(15, 27);
            this.lblBrandFilter.Name = "lblBrandFilter";
            this.lblBrandFilter.Size = new System.Drawing.Size(70, 15);
            this.lblBrandFilter.TabIndex = 0;
            this.lblBrandFilter.Text = "Filter Brand:";
            // 
            // lblPriceDisplay
            // 
            this.lblPriceDisplay.AutoSize = true;
            this.lblPriceDisplay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceDisplay.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblPriceDisplay.Location = new System.Drawing.Point(140, 188);
            this.lblPriceDisplay.Name = "lblPriceDisplay";
            this.lblPriceDisplay.Size = new System.Drawing.Size(91, 21);
            this.lblPriceDisplay.TabIndex = 9;
            this.lblPriceDisplay.Text = "P36,000.00";
            // 
            // lblPriceTag
            // 
            this.lblPriceTag.AutoSize = true;
            this.lblPriceTag.Location = new System.Drawing.Point(15, 192);
            this.lblPriceTag.Name = "lblPriceTag";
            this.lblPriceTag.Size = new System.Drawing.Size(98, 15);
            this.lblPriceTag.TabIndex = 8;
            this.lblPriceTag.Text = "Installment Price:";
            // 
            // lblSerialDisplay
            // 
            this.lblSerialDisplay.AutoSize = true;
            this.lblSerialDisplay.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerialDisplay.Location = new System.Drawing.Point(140, 158);
            this.lblSerialDisplay.Name = "lblSerialDisplay";
            this.lblSerialDisplay.Size = new System.Drawing.Size(83, 17);
            this.lblSerialDisplay.TabIndex = 7;
            this.lblSerialDisplay.Text = "CAR-15-8824";
            // 
            // lblSerialTag
            // 
            this.lblSerialTag.AutoSize = true;
            this.lblSerialTag.Location = new System.Drawing.Point(15, 160);
            this.lblSerialTag.Name = "lblSerialTag";
            this.lblSerialTag.Size = new System.Drawing.Size(85, 15);
            this.lblSerialTag.TabIndex = 6;
            this.lblSerialTag.Text = "Serial Number:";
            // 
            // lblHPDisplay
            // 
            this.lblHPDisplay.AutoSize = true;
            this.lblHPDisplay.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHPDisplay.Location = new System.Drawing.Point(140, 126);
            this.lblHPDisplay.Name = "lblHPDisplay";
            this.lblHPDisplay.Size = new System.Drawing.Size(135, 17);
            this.lblHPDisplay.TabIndex = 5;
            this.lblHPDisplay.Text = "1.5 HP (Split Inverter)";
            // 
            // lblHPTag
            // 
            this.lblHPTag.AutoSize = true;
            this.lblHPTag.Location = new System.Drawing.Point(15, 128);
            this.lblHPTag.Name = "lblHPTag";
            this.lblHPTag.Size = new System.Drawing.Size(74, 15);
            this.lblHPTag.TabIndex = 4;
            this.lblHPTag.Text = "Horsepower:";
            // 
            // lblBrandDisplay
            // 
            this.lblBrandDisplay.AutoSize = true;
            this.lblBrandDisplay.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrandDisplay.Location = new System.Drawing.Point(140, 94);
            this.lblBrandDisplay.Name = "lblBrandDisplay";
            this.lblBrandDisplay.Size = new System.Drawing.Size(48, 17);
            this.lblBrandDisplay.TabIndex = 3;
            this.lblBrandDisplay.Text = "Carrier";
            // 
            // lblBrandTag
            // 
            this.lblBrandTag.AutoSize = true;
            this.lblBrandTag.Location = new System.Drawing.Point(15, 96);
            this.lblBrandTag.Name = "lblBrandTag";
            this.lblBrandTag.Size = new System.Drawing.Size(41, 15);
            this.lblBrandTag.TabIndex = 2;
            this.lblBrandTag.Text = "Brand:";
            // 
            // cmbSelectACUnit
            // 
            this.cmbSelectACUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectACUnit.FormattingEnabled = true;
            this.cmbSelectACUnit.Location = new System.Drawing.Point(140, 58);
            this.cmbSelectACUnit.Name = "cmbSelectACUnit";
            this.cmbSelectACUnit.Size = new System.Drawing.Size(310, 23);
            this.cmbSelectACUnit.TabIndex = 3;
            this.cmbSelectACUnit.SelectedIndexChanged += new System.EventHandler(this.cmbSelectACUnit_SelectedIndexChanged);
            // 
            // lblSelectAC
            // 
            this.lblSelectAC.AutoSize = true;
            this.lblSelectAC.Location = new System.Drawing.Point(15, 61);
            this.lblSelectAC.Name = "lblSelectAC";
            this.lblSelectAC.Size = new System.Drawing.Size(88, 15);
            this.lblSelectAC.TabIndex = 2;
            this.lblSelectAC.Text = "Available Units:";
            // 
            // grpTerms
            // 
            this.grpTerms.Controls.Add(this.numericUpDown1);
            this.grpTerms.Controls.Add(this.lblInterestRate);
            this.grpTerms.Controls.Add(this.btnPreviewSchedule);
            this.grpTerms.Controls.Add(this.lblMonthlyDue);
            this.grpTerms.Controls.Add(this.lblMonthlyDueTag);
            this.grpTerms.Controls.Add(this.lblRemainingBalance);
            this.grpTerms.Controls.Add(this.lblBalanceTag);
            this.grpTerms.Controls.Add(this.cmbTerms);
            this.grpTerms.Controls.Add(this.lblTerms);
            this.grpTerms.Controls.Add(this.nudDownPayment);
            this.grpTerms.Controls.Add(this.lblDownPayment);
            this.grpTerms.Controls.Add(this.dtpContractDate);
            this.grpTerms.Controls.Add(this.lblSaleDate);
            this.grpTerms.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTerms.Location = new System.Drawing.Point(17, 285);
            this.grpTerms.Name = "grpTerms";
            this.grpTerms.Size = new System.Drawing.Size(984, 115);
            this.grpTerms.TabIndex = 3;
            this.grpTerms.TabStop = false;
            this.grpTerms.Text = "3. Installment Terms and Calculation";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(606, 72);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            300000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(65, 23);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.ThousandsSeparator = true;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Location = new System.Drawing.Point(525, 75);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(75, 15);
            this.lblInterestRate.TabIndex = 11;
            this.lblInterestRate.Text = "Interest Rate:";
            this.lblInterestRate.Click += new System.EventHandler(this.lblInterestRate_Click);
            // 
            // btnPreviewSchedule
            // 
            this.btnPreviewSchedule.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviewSchedule.Location = new System.Drawing.Point(760, 68);
            this.btnPreviewSchedule.Name = "btnPreviewSchedule";
            this.btnPreviewSchedule.Size = new System.Drawing.Size(175, 32);
            this.btnPreviewSchedule.TabIndex = 10;
            this.btnPreviewSchedule.Text = "Generate Preview Schedule Table";
            this.btnPreviewSchedule.UseVisualStyleBackColor = true;
            this.btnPreviewSchedule.Click += new System.EventHandler(this.btnPreviewSchedule_Click);
            // 
            // lblMonthlyDue
            // 
            this.lblMonthlyDue.AutoSize = true;
            this.lblMonthlyDue.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyDue.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblMonthlyDue.Location = new System.Drawing.Point(760, 30);
            this.lblMonthlyDue.Name = "lblMonthlyDue";
            this.lblMonthlyDue.Size = new System.Drawing.Size(111, 19);
            this.lblMonthlyDue.TabIndex = 9;
            this.lblMonthlyDue.Text = "P------ / month";
            // 
            // lblMonthlyDueTag
            // 
            this.lblMonthlyDueTag.AutoSize = true;
            this.lblMonthlyDueTag.Location = new System.Drawing.Point(650, 32);
            this.lblMonthlyDueTag.Name = "lblMonthlyDueTag";
            this.lblMonthlyDueTag.Size = new System.Drawing.Size(79, 15);
            this.lblMonthlyDueTag.TabIndex = 8;
            this.lblMonthlyDueTag.Text = "Monthly Due:";
            // 
            // lblRemainingBalance
            // 
            this.lblRemainingBalance.AutoSize = true;
            this.lblRemainingBalance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainingBalance.Location = new System.Drawing.Point(430, 72);
            this.lblRemainingBalance.Name = "lblRemainingBalance";
            this.lblRemainingBalance.Size = new System.Drawing.Size(60, 20);
            this.lblRemainingBalance.TabIndex = 7;
            this.lblRemainingBalance.Text = "P-------";
            this.lblRemainingBalance.Click += new System.EventHandler(this.lblRemainingBalance_Click);
            // 
            // lblBalanceTag
            // 
            this.lblBalanceTag.AutoSize = true;
            this.lblBalanceTag.Location = new System.Drawing.Point(320, 74);
            this.lblBalanceTag.Name = "lblBalanceTag";
            this.lblBalanceTag.Size = new System.Drawing.Size(86, 15);
            this.lblBalanceTag.TabIndex = 6;
            this.lblBalanceTag.Text = "Remaining Bal:";
            // 
            // cmbTerms
            // 
            this.cmbTerms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTerms.FormattingEnabled = true;
            this.cmbTerms.Items.AddRange(new object[] {
            "3 Months",
            "5 Months",
            "6 Months",
            "9 Months",
            "12 Months"});
            this.cmbTerms.Location = new System.Drawing.Point(430, 28);
            this.cmbTerms.Name = "cmbTerms";
            this.cmbTerms.Size = new System.Drawing.Size(160, 23);
            this.cmbTerms.TabIndex = 5;
            this.cmbTerms.SelectedIndexChanged += new System.EventHandler(this.cmbTerms_SelectedIndexChanged);
            // 
            // lblTerms
            // 
            this.lblTerms.AutoSize = true;
            this.lblTerms.Location = new System.Drawing.Point(320, 31);
            this.lblTerms.Name = "lblTerms";
            this.lblTerms.Size = new System.Drawing.Size(93, 15);
            this.lblTerms.TabIndex = 4;
            this.lblTerms.Text = "Terms (Months):";
            // 
            // nudDownPayment
            // 
            this.nudDownPayment.DecimalPlaces = 2;
            this.nudDownPayment.Location = new System.Drawing.Point(120, 73);
            this.nudDownPayment.Maximum = new decimal(new int[] {
            300000,
            0,
            0,
            0});
            this.nudDownPayment.Name = "nudDownPayment";
            this.nudDownPayment.Size = new System.Drawing.Size(175, 23);
            this.nudDownPayment.TabIndex = 3;
            this.nudDownPayment.ThousandsSeparator = true;
            this.nudDownPayment.TextChanged += new System.EventHandler(this.nudDownPayment_TextChanged);
            this.nudDownPayment.ValueChanged += new System.EventHandler(this.nudDownPayment_ValueChanged);
            // 
            // lblDownPayment
            // 
            this.lblDownPayment.AutoSize = true;
            this.lblDownPayment.Location = new System.Drawing.Point(15, 76);
            this.lblDownPayment.Name = "lblDownPayment";
            this.lblDownPayment.Size = new System.Drawing.Size(91, 15);
            this.lblDownPayment.TabIndex = 2;
            this.lblDownPayment.Text = "Down Payment:";
            // 
            // dtpContractDate
            // 
            this.dtpContractDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpContractDate.Location = new System.Drawing.Point(120, 28);
            this.dtpContractDate.Name = "dtpContractDate";
            this.dtpContractDate.Size = new System.Drawing.Size(175, 23);
            this.dtpContractDate.TabIndex = 1;
            // 
            // lblSaleDate
            // 
            this.lblSaleDate.AutoSize = true;
            this.lblSaleDate.Location = new System.Drawing.Point(15, 31);
            this.lblSaleDate.Name = "lblSaleDate";
            this.lblSaleDate.Size = new System.Drawing.Size(58, 15);
            this.lblSaleDate.TabIndex = 0;
            this.lblSaleDate.Text = "Sale Date:";
            // 
            // grpSchedule
            // 
            this.grpSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSchedule.Controls.Add(this.dgvSchedulePreview);
            this.grpSchedule.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSchedule.Location = new System.Drawing.Point(17, 410);
            this.grpSchedule.Name = "grpSchedule";
            this.grpSchedule.Size = new System.Drawing.Size(987, 175);
            this.grpSchedule.TabIndex = 4;
            this.grpSchedule.TabStop = false;
            this.grpSchedule.Text = "4. Auto-Generated Monthly Payment Schedule Preview";
            // 
            // dgvSchedulePreview
            // 
            this.dgvSchedulePreview.AllowUserToAddRows = false;
            this.dgvSchedulePreview.AllowUserToDeleteRows = false;
            this.dgvSchedulePreview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSchedulePreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedulePreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSchedulePreview.Location = new System.Drawing.Point(3, 19);
            this.dgvSchedulePreview.Name = "dgvSchedulePreview";
            this.dgvSchedulePreview.ReadOnly = true;
            this.dgvSchedulePreview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSchedulePreview.Size = new System.Drawing.Size(981, 153);
            this.dgvSchedulePreview.TabIndex = 0;
            // 
            // lblInstallNotes
            // 
            this.lblInstallNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblInstallNotes.AutoSize = true;
            this.lblInstallNotes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstallNotes.Location = new System.Drawing.Point(17, 600);
            this.lblInstallNotes.Name = "lblInstallNotes";
            this.lblInstallNotes.Size = new System.Drawing.Size(102, 15);
            this.lblInstallNotes.TabIndex = 5;
            this.lblInstallNotes.Text = "Installation Notes:";
            // 
            // txtInstallationNotes
            // 
            this.txtInstallationNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtInstallationNotes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstallationNotes.Location = new System.Drawing.Point(125, 597);
            this.txtInstallationNotes.Name = "txtInstallationNotes";
            this.txtInstallationNotes.Size = new System.Drawing.Size(230, 23);
            this.txtInstallationNotes.TabIndex = 6;
            // 
            // lblTechnician
            // 
            this.lblTechnician.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTechnician.AutoSize = true;
            this.lblTechnician.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTechnician.Location = new System.Drawing.Point(365, 600);
            this.lblTechnician.Name = "lblTechnician";
            this.lblTechnician.Size = new System.Drawing.Size(94, 15);
            this.lblTechnician.TabIndex = 9;
            this.lblTechnician.Text = "Lead Technician:";
            // 
            // cmbTechnician
            // 
            this.cmbTechnician.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTechnician.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTechnician.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTechnician.FormattingEnabled = true;
            this.cmbTechnician.Location = new System.Drawing.Point(468, 597);
            this.cmbTechnician.Name = "cmbTechnician";
            this.cmbTechnician.Size = new System.Drawing.Size(156, 23);
            this.cmbTechnician.TabIndex = 10;
            // 
            // btnSaveContract
            // 
            this.btnSaveContract.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveContract.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveContract.Location = new System.Drawing.Point(634, 592);
            this.btnSaveContract.Name = "btnSaveContract";
            this.btnSaveContract.Size = new System.Drawing.Size(255, 32);
            this.btnSaveContract.TabIndex = 7;
            this.btnSaveContract.Text = "Save Contract";
            this.btnSaveContract.UseVisualStyleBackColor = true;
            this.btnSaveContract.Click += new System.EventHandler(this.btnSaveContract_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(904, 592);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 32);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormNewSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 635);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveContract);
            this.Controls.Add(this.cmbTechnician);
            this.Controls.Add(this.lblTechnician);
            this.Controls.Add(this.txtInstallationNotes);
            this.Controls.Add(this.lblInstallNotes);
            this.Controls.Add(this.grpSchedule);
            this.Controls.Add(this.grpTerms);
            this.Controls.Add(this.grpACUnit);
            this.Controls.Add(this.grpCustomer);
            this.Name = "FormNewSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Installment Sale & Schedule Generator";
            this.Load += new System.EventHandler(this.FormNewSale_Load);
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.grpACUnit.ResumeLayout(false);
            this.grpACUnit.PerformLayout();
            this.grpTerms.ResumeLayout(false);
            this.grpTerms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDownPayment)).EndInit();
            this.grpSchedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedulePreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.TextBox txtValidID;
        private System.Windows.Forms.Label lblValidID;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.ComboBox cmbCustomerList;
        private System.Windows.Forms.Label lblExistingCust;
        private System.Windows.Forms.GroupBox grpACUnit;
        private System.Windows.Forms.Label lblBrandFilter;
        private System.Windows.Forms.ComboBox cmbBrandFilter;
        private System.Windows.Forms.Label lblPriceDisplay;
        private System.Windows.Forms.Label lblPriceTag;
        private System.Windows.Forms.Label lblSerialDisplay;
        private System.Windows.Forms.Label lblSerialTag;
        private System.Windows.Forms.Label lblHPDisplay;
        private System.Windows.Forms.Label lblHPTag;
        private System.Windows.Forms.Label lblBrandDisplay;
        private System.Windows.Forms.Label lblBrandTag;
        private System.Windows.Forms.ComboBox cmbSelectACUnit;
        private System.Windows.Forms.Label lblSelectAC;
        private System.Windows.Forms.GroupBox grpTerms;
        private System.Windows.Forms.Button btnPreviewSchedule;
        private System.Windows.Forms.Label lblMonthlyDue;
        private System.Windows.Forms.Label lblMonthlyDueTag;
        private System.Windows.Forms.Label lblRemainingBalance;
        private System.Windows.Forms.Label lblBalanceTag;
        private System.Windows.Forms.ComboBox cmbTerms;
        private System.Windows.Forms.Label lblTerms;
        private System.Windows.Forms.NumericUpDown nudDownPayment;
        private System.Windows.Forms.Label lblDownPayment;
        private System.Windows.Forms.DateTimePicker dtpContractDate;
        private System.Windows.Forms.Label lblSaleDate;
        private System.Windows.Forms.GroupBox grpSchedule;
        private System.Windows.Forms.DataGridView dgvSchedulePreview;
        private System.Windows.Forms.Label lblInstallNotes;
        private System.Windows.Forms.TextBox txtInstallationNotes;
        private System.Windows.Forms.Label lblTechnician;
        private System.Windows.Forms.ComboBox cmbTechnician;
        private System.Windows.Forms.Button btnSaveContract;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblInterestRate;
    }
}

