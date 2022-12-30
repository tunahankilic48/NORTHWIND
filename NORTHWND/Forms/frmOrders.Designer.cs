namespace NORTHWND.Forms
{
    partial class frmOrders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rdbShipVia = new System.Windows.Forms.RadioButton();
            this.rdbCountry = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rdbName = new System.Windows.Forms.RadioButton();
            this.rdbCustomer = new System.Windows.Forms.RadioButton();
            this.rdbCity = new System.Windows.Forms.RadioButton();
            this.rdbEmployee = new System.Windows.Forms.RadioButton();
            this.rdbOrderID = new System.Windows.Forms.RadioButton();
            this.txtShipRegion = new System.Windows.Forms.TextBox();
            this.btnListallOrders = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblShipCountrySearch = new System.Windows.Forms.Label();
            this.lblShipCitySearch = new System.Windows.Forms.Label();
            this.lblShipNameSearch = new System.Windows.Forms.Label();
            this.rdbRequiredDate = new System.Windows.Forms.RadioButton();
            this.lblFreightSearch = new System.Windows.Forms.Label();
            this.rdbShippedDate = new System.Windows.Forms.RadioButton();
            this.rdbFreight = new System.Windows.Forms.RadioButton();
            this.lblShippedDateSearch = new System.Windows.Forms.Label();
            this.lblEmployeeSearch = new System.Windows.Forms.Label();
            this.rdbOrderDate = new System.Windows.Forms.RadioButton();
            this.lblRequiredDateSearch = new System.Windows.Forms.Label();
            this.cbbEmployeeSearch = new System.Windows.Forms.ComboBox();
            this.lblShipViaSearch = new System.Windows.Forms.Label();
            this.lblOrderDateSearch = new System.Windows.Forms.Label();
            this.lblCustomerSearch = new System.Windows.Forms.Label();
            this.txtOrderIDSearch = new System.Windows.Forms.TextBox();
            this.dtpShippedDateSearch = new System.Windows.Forms.DateTimePicker();
            this.cbbCustomerSearch = new System.Windows.Forms.ComboBox();
            this.dtpRequiredDateSearch = new System.Windows.Forms.DateTimePicker();
            this.txtShipCountrySearch = new System.Windows.Forms.TextBox();
            this.lblOrderIDSearch = new System.Windows.Forms.Label();
            this.txtFreightSearch = new System.Windows.Forms.TextBox();
            this.dtpOrderdateSearch = new System.Windows.Forms.DateTimePicker();
            this.txtShipNameSearch = new System.Windows.Forms.TextBox();
            this.txtShipCitySearch = new System.Windows.Forms.TextBox();
            this.cbbShipViaSearch = new System.Windows.Forms.ComboBox();
            this.lblShipRegion = new System.Windows.Forms.Label();
            this.btnX = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblShipCountry = new System.Windows.Forms.Label();
            this.lblShipPostalCode = new System.Windows.Forms.Label();
            this.lblShipCity = new System.Windows.Forms.Label();
            this.lblShipName = new System.Windows.Forms.Label();
            this.lblShipDate = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblShipAddress = new System.Windows.Forms.Label();
            this.lblFreight = new System.Windows.Forms.Label();
            this.lblRequiredDate = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblShipVia = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.dtpShippedDate = new System.Windows.Forms.DateTimePicker();
            this.dtpRequiredDate = new System.Windows.Forms.DateTimePicker();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.cbbShipVia = new System.Windows.Forms.ComboBox();
            this.cbbEmployee = new System.Windows.Forms.ComboBox();
            this.cbbCustomer = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblOrders = new System.Windows.Forms.Label();
            this.txtShipCountry = new System.Windows.Forms.TextBox();
            this.txtShipPostalCode = new System.Windows.Forms.TextBox();
            this.txtShipCity = new System.Windows.Forms.TextBox();
            this.txtShipName = new System.Windows.Forms.TextBox();
            this.txtShipAddress = new System.Windows.Forms.TextBox();
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbShipVia
            // 
            this.rdbShipVia.AutoSize = true;
            this.rdbShipVia.ForeColor = System.Drawing.Color.White;
            this.rdbShipVia.Location = new System.Drawing.Point(981, 129);
            this.rdbShipVia.Name = "rdbShipVia";
            this.rdbShipVia.Size = new System.Drawing.Size(93, 27);
            this.rdbShipVia.TabIndex = 32;
            this.rdbShipVia.TabStop = true;
            this.rdbShipVia.Text = "Ship Via";
            this.rdbShipVia.UseVisualStyleBackColor = true;
            // 
            // rdbCountry
            // 
            this.rdbCountry.AutoSize = true;
            this.rdbCountry.ForeColor = System.Drawing.Color.White;
            this.rdbCountry.Location = new System.Drawing.Point(1239, 61);
            this.rdbCountry.Name = "rdbCountry";
            this.rdbCountry.Size = new System.Drawing.Size(92, 27);
            this.rdbCountry.TabIndex = 37;
            this.rdbCountry.TabStop = true;
            this.rdbCountry.Text = "Country";
            this.rdbCountry.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(1330, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(124, 49);
            this.btnSearch.TabIndex = 40;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rdbName
            // 
            this.rdbName.AutoSize = true;
            this.rdbName.ForeColor = System.Drawing.Color.White;
            this.rdbName.Location = new System.Drawing.Point(1239, 97);
            this.rdbName.Name = "rdbName";
            this.rdbName.Size = new System.Drawing.Size(77, 27);
            this.rdbName.TabIndex = 38;
            this.rdbName.TabStop = true;
            this.rdbName.Text = "Name";
            this.rdbName.UseVisualStyleBackColor = true;
            // 
            // rdbCustomer
            // 
            this.rdbCustomer.AutoSize = true;
            this.rdbCustomer.ForeColor = System.Drawing.Color.White;
            this.rdbCustomer.Location = new System.Drawing.Point(981, 59);
            this.rdbCustomer.Name = "rdbCustomer";
            this.rdbCustomer.Size = new System.Drawing.Size(105, 27);
            this.rdbCustomer.TabIndex = 30;
            this.rdbCustomer.TabStop = true;
            this.rdbCustomer.Text = "Customer";
            this.rdbCustomer.UseVisualStyleBackColor = true;
            // 
            // rdbCity
            // 
            this.rdbCity.AutoSize = true;
            this.rdbCity.ForeColor = System.Drawing.Color.White;
            this.rdbCity.Location = new System.Drawing.Point(1239, 25);
            this.rdbCity.Name = "rdbCity";
            this.rdbCity.Size = new System.Drawing.Size(60, 27);
            this.rdbCity.TabIndex = 36;
            this.rdbCity.TabStop = true;
            this.rdbCity.Text = "City";
            this.rdbCity.UseVisualStyleBackColor = true;
            // 
            // rdbEmployee
            // 
            this.rdbEmployee.AutoSize = true;
            this.rdbEmployee.ForeColor = System.Drawing.Color.White;
            this.rdbEmployee.Location = new System.Drawing.Point(981, 95);
            this.rdbEmployee.Name = "rdbEmployee";
            this.rdbEmployee.Size = new System.Drawing.Size(105, 27);
            this.rdbEmployee.TabIndex = 31;
            this.rdbEmployee.TabStop = true;
            this.rdbEmployee.Text = "Employee";
            this.rdbEmployee.UseVisualStyleBackColor = true;
            // 
            // rdbOrderID
            // 
            this.rdbOrderID.AutoSize = true;
            this.rdbOrderID.ForeColor = System.Drawing.Color.White;
            this.rdbOrderID.Location = new System.Drawing.Point(981, 23);
            this.rdbOrderID.Name = "rdbOrderID";
            this.rdbOrderID.Size = new System.Drawing.Size(48, 27);
            this.rdbOrderID.TabIndex = 29;
            this.rdbOrderID.TabStop = true;
            this.rdbOrderID.Text = "ID";
            this.rdbOrderID.UseVisualStyleBackColor = true;
            // 
            // txtShipRegion
            // 
            this.txtShipRegion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtShipRegion.ForeColor = System.Drawing.Color.White;
            this.txtShipRegion.Location = new System.Drawing.Point(144, 477);
            this.txtShipRegion.Name = "txtShipRegion";
            this.txtShipRegion.Size = new System.Drawing.Size(205, 30);
            this.txtShipRegion.TabIndex = 12;
            this.txtShipRegion.TextChanged += new System.EventHandler(this.txtShipRegion_TextChanged);
            // 
            // btnListallOrders
            // 
            this.btnListallOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnListallOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListallOrders.Location = new System.Drawing.Point(1330, 116);
            this.btnListallOrders.Name = "btnListallOrders";
            this.btnListallOrders.Size = new System.Drawing.Size(124, 49);
            this.btnListallOrders.TabIndex = 41;
            this.btnListallOrders.Text = "List all Orders";
            this.btnListallOrders.UseVisualStyleBackColor = false;
            this.btnListallOrders.Click += new System.EventHandler(this.btnListallOrders_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblShipCountrySearch);
            this.groupBox2.Controls.Add(this.rdbShipVia);
            this.groupBox2.Controls.Add(this.btnListallOrders);
            this.groupBox2.Controls.Add(this.lblShipCitySearch);
            this.groupBox2.Controls.Add(this.lblShipNameSearch);
            this.groupBox2.Controls.Add(this.rdbRequiredDate);
            this.groupBox2.Controls.Add(this.rdbCountry);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.lblFreightSearch);
            this.groupBox2.Controls.Add(this.rdbShippedDate);
            this.groupBox2.Controls.Add(this.rdbFreight);
            this.groupBox2.Controls.Add(this.rdbName);
            this.groupBox2.Controls.Add(this.lblShippedDateSearch);
            this.groupBox2.Controls.Add(this.rdbCustomer);
            this.groupBox2.Controls.Add(this.lblEmployeeSearch);
            this.groupBox2.Controls.Add(this.rdbOrderDate);
            this.groupBox2.Controls.Add(this.rdbCity);
            this.groupBox2.Controls.Add(this.rdbEmployee);
            this.groupBox2.Controls.Add(this.lblRequiredDateSearch);
            this.groupBox2.Controls.Add(this.rdbOrderID);
            this.groupBox2.Controls.Add(this.cbbEmployeeSearch);
            this.groupBox2.Controls.Add(this.lblShipViaSearch);
            this.groupBox2.Controls.Add(this.lblOrderDateSearch);
            this.groupBox2.Controls.Add(this.lblCustomerSearch);
            this.groupBox2.Controls.Add(this.txtOrderIDSearch);
            this.groupBox2.Controls.Add(this.dtpShippedDateSearch);
            this.groupBox2.Controls.Add(this.cbbCustomerSearch);
            this.groupBox2.Controls.Add(this.dtpRequiredDateSearch);
            this.groupBox2.Controls.Add(this.txtShipCountrySearch);
            this.groupBox2.Controls.Add(this.lblOrderIDSearch);
            this.groupBox2.Controls.Add(this.txtFreightSearch);
            this.groupBox2.Controls.Add(this.dtpOrderdateSearch);
            this.groupBox2.Controls.Add(this.txtShipNameSearch);
            this.groupBox2.Controls.Add(this.txtShipCitySearch);
            this.groupBox2.Controls.Add(this.cbbShipViaSearch);
            this.groupBox2.Location = new System.Drawing.Point(3, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1460, 182);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // lblShipCountrySearch
            // 
            this.lblShipCountrySearch.AutoSize = true;
            this.lblShipCountrySearch.ForeColor = System.Drawing.Color.White;
            this.lblShipCountrySearch.Location = new System.Drawing.Point(647, 60);
            this.lblShipCountrySearch.Name = "lblShipCountrySearch";
            this.lblShipCountrySearch.Size = new System.Drawing.Size(113, 23);
            this.lblShipCountrySearch.TabIndex = 1;
            this.lblShipCountrySearch.Text = "Ship Country:";
            // 
            // lblShipCitySearch
            // 
            this.lblShipCitySearch.AutoSize = true;
            this.lblShipCitySearch.ForeColor = System.Drawing.Color.White;
            this.lblShipCitySearch.Location = new System.Drawing.Point(679, 22);
            this.lblShipCitySearch.Name = "lblShipCitySearch";
            this.lblShipCitySearch.Size = new System.Drawing.Size(81, 23);
            this.lblShipCitySearch.TabIndex = 1;
            this.lblShipCitySearch.Text = "Ship City:";
            // 
            // lblShipNameSearch
            // 
            this.lblShipNameSearch.AutoSize = true;
            this.lblShipNameSearch.ForeColor = System.Drawing.Color.White;
            this.lblShipNameSearch.Location = new System.Drawing.Point(662, 97);
            this.lblShipNameSearch.Name = "lblShipNameSearch";
            this.lblShipNameSearch.Size = new System.Drawing.Size(98, 23);
            this.lblShipNameSearch.TabIndex = 1;
            this.lblShipNameSearch.Text = "Ship Name:";
            // 
            // rdbRequiredDate
            // 
            this.rdbRequiredDate.AutoSize = true;
            this.rdbRequiredDate.ForeColor = System.Drawing.Color.White;
            this.rdbRequiredDate.Location = new System.Drawing.Point(1094, 77);
            this.rdbRequiredDate.Name = "rdbRequiredDate";
            this.rdbRequiredDate.Size = new System.Drawing.Size(140, 27);
            this.rdbRequiredDate.TabIndex = 34;
            this.rdbRequiredDate.TabStop = true;
            this.rdbRequiredDate.Text = "Required Date";
            this.rdbRequiredDate.UseVisualStyleBackColor = true;
            // 
            // lblFreightSearch
            // 
            this.lblFreightSearch.AutoSize = true;
            this.lblFreightSearch.ForeColor = System.Drawing.Color.White;
            this.lblFreightSearch.Location = new System.Drawing.Point(693, 136);
            this.lblFreightSearch.Name = "lblFreightSearch";
            this.lblFreightSearch.Size = new System.Drawing.Size(67, 23);
            this.lblFreightSearch.TabIndex = 1;
            this.lblFreightSearch.Text = "Freight:";
            // 
            // rdbShippedDate
            // 
            this.rdbShippedDate.AutoSize = true;
            this.rdbShippedDate.ForeColor = System.Drawing.Color.White;
            this.rdbShippedDate.Location = new System.Drawing.Point(1094, 113);
            this.rdbShippedDate.Name = "rdbShippedDate";
            this.rdbShippedDate.Size = new System.Drawing.Size(134, 27);
            this.rdbShippedDate.TabIndex = 35;
            this.rdbShippedDate.TabStop = true;
            this.rdbShippedDate.Text = "Shipped Date";
            this.rdbShippedDate.UseVisualStyleBackColor = true;
            // 
            // rdbFreight
            // 
            this.rdbFreight.AutoSize = true;
            this.rdbFreight.ForeColor = System.Drawing.Color.White;
            this.rdbFreight.Location = new System.Drawing.Point(1239, 129);
            this.rdbFreight.Name = "rdbFreight";
            this.rdbFreight.Size = new System.Drawing.Size(84, 27);
            this.rdbFreight.TabIndex = 39;
            this.rdbFreight.TabStop = true;
            this.rdbFreight.Text = "Freight";
            this.rdbFreight.UseVisualStyleBackColor = true;
            // 
            // lblShippedDateSearch
            // 
            this.lblShippedDateSearch.AutoSize = true;
            this.lblShippedDateSearch.ForeColor = System.Drawing.Color.White;
            this.lblShippedDateSearch.Location = new System.Drawing.Point(320, 123);
            this.lblShippedDateSearch.Name = "lblShippedDateSearch";
            this.lblShippedDateSearch.Size = new System.Drawing.Size(117, 23);
            this.lblShippedDateSearch.TabIndex = 1;
            this.lblShippedDateSearch.Text = "Shipped Date:";
            // 
            // lblEmployeeSearch
            // 
            this.lblEmployeeSearch.AutoSize = true;
            this.lblEmployeeSearch.ForeColor = System.Drawing.Color.White;
            this.lblEmployeeSearch.Location = new System.Drawing.Point(7, 97);
            this.lblEmployeeSearch.Name = "lblEmployeeSearch";
            this.lblEmployeeSearch.Size = new System.Drawing.Size(88, 23);
            this.lblEmployeeSearch.TabIndex = 1;
            this.lblEmployeeSearch.Text = "Employee:";
            // 
            // rdbOrderDate
            // 
            this.rdbOrderDate.AutoSize = true;
            this.rdbOrderDate.ForeColor = System.Drawing.Color.White;
            this.rdbOrderDate.Location = new System.Drawing.Point(1094, 41);
            this.rdbOrderDate.Name = "rdbOrderDate";
            this.rdbOrderDate.Size = new System.Drawing.Size(116, 27);
            this.rdbOrderDate.TabIndex = 33;
            this.rdbOrderDate.TabStop = true;
            this.rdbOrderDate.Text = "Order Date";
            this.rdbOrderDate.UseVisualStyleBackColor = true;
            // 
            // lblRequiredDateSearch
            // 
            this.lblRequiredDateSearch.AutoSize = true;
            this.lblRequiredDateSearch.ForeColor = System.Drawing.Color.White;
            this.lblRequiredDateSearch.Location = new System.Drawing.Point(313, 84);
            this.lblRequiredDateSearch.Name = "lblRequiredDateSearch";
            this.lblRequiredDateSearch.Size = new System.Drawing.Size(123, 23);
            this.lblRequiredDateSearch.TabIndex = 1;
            this.lblRequiredDateSearch.Text = "Required Date:";
            // 
            // cbbEmployeeSearch
            // 
            this.cbbEmployeeSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.cbbEmployeeSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEmployeeSearch.ForeColor = System.Drawing.Color.White;
            this.cbbEmployeeSearch.FormattingEnabled = true;
            this.cbbEmployeeSearch.Location = new System.Drawing.Point(97, 95);
            this.cbbEmployeeSearch.Name = "cbbEmployeeSearch";
            this.cbbEmployeeSearch.Size = new System.Drawing.Size(204, 31);
            this.cbbEmployeeSearch.TabIndex = 20;
            // 
            // lblShipViaSearch
            // 
            this.lblShipViaSearch.AutoSize = true;
            this.lblShipViaSearch.ForeColor = System.Drawing.Color.White;
            this.lblShipViaSearch.Location = new System.Drawing.Point(19, 137);
            this.lblShipViaSearch.Name = "lblShipViaSearch";
            this.lblShipViaSearch.Size = new System.Drawing.Size(76, 23);
            this.lblShipViaSearch.TabIndex = 1;
            this.lblShipViaSearch.Text = "Ship Via:";
            // 
            // lblOrderDateSearch
            // 
            this.lblOrderDateSearch.AutoSize = true;
            this.lblOrderDateSearch.ForeColor = System.Drawing.Color.White;
            this.lblOrderDateSearch.Location = new System.Drawing.Point(336, 43);
            this.lblOrderDateSearch.Name = "lblOrderDateSearch";
            this.lblOrderDateSearch.Size = new System.Drawing.Size(99, 23);
            this.lblOrderDateSearch.TabIndex = 1;
            this.lblOrderDateSearch.Text = "Order Date:";
            // 
            // lblCustomerSearch
            // 
            this.lblCustomerSearch.AutoSize = true;
            this.lblCustomerSearch.ForeColor = System.Drawing.Color.White;
            this.lblCustomerSearch.Location = new System.Drawing.Point(7, 61);
            this.lblCustomerSearch.Name = "lblCustomerSearch";
            this.lblCustomerSearch.Size = new System.Drawing.Size(88, 23);
            this.lblCustomerSearch.TabIndex = 1;
            this.lblCustomerSearch.Text = "Customer:";
            // 
            // txtOrderIDSearch
            // 
            this.txtOrderIDSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtOrderIDSearch.ForeColor = System.Drawing.Color.White;
            this.txtOrderIDSearch.Location = new System.Drawing.Point(97, 23);
            this.txtOrderIDSearch.Name = "txtOrderIDSearch";
            this.txtOrderIDSearch.Size = new System.Drawing.Size(205, 30);
            this.txtOrderIDSearch.TabIndex = 18;
            // 
            // dtpShippedDateSearch
            // 
            this.dtpShippedDateSearch.CustomFormat = "dd   MMMM   yyyy";
            this.dtpShippedDateSearch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpShippedDateSearch.Location = new System.Drawing.Point(439, 117);
            this.dtpShippedDateSearch.Name = "dtpShippedDateSearch";
            this.dtpShippedDateSearch.Size = new System.Drawing.Size(205, 30);
            this.dtpShippedDateSearch.TabIndex = 24;
            this.dtpShippedDateSearch.Value = new System.DateTime(2022, 12, 29, 0, 0, 0, 0);
            // 
            // cbbCustomerSearch
            // 
            this.cbbCustomerSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.cbbCustomerSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCustomerSearch.ForeColor = System.Drawing.Color.White;
            this.cbbCustomerSearch.FormattingEnabled = true;
            this.cbbCustomerSearch.Location = new System.Drawing.Point(98, 60);
            this.cbbCustomerSearch.Name = "cbbCustomerSearch";
            this.cbbCustomerSearch.Size = new System.Drawing.Size(204, 31);
            this.cbbCustomerSearch.TabIndex = 19;
            // 
            // dtpRequiredDateSearch
            // 
            this.dtpRequiredDateSearch.CustomFormat = "dd   MMMM   yyyy";
            this.dtpRequiredDateSearch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRequiredDateSearch.Location = new System.Drawing.Point(438, 79);
            this.dtpRequiredDateSearch.Name = "dtpRequiredDateSearch";
            this.dtpRequiredDateSearch.Size = new System.Drawing.Size(205, 30);
            this.dtpRequiredDateSearch.TabIndex = 23;
            this.dtpRequiredDateSearch.Value = new System.DateTime(2022, 12, 29, 0, 0, 0, 0);
            // 
            // txtShipCountrySearch
            // 
            this.txtShipCountrySearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtShipCountrySearch.ForeColor = System.Drawing.Color.White;
            this.txtShipCountrySearch.Location = new System.Drawing.Point(761, 59);
            this.txtShipCountrySearch.Name = "txtShipCountrySearch";
            this.txtShipCountrySearch.Size = new System.Drawing.Size(205, 30);
            this.txtShipCountrySearch.TabIndex = 26;
            // 
            // lblOrderIDSearch
            // 
            this.lblOrderIDSearch.AutoSize = true;
            this.lblOrderIDSearch.ForeColor = System.Drawing.Color.White;
            this.lblOrderIDSearch.Location = new System.Drawing.Point(15, 25);
            this.lblOrderIDSearch.Name = "lblOrderIDSearch";
            this.lblOrderIDSearch.Size = new System.Drawing.Size(80, 23);
            this.lblOrderIDSearch.TabIndex = 1;
            this.lblOrderIDSearch.Text = "Order ID:";
            // 
            // txtFreightSearch
            // 
            this.txtFreightSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtFreightSearch.ForeColor = System.Drawing.Color.White;
            this.txtFreightSearch.Location = new System.Drawing.Point(761, 134);
            this.txtFreightSearch.Name = "txtFreightSearch";
            this.txtFreightSearch.Size = new System.Drawing.Size(205, 30);
            this.txtFreightSearch.TabIndex = 28;
            // 
            // dtpOrderdateSearch
            // 
            this.dtpOrderdateSearch.CustomFormat = "dd   MMMM   yyyy";
            this.dtpOrderdateSearch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOrderdateSearch.Location = new System.Drawing.Point(438, 42);
            this.dtpOrderdateSearch.Name = "dtpOrderdateSearch";
            this.dtpOrderdateSearch.Size = new System.Drawing.Size(203, 30);
            this.dtpOrderdateSearch.TabIndex = 22;
            this.dtpOrderdateSearch.Value = new System.DateTime(2022, 12, 29, 0, 0, 0, 0);
            // 
            // txtShipNameSearch
            // 
            this.txtShipNameSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtShipNameSearch.ForeColor = System.Drawing.Color.White;
            this.txtShipNameSearch.Location = new System.Drawing.Point(761, 95);
            this.txtShipNameSearch.Name = "txtShipNameSearch";
            this.txtShipNameSearch.Size = new System.Drawing.Size(205, 30);
            this.txtShipNameSearch.TabIndex = 27;
            // 
            // txtShipCitySearch
            // 
            this.txtShipCitySearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtShipCitySearch.ForeColor = System.Drawing.Color.White;
            this.txtShipCitySearch.Location = new System.Drawing.Point(761, 22);
            this.txtShipCitySearch.Name = "txtShipCitySearch";
            this.txtShipCitySearch.Size = new System.Drawing.Size(205, 30);
            this.txtShipCitySearch.TabIndex = 25;
            // 
            // cbbShipViaSearch
            // 
            this.cbbShipViaSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.cbbShipViaSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbShipViaSearch.ForeColor = System.Drawing.Color.White;
            this.cbbShipViaSearch.FormattingEnabled = true;
            this.cbbShipViaSearch.Location = new System.Drawing.Point(97, 134);
            this.cbbShipViaSearch.Name = "cbbShipViaSearch";
            this.cbbShipViaSearch.Size = new System.Drawing.Size(204, 31);
            this.cbbShipViaSearch.TabIndex = 21;
            // 
            // lblShipRegion
            // 
            this.lblShipRegion.AutoSize = true;
            this.lblShipRegion.ForeColor = System.Drawing.Color.White;
            this.lblShipRegion.Location = new System.Drawing.Point(38, 478);
            this.lblShipRegion.Name = "lblShipRegion";
            this.lblShipRegion.Size = new System.Drawing.Size(105, 23);
            this.lblShipRegion.TabIndex = 1;
            this.lblShipRegion.Text = "Ship Region:";
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.Red;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.ForeColor = System.Drawing.Color.White;
            this.btnX.Location = new System.Drawing.Point(1840, -1);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(33, 33);
            this.btnX.TabIndex = 43;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblShipCountry);
            this.groupBox1.Controls.Add(this.lblShipRegion);
            this.groupBox1.Controls.Add(this.lblShipPostalCode);
            this.groupBox1.Controls.Add(this.lblShipCity);
            this.groupBox1.Controls.Add(this.lblShipName);
            this.groupBox1.Controls.Add(this.lblShipDate);
            this.groupBox1.Controls.Add(this.lblEmployee);
            this.groupBox1.Controls.Add(this.lblShipAddress);
            this.groupBox1.Controls.Add(this.lblFreight);
            this.groupBox1.Controls.Add(this.lblRequiredDate);
            this.groupBox1.Controls.Add(this.lblCustomer);
            this.groupBox1.Controls.Add(this.lblShipVia);
            this.groupBox1.Controls.Add(this.lblOrderDate);
            this.groupBox1.Controls.Add(this.lblOrderID);
            this.groupBox1.Controls.Add(this.dtpShippedDate);
            this.groupBox1.Controls.Add(this.dtpRequiredDate);
            this.groupBox1.Controls.Add(this.dtpOrderDate);
            this.groupBox1.Controls.Add(this.cbbShipVia);
            this.groupBox1.Controls.Add(this.cbbEmployee);
            this.groupBox1.Controls.Add(this.cbbCustomer);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.lblOrders);
            this.groupBox1.Controls.Add(this.txtShipCountry);
            this.groupBox1.Controls.Add(this.txtShipRegion);
            this.groupBox1.Controls.Add(this.txtShipPostalCode);
            this.groupBox1.Controls.Add(this.txtShipCity);
            this.groupBox1.Controls.Add(this.txtShipName);
            this.groupBox1.Controls.Add(this.txtShipAddress);
            this.groupBox1.Controls.Add(this.txtFreight);
            this.groupBox1.Controls.Add(this.txtOrderID);
            this.groupBox1.Location = new System.Drawing.Point(1469, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 807);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // lblShipCountry
            // 
            this.lblShipCountry.AutoSize = true;
            this.lblShipCountry.ForeColor = System.Drawing.Color.White;
            this.lblShipCountry.Location = new System.Drawing.Point(30, 550);
            this.lblShipCountry.Name = "lblShipCountry";
            this.lblShipCountry.Size = new System.Drawing.Size(113, 23);
            this.lblShipCountry.TabIndex = 1;
            this.lblShipCountry.Text = "Ship Country:";
            // 
            // lblShipPostalCode
            // 
            this.lblShipPostalCode.AutoSize = true;
            this.lblShipPostalCode.ForeColor = System.Drawing.Color.White;
            this.lblShipPostalCode.Location = new System.Drawing.Point(1, 513);
            this.lblShipPostalCode.Name = "lblShipPostalCode";
            this.lblShipPostalCode.Size = new System.Drawing.Size(142, 23);
            this.lblShipPostalCode.TabIndex = 1;
            this.lblShipPostalCode.Text = "Ship Postal Code:";
            // 
            // lblShipCity
            // 
            this.lblShipCity.AutoSize = true;
            this.lblShipCity.ForeColor = System.Drawing.Color.White;
            this.lblShipCity.Location = new System.Drawing.Point(62, 441);
            this.lblShipCity.Name = "lblShipCity";
            this.lblShipCity.Size = new System.Drawing.Size(81, 23);
            this.lblShipCity.TabIndex = 1;
            this.lblShipCity.Text = "Ship City:";
            // 
            // lblShipName
            // 
            this.lblShipName.AutoSize = true;
            this.lblShipName.ForeColor = System.Drawing.Color.White;
            this.lblShipName.Location = new System.Drawing.Point(45, 371);
            this.lblShipName.Name = "lblShipName";
            this.lblShipName.Size = new System.Drawing.Size(98, 23);
            this.lblShipName.TabIndex = 1;
            this.lblShipName.Text = "Ship Name:";
            // 
            // lblShipDate
            // 
            this.lblShipDate.AutoSize = true;
            this.lblShipDate.ForeColor = System.Drawing.Color.White;
            this.lblShipDate.Location = new System.Drawing.Point(26, 263);
            this.lblShipDate.Name = "lblShipDate";
            this.lblShipDate.Size = new System.Drawing.Size(117, 23);
            this.lblShipDate.TabIndex = 1;
            this.lblShipDate.Text = "Shipped Date:";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.ForeColor = System.Drawing.Color.White;
            this.lblEmployee.Location = new System.Drawing.Point(55, 155);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(88, 23);
            this.lblEmployee.TabIndex = 1;
            this.lblEmployee.Text = "Employee:";
            // 
            // lblShipAddress
            // 
            this.lblShipAddress.AutoSize = true;
            this.lblShipAddress.ForeColor = System.Drawing.Color.White;
            this.lblShipAddress.Location = new System.Drawing.Point(31, 407);
            this.lblShipAddress.Name = "lblShipAddress";
            this.lblShipAddress.Size = new System.Drawing.Size(112, 23);
            this.lblShipAddress.TabIndex = 1;
            this.lblShipAddress.Text = "Ship Address:";
            // 
            // lblFreight
            // 
            this.lblFreight.AutoSize = true;
            this.lblFreight.ForeColor = System.Drawing.Color.White;
            this.lblFreight.Location = new System.Drawing.Point(76, 335);
            this.lblFreight.Name = "lblFreight";
            this.lblFreight.Size = new System.Drawing.Size(67, 23);
            this.lblFreight.TabIndex = 1;
            this.lblFreight.Text = "Freight:";
            // 
            // lblRequiredDate
            // 
            this.lblRequiredDate.AutoSize = true;
            this.lblRequiredDate.ForeColor = System.Drawing.Color.White;
            this.lblRequiredDate.Location = new System.Drawing.Point(20, 227);
            this.lblRequiredDate.Name = "lblRequiredDate";
            this.lblRequiredDate.Size = new System.Drawing.Size(123, 23);
            this.lblRequiredDate.TabIndex = 1;
            this.lblRequiredDate.Text = "Required Date:";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.ForeColor = System.Drawing.Color.White;
            this.lblCustomer.Location = new System.Drawing.Point(55, 119);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(88, 23);
            this.lblCustomer.TabIndex = 1;
            this.lblCustomer.Text = "Customer:";
            // 
            // lblShipVia
            // 
            this.lblShipVia.AutoSize = true;
            this.lblShipVia.ForeColor = System.Drawing.Color.White;
            this.lblShipVia.Location = new System.Drawing.Point(67, 299);
            this.lblShipVia.Name = "lblShipVia";
            this.lblShipVia.Size = new System.Drawing.Size(76, 23);
            this.lblShipVia.TabIndex = 1;
            this.lblShipVia.Text = "Ship Via:";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.ForeColor = System.Drawing.Color.White;
            this.lblOrderDate.Location = new System.Drawing.Point(44, 191);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(99, 23);
            this.lblOrderDate.TabIndex = 1;
            this.lblOrderDate.Text = "Order Date:";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.ForeColor = System.Drawing.Color.White;
            this.lblOrderID.Location = new System.Drawing.Point(63, 83);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(80, 23);
            this.lblOrderID.TabIndex = 1;
            this.lblOrderID.Text = "Order ID:";
            // 
            // dtpShippedDate
            // 
            this.dtpShippedDate.CustomFormat = "dd   MMMM   yyyy";
            this.dtpShippedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpShippedDate.Location = new System.Drawing.Point(144, 257);
            this.dtpShippedDate.Name = "dtpShippedDate";
            this.dtpShippedDate.Size = new System.Drawing.Size(205, 30);
            this.dtpShippedDate.TabIndex = 6;
            this.dtpShippedDate.Value = new System.DateTime(2022, 12, 29, 0, 0, 0, 0);
            // 
            // dtpRequiredDate
            // 
            this.dtpRequiredDate.CustomFormat = "dd   MMMM   yyyy";
            this.dtpRequiredDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRequiredDate.Location = new System.Drawing.Point(144, 222);
            this.dtpRequiredDate.Name = "dtpRequiredDate";
            this.dtpRequiredDate.Size = new System.Drawing.Size(205, 30);
            this.dtpRequiredDate.TabIndex = 5;
            this.dtpRequiredDate.Value = new System.DateTime(2022, 12, 29, 0, 0, 0, 0);
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.CustomFormat = "dd   MMMM   yyyy";
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOrderDate.Location = new System.Drawing.Point(145, 190);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(203, 30);
            this.dtpOrderDate.TabIndex = 4;
            this.dtpOrderDate.Value = new System.DateTime(2022, 12, 30, 0, 0, 0, 0);
            this.dtpOrderDate.ValueChanged += new System.EventHandler(this.dtpOrderDate_ValueChanged);
            // 
            // cbbShipVia
            // 
            this.cbbShipVia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.cbbShipVia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbShipVia.ForeColor = System.Drawing.Color.White;
            this.cbbShipVia.FormattingEnabled = true;
            this.cbbShipVia.Location = new System.Drawing.Point(144, 296);
            this.cbbShipVia.Name = "cbbShipVia";
            this.cbbShipVia.Size = new System.Drawing.Size(204, 31);
            this.cbbShipVia.TabIndex = 7;
            // 
            // cbbEmployee
            // 
            this.cbbEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.cbbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEmployee.ForeColor = System.Drawing.Color.White;
            this.cbbEmployee.FormattingEnabled = true;
            this.cbbEmployee.Location = new System.Drawing.Point(144, 153);
            this.cbbEmployee.Name = "cbbEmployee";
            this.cbbEmployee.Size = new System.Drawing.Size(204, 31);
            this.cbbEmployee.TabIndex = 3;
            // 
            // cbbCustomer
            // 
            this.cbbCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.cbbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCustomer.ForeColor = System.Drawing.Color.White;
            this.cbbCustomer.FormattingEnabled = true;
            this.cbbCustomer.Location = new System.Drawing.Point(145, 118);
            this.cbbCustomer.Name = "cbbCustomer";
            this.cbbCustomer.Size = new System.Drawing.Size(204, 31);
            this.cbbCustomer.TabIndex = 15;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(137, 721);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(203, 39);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(137, 676);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(203, 39);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(137, 631);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(203, 39);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOrders.ForeColor = System.Drawing.Color.White;
            this.lblOrders.Location = new System.Drawing.Point(150, 24);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(127, 35);
            this.lblOrders.TabIndex = 1;
            this.lblOrders.Text = "ORDERS";
            // 
            // txtShipCountry
            // 
            this.txtShipCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtShipCountry.ForeColor = System.Drawing.Color.White;
            this.txtShipCountry.Location = new System.Drawing.Point(144, 549);
            this.txtShipCountry.Name = "txtShipCountry";
            this.txtShipCountry.Size = new System.Drawing.Size(205, 30);
            this.txtShipCountry.TabIndex = 14;
            this.txtShipCountry.TextChanged += new System.EventHandler(this.txtShipCountry_TextChanged);
            // 
            // txtShipPostalCode
            // 
            this.txtShipPostalCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtShipPostalCode.ForeColor = System.Drawing.Color.White;
            this.txtShipPostalCode.Location = new System.Drawing.Point(144, 513);
            this.txtShipPostalCode.Name = "txtShipPostalCode";
            this.txtShipPostalCode.Size = new System.Drawing.Size(205, 30);
            this.txtShipPostalCode.TabIndex = 13;
            this.txtShipPostalCode.TextChanged += new System.EventHandler(this.txtShipPostalCode_TextChanged);
            // 
            // txtShipCity
            // 
            this.txtShipCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtShipCity.ForeColor = System.Drawing.Color.White;
            this.txtShipCity.Location = new System.Drawing.Point(144, 441);
            this.txtShipCity.Name = "txtShipCity";
            this.txtShipCity.Size = new System.Drawing.Size(205, 30);
            this.txtShipCity.TabIndex = 11;
            this.txtShipCity.TextChanged += new System.EventHandler(this.txtShipCity_TextChanged);
            // 
            // txtShipName
            // 
            this.txtShipName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtShipName.ForeColor = System.Drawing.Color.White;
            this.txtShipName.Location = new System.Drawing.Point(144, 369);
            this.txtShipName.Name = "txtShipName";
            this.txtShipName.Size = new System.Drawing.Size(205, 30);
            this.txtShipName.TabIndex = 9;
            this.txtShipName.TextChanged += new System.EventHandler(this.txtShipName_TextChanged);
            // 
            // txtShipAddress
            // 
            this.txtShipAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtShipAddress.ForeColor = System.Drawing.Color.White;
            this.txtShipAddress.Location = new System.Drawing.Point(144, 405);
            this.txtShipAddress.Name = "txtShipAddress";
            this.txtShipAddress.Size = new System.Drawing.Size(205, 30);
            this.txtShipAddress.TabIndex = 10;
            this.txtShipAddress.TextChanged += new System.EventHandler(this.txtShipAddress_TextChanged);
            // 
            // txtFreight
            // 
            this.txtFreight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtFreight.ForeColor = System.Drawing.Color.White;
            this.txtFreight.Location = new System.Drawing.Point(144, 333);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.Size = new System.Drawing.Size(205, 30);
            this.txtFreight.TabIndex = 8;
            this.txtFreight.TextChanged += new System.EventHandler(this.txtFreight_TextChanged);
            // 
            // txtOrderID
            // 
            this.txtOrderID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtOrderID.Enabled = false;
            this.txtOrderID.ForeColor = System.Drawing.Color.White;
            this.txtOrderID.Location = new System.Drawing.Point(144, 81);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(205, 30);
            this.txtOrderID.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 209);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1460, 619);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // frmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(1870, 850);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOrders";
            this.Load += new System.EventHandler(this.frmOrders_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RadioButton rdbShipVia;
        private RadioButton rdbCountry;
        private Button btnSearch;
        private RadioButton rdbName;
        private RadioButton rdbCustomer;
        private RadioButton rdbCity;
        private RadioButton rdbEmployee;
        private RadioButton rdbOrderID;
        private TextBox txtShipRegion;
        private Button btnListallOrders;
        private GroupBox groupBox2;
        private Label lblShipRegion;
        private Button btnX;
        private GroupBox groupBox1;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private Label lblShipCountry;
        private Label lblShipPostalCode;
        private Label lblShipName;
        private Label lblShipDate;
        private Label lblEmployee;
        private Label lblShipAddress;
        private Label lblFreight;
        private Label lblRequiredDate;
        private Label lblCustomer;
        private Label lblOrders;
        private Label lblShipVia;
        private Label lblOrderDate;
        private Label lblOrderID;
        private TextBox txtShipCountry;
        private TextBox txtShipPostalCode;
        private TextBox txtShipName;
        private TextBox txtShipAddress;
        private TextBox txtFreight;
        private TextBox txtOrderID;
        private DataGridView dataGridView1;
        private ComboBox cbbCustomer;
        private DateTimePicker dtpOrderDate;
        private ComboBox cbbEmployee;
        private DateTimePicker dtpShippedDate;
        private DateTimePicker dtpRequiredDate;
        private ComboBox cbbShipVia;
        private Label lblShippedDateSearch;
        private Label lblEmployeeSearch;
        private Label lblRequiredDateSearch;
        private ComboBox cbbEmployeeSearch;
        private Label lblShipViaSearch;
        private Label lblOrderDateSearch;
        private Label lblCustomerSearch;
        private TextBox txtOrderIDSearch;
        private DateTimePicker dtpShippedDateSearch;
        private ComboBox cbbCustomerSearch;
        private DateTimePicker dtpRequiredDateSearch;
        private Label lblOrderIDSearch;
        private DateTimePicker dtpOrderdateSearch;
        private ComboBox cbbShipViaSearch;
        private Label lblShipCountrySearch;
        private Label lblShipCitySearch;
        private Label lblShipNameSearch;
        private RadioButton rdbRequiredDate;
        private Label lblFreightSearch;
        private RadioButton rdbShippedDate;
        private RadioButton rdbOrderDate;
        private TextBox txtShipCountrySearch;
        private TextBox txtFreightSearch;
        private TextBox txtShipNameSearch;
        private TextBox txtShipCitySearch;
        private Label lblShipCity;
        private TextBox txtShipCity;
        private RadioButton rdbFreight;
    }
}