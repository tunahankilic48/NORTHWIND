namespace NORTHWND.Forms
{
    partial class frmSuppliers
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
            this.btnX = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblFax = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblContactName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblSuppliers = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.lblContactTitle = new System.Windows.Forms.Label();
            this.lblSupplierID = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.txtContactTitle = new System.Windows.Forms.TextBox();
            this.txtSupplierID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblHomePage = new System.Windows.Forms.Label();
            this.txtHomePage = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbContactTitle = new System.Windows.Forms.RadioButton();
            this.btnListallSuppliers = new System.Windows.Forms.Button();
            this.rdbCountry = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rdbPhone = new System.Windows.Forms.RadioButton();
            this.rdbCompanyName = new System.Windows.Forms.RadioButton();
            this.rdbCity = new System.Windows.Forms.RadioButton();
            this.rdbContactName = new System.Windows.Forms.RadioButton();
            this.rdbSupplierID = new System.Windows.Forms.RadioButton();
            this.txtContactTitleSearch = new System.Windows.Forms.TextBox();
            this.txtSupplierIDSearch = new System.Windows.Forms.TextBox();
            this.txtCompanyNameSearch = new System.Windows.Forms.TextBox();
            this.txtContactNameSearch = new System.Windows.Forms.TextBox();
            this.lblSupplierIDSearch = new System.Windows.Forms.Label();
            this.lblCountrySearch = new System.Windows.Forms.Label();
            this.lblContactTitleSearch = new System.Windows.Forms.Label();
            this.lblCitySearch = new System.Windows.Forms.Label();
            this.lblPhoneSearch = new System.Windows.Forms.Label();
            this.lblCompanyNameSearch = new System.Windows.Forms.Label();
            this.lblContactNameSearch = new System.Windows.Forms.Label();
            this.txtCitySearch = new System.Windows.Forms.TextBox();
            this.txtCountrySearch = new System.Windows.Forms.TextBox();
            this.TxtPhoneSearch = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.Red;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.ForeColor = System.Drawing.Color.White;
            this.btnX.Location = new System.Drawing.Point(1688, -2);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(33, 33);
            this.btnX.TabIndex = 33;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(149, 621);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(194, 39);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(149, 576);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(194, 39);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(149, 531);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(194, 39);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblFax
            // 
            this.lblFax.AutoSize = true;
            this.lblFax.ForeColor = System.Drawing.Color.White;
            this.lblFax.Location = new System.Drawing.Point(107, 440);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(38, 23);
            this.lblFax.TabIndex = 1;
            this.lblFax.Text = "Fax:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.ForeColor = System.Drawing.Color.White;
            this.lblCountry.Location = new System.Drawing.Point(70, 368);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(75, 23);
            this.lblCountry.TabIndex = 1;
            this.lblCountry.Text = "Country:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.ForeColor = System.Drawing.Color.White;
            this.lblCity.Location = new System.Drawing.Point(102, 260);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(43, 23);
            this.lblCity.TabIndex = 1;
            this.lblCity.Text = "City:";
            // 
            // lblContactName
            // 
            this.lblContactName.AutoSize = true;
            this.lblContactName.ForeColor = System.Drawing.Color.White;
            this.lblContactName.Location = new System.Drawing.Point(20, 152);
            this.lblContactName.Name = "lblContactName";
            this.lblContactName.Size = new System.Drawing.Size(125, 23);
            this.lblContactName.TabIndex = 1;
            this.lblContactName.Text = "Contact Name:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.Location = new System.Drawing.Point(82, 404);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(63, 23);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "Phone:";
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.ForeColor = System.Drawing.Color.White;
            this.lblPostalCode.Location = new System.Drawing.Point(41, 332);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(104, 23);
            this.lblPostalCode.TabIndex = 1;
            this.lblPostalCode.Text = "Postal Code:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(75, 224);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(70, 23);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Address";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.ForeColor = System.Drawing.Color.White;
            this.lblCompanyName.Location = new System.Drawing.Point(7, 116);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(138, 23);
            this.lblCompanyName.TabIndex = 1;
            this.lblCompanyName.Text = "Company Name:";
            // 
            // lblSuppliers
            // 
            this.lblSuppliers.AutoSize = true;
            this.lblSuppliers.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSuppliers.ForeColor = System.Drawing.Color.White;
            this.lblSuppliers.Location = new System.Drawing.Point(104, 21);
            this.lblSuppliers.Name = "lblSuppliers";
            this.lblSuppliers.Size = new System.Drawing.Size(158, 35);
            this.lblSuppliers.TabIndex = 1;
            this.lblSuppliers.Text = "SUPPLIERS";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.ForeColor = System.Drawing.Color.White;
            this.lblRegion.Location = new System.Drawing.Point(78, 296);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(67, 23);
            this.lblRegion.TabIndex = 1;
            this.lblRegion.Text = "Region:";
            // 
            // lblContactTitle
            // 
            this.lblContactTitle.AutoSize = true;
            this.lblContactTitle.ForeColor = System.Drawing.Color.White;
            this.lblContactTitle.Location = new System.Drawing.Point(34, 188);
            this.lblContactTitle.Name = "lblContactTitle";
            this.lblContactTitle.Size = new System.Drawing.Size(111, 23);
            this.lblContactTitle.TabIndex = 1;
            this.lblContactTitle.Text = "Contact Title:";
            // 
            // lblSupplierID
            // 
            this.lblSupplierID.AutoSize = true;
            this.lblSupplierID.ForeColor = System.Drawing.Color.White;
            this.lblSupplierID.Location = new System.Drawing.Point(47, 80);
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.Size = new System.Drawing.Size(98, 23);
            this.lblSupplierID.TabIndex = 1;
            this.lblSupplierID.Text = "Supplier ID:";
            // 
            // txtFax
            // 
            this.txtFax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtFax.ForeColor = System.Drawing.Color.White;
            this.txtFax.Location = new System.Drawing.Point(149, 437);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(194, 30);
            this.txtFax.TabIndex = 11;
            this.txtFax.TextChanged += new System.EventHandler(this.txtFax_TextChanged);
            // 
            // txtCountry
            // 
            this.txtCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtCountry.ForeColor = System.Drawing.Color.White;
            this.txtCountry.Location = new System.Drawing.Point(149, 365);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(194, 30);
            this.txtCountry.TabIndex = 9;
            this.txtCountry.TextChanged += new System.EventHandler(this.txtCountry_TextChanged);
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtCity.ForeColor = System.Drawing.Color.White;
            this.txtCity.Location = new System.Drawing.Point(149, 257);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(194, 30);
            this.txtCity.TabIndex = 6;
            this.txtCity.TextChanged += new System.EventHandler(this.txtCity_TextChanged);
            // 
            // txtContactName
            // 
            this.txtContactName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtContactName.ForeColor = System.Drawing.Color.White;
            this.txtContactName.Location = new System.Drawing.Point(149, 149);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(194, 30);
            this.txtContactName.TabIndex = 3;
            this.txtContactName.TextChanged += new System.EventHandler(this.txtContactName_TextChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtPhone.ForeColor = System.Drawing.Color.White;
            this.txtPhone.Location = new System.Drawing.Point(149, 401);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(194, 30);
            this.txtPhone.TabIndex = 10;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtPostalCode.ForeColor = System.Drawing.Color.White;
            this.txtPostalCode.Location = new System.Drawing.Point(149, 329);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(194, 30);
            this.txtPostalCode.TabIndex = 8;
            this.txtPostalCode.TextChanged += new System.EventHandler(this.txtPostalCode_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtAddress.ForeColor = System.Drawing.Color.White;
            this.txtAddress.Location = new System.Drawing.Point(149, 221);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(194, 30);
            this.txtAddress.TabIndex = 5;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtCompanyName.ForeColor = System.Drawing.Color.White;
            this.txtCompanyName.Location = new System.Drawing.Point(149, 113);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(194, 30);
            this.txtCompanyName.TabIndex = 2;
            this.txtCompanyName.TextChanged += new System.EventHandler(this.txtCompanyName_TextChanged);
            // 
            // txtRegion
            // 
            this.txtRegion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtRegion.ForeColor = System.Drawing.Color.White;
            this.txtRegion.Location = new System.Drawing.Point(149, 293);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(194, 30);
            this.txtRegion.TabIndex = 7;
            this.txtRegion.TextChanged += new System.EventHandler(this.txtRegion_TextChanged);
            // 
            // txtContactTitle
            // 
            this.txtContactTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtContactTitle.ForeColor = System.Drawing.Color.White;
            this.txtContactTitle.Location = new System.Drawing.Point(149, 185);
            this.txtContactTitle.Name = "txtContactTitle";
            this.txtContactTitle.Size = new System.Drawing.Size(194, 30);
            this.txtContactTitle.TabIndex = 4;
            this.txtContactTitle.TextChanged += new System.EventHandler(this.txtContactTitle_TextChanged);
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtSupplierID.Enabled = false;
            this.txtSupplierID.ForeColor = System.Drawing.Color.White;
            this.txtSupplierID.Location = new System.Drawing.Point(149, 77);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.Size = new System.Drawing.Size(194, 30);
            this.txtSupplierID.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.lblHomePage);
            this.groupBox1.Controls.Add(this.lblFax);
            this.groupBox1.Controls.Add(this.lblCountry);
            this.groupBox1.Controls.Add(this.lblCity);
            this.groupBox1.Controls.Add(this.lblContactName);
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.lblPostalCode);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.lblCompanyName);
            this.groupBox1.Controls.Add(this.lblSuppliers);
            this.groupBox1.Controls.Add(this.lblRegion);
            this.groupBox1.Controls.Add(this.lblContactTitle);
            this.groupBox1.Controls.Add(this.lblSupplierID);
            this.groupBox1.Controls.Add(this.txtHomePage);
            this.groupBox1.Controls.Add(this.txtFax);
            this.groupBox1.Controls.Add(this.txtCountry);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.txtContactName);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtPostalCode);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtCompanyName);
            this.groupBox1.Controls.Add(this.txtRegion);
            this.groupBox1.Controls.Add(this.txtContactTitle);
            this.groupBox1.Controls.Add(this.txtSupplierID);
            this.groupBox1.Location = new System.Drawing.Point(1317, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 668);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // lblHomePage
            // 
            this.lblHomePage.AutoSize = true;
            this.lblHomePage.ForeColor = System.Drawing.Color.White;
            this.lblHomePage.Location = new System.Drawing.Point(43, 477);
            this.lblHomePage.Name = "lblHomePage";
            this.lblHomePage.Size = new System.Drawing.Size(102, 23);
            this.lblHomePage.TabIndex = 1;
            this.lblHomePage.Text = "Home Page:";
            // 
            // txtHomePage
            // 
            this.txtHomePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtHomePage.ForeColor = System.Drawing.Color.White;
            this.txtHomePage.Location = new System.Drawing.Point(149, 473);
            this.txtHomePage.Name = "txtHomePage";
            this.txtHomePage.Size = new System.Drawing.Size(194, 30);
            this.txtHomePage.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-232, 205);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1543, 480);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbContactTitle);
            this.groupBox2.Controls.Add(this.btnListallSuppliers);
            this.groupBox2.Controls.Add(this.rdbCountry);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.rdbPhone);
            this.groupBox2.Controls.Add(this.rdbCompanyName);
            this.groupBox2.Controls.Add(this.rdbCity);
            this.groupBox2.Controls.Add(this.rdbContactName);
            this.groupBox2.Controls.Add(this.rdbSupplierID);
            this.groupBox2.Controls.Add(this.txtContactTitleSearch);
            this.groupBox2.Controls.Add(this.txtSupplierIDSearch);
            this.groupBox2.Controls.Add(this.txtCompanyNameSearch);
            this.groupBox2.Controls.Add(this.txtContactNameSearch);
            this.groupBox2.Controls.Add(this.lblSupplierIDSearch);
            this.groupBox2.Controls.Add(this.lblCountrySearch);
            this.groupBox2.Controls.Add(this.lblContactTitleSearch);
            this.groupBox2.Controls.Add(this.lblCitySearch);
            this.groupBox2.Controls.Add(this.lblPhoneSearch);
            this.groupBox2.Controls.Add(this.lblCompanyNameSearch);
            this.groupBox2.Controls.Add(this.lblContactNameSearch);
            this.groupBox2.Controls.Add(this.txtCitySearch);
            this.groupBox2.Controls.Add(this.txtCountrySearch);
            this.groupBox2.Controls.Add(this.TxtPhoneSearch);
            this.groupBox2.Location = new System.Drawing.Point(12, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1299, 182);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // rdbContactTitle
            // 
            this.rdbContactTitle.AutoSize = true;
            this.rdbContactTitle.ForeColor = System.Drawing.Color.White;
            this.rdbContactTitle.Location = new System.Drawing.Point(661, 122);
            this.rdbContactTitle.Name = "rdbContactTitle";
            this.rdbContactTitle.Size = new System.Drawing.Size(141, 27);
            this.rdbContactTitle.TabIndex = 26;
            this.rdbContactTitle.TabStop = true;
            this.rdbContactTitle.Text = "Company Title";
            this.rdbContactTitle.UseVisualStyleBackColor = true;
            // 
            // btnListallSuppliers
            // 
            this.btnListallSuppliers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnListallSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListallSuppliers.Location = new System.Drawing.Point(1043, 115);
            this.btnListallSuppliers.Name = "btnListallSuppliers";
            this.btnListallSuppliers.Size = new System.Drawing.Size(236, 49);
            this.btnListallSuppliers.TabIndex = 31;
            this.btnListallSuppliers.Text = "List all Suppliers";
            this.btnListallSuppliers.UseVisualStyleBackColor = false;
            this.btnListallSuppliers.Click += new System.EventHandler(this.btnListallSuppliers_Click);
            // 
            // rdbCountry
            // 
            this.rdbCountry.AutoSize = true;
            this.rdbCountry.ForeColor = System.Drawing.Color.White;
            this.rdbCountry.Location = new System.Drawing.Point(822, 72);
            this.rdbCountry.Name = "rdbCountry";
            this.rdbCountry.Size = new System.Drawing.Size(92, 27);
            this.rdbCountry.TabIndex = 28;
            this.rdbCountry.TabStop = true;
            this.rdbCountry.Text = "Country";
            this.rdbCountry.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(1043, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(236, 49);
            this.btnSearch.TabIndex = 30;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rdbPhone
            // 
            this.rdbPhone.AutoSize = true;
            this.rdbPhone.ForeColor = System.Drawing.Color.White;
            this.rdbPhone.Location = new System.Drawing.Point(822, 108);
            this.rdbPhone.Name = "rdbPhone";
            this.rdbPhone.Size = new System.Drawing.Size(80, 27);
            this.rdbPhone.TabIndex = 29;
            this.rdbPhone.TabStop = true;
            this.rdbPhone.Text = "Phone";
            this.rdbPhone.UseVisualStyleBackColor = true;
            // 
            // rdbCompanyName
            // 
            this.rdbCompanyName.AutoSize = true;
            this.rdbCompanyName.ForeColor = System.Drawing.Color.White;
            this.rdbCompanyName.Location = new System.Drawing.Point(661, 52);
            this.rdbCompanyName.Name = "rdbCompanyName";
            this.rdbCompanyName.Size = new System.Drawing.Size(155, 27);
            this.rdbCompanyName.TabIndex = 24;
            this.rdbCompanyName.TabStop = true;
            this.rdbCompanyName.Text = "Company Name";
            this.rdbCompanyName.UseVisualStyleBackColor = true;
            // 
            // rdbCity
            // 
            this.rdbCity.AutoSize = true;
            this.rdbCity.ForeColor = System.Drawing.Color.White;
            this.rdbCity.Location = new System.Drawing.Point(822, 36);
            this.rdbCity.Name = "rdbCity";
            this.rdbCity.Size = new System.Drawing.Size(60, 27);
            this.rdbCity.TabIndex = 27;
            this.rdbCity.TabStop = true;
            this.rdbCity.Text = "City";
            this.rdbCity.UseVisualStyleBackColor = true;
            // 
            // rdbContactName
            // 
            this.rdbContactName.AutoSize = true;
            this.rdbContactName.ForeColor = System.Drawing.Color.White;
            this.rdbContactName.Location = new System.Drawing.Point(661, 88);
            this.rdbContactName.Name = "rdbContactName";
            this.rdbContactName.Size = new System.Drawing.Size(142, 27);
            this.rdbContactName.TabIndex = 25;
            this.rdbContactName.TabStop = true;
            this.rdbContactName.Text = "Contact Name";
            this.rdbContactName.UseVisualStyleBackColor = true;
            // 
            // rdbSupplierID
            // 
            this.rdbSupplierID.AutoSize = true;
            this.rdbSupplierID.ForeColor = System.Drawing.Color.White;
            this.rdbSupplierID.Location = new System.Drawing.Point(661, 16);
            this.rdbSupplierID.Name = "rdbSupplierID";
            this.rdbSupplierID.Size = new System.Drawing.Size(48, 27);
            this.rdbSupplierID.TabIndex = 23;
            this.rdbSupplierID.TabStop = true;
            this.rdbSupplierID.Text = "ID";
            this.rdbSupplierID.UseVisualStyleBackColor = true;
            // 
            // txtContactTitleSearch
            // 
            this.txtContactTitleSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtContactTitleSearch.ForeColor = System.Drawing.Color.White;
            this.txtContactTitleSearch.Location = new System.Drawing.Point(143, 123);
            this.txtContactTitleSearch.Name = "txtContactTitleSearch";
            this.txtContactTitleSearch.Size = new System.Drawing.Size(194, 30);
            this.txtContactTitleSearch.TabIndex = 19;
            this.txtContactTitleSearch.TextChanged += new System.EventHandler(this.txtContactTitle_TextChanged);
            // 
            // txtSupplierIDSearch
            // 
            this.txtSupplierIDSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtSupplierIDSearch.ForeColor = System.Drawing.Color.White;
            this.txtSupplierIDSearch.Location = new System.Drawing.Point(143, 15);
            this.txtSupplierIDSearch.Name = "txtSupplierIDSearch";
            this.txtSupplierIDSearch.Size = new System.Drawing.Size(194, 30);
            this.txtSupplierIDSearch.TabIndex = 16;
            // 
            // txtCompanyNameSearch
            // 
            this.txtCompanyNameSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtCompanyNameSearch.ForeColor = System.Drawing.Color.White;
            this.txtCompanyNameSearch.Location = new System.Drawing.Point(143, 51);
            this.txtCompanyNameSearch.Name = "txtCompanyNameSearch";
            this.txtCompanyNameSearch.Size = new System.Drawing.Size(194, 30);
            this.txtCompanyNameSearch.TabIndex = 17;
            this.txtCompanyNameSearch.TextChanged += new System.EventHandler(this.txtCompanyName_TextChanged);
            // 
            // txtContactNameSearch
            // 
            this.txtContactNameSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtContactNameSearch.ForeColor = System.Drawing.Color.White;
            this.txtContactNameSearch.Location = new System.Drawing.Point(143, 87);
            this.txtContactNameSearch.Name = "txtContactNameSearch";
            this.txtContactNameSearch.Size = new System.Drawing.Size(194, 30);
            this.txtContactNameSearch.TabIndex = 18;
            this.txtContactNameSearch.TextChanged += new System.EventHandler(this.txtContactName_TextChanged);
            // 
            // lblSupplierIDSearch
            // 
            this.lblSupplierIDSearch.AutoSize = true;
            this.lblSupplierIDSearch.ForeColor = System.Drawing.Color.White;
            this.lblSupplierIDSearch.Location = new System.Drawing.Point(41, 18);
            this.lblSupplierIDSearch.Name = "lblSupplierIDSearch";
            this.lblSupplierIDSearch.Size = new System.Drawing.Size(98, 23);
            this.lblSupplierIDSearch.TabIndex = 1;
            this.lblSupplierIDSearch.Text = "Supplier ID:";
            // 
            // lblCountrySearch
            // 
            this.lblCountrySearch.AutoSize = true;
            this.lblCountrySearch.ForeColor = System.Drawing.Color.White;
            this.lblCountrySearch.Location = new System.Drawing.Point(362, 77);
            this.lblCountrySearch.Name = "lblCountrySearch";
            this.lblCountrySearch.Size = new System.Drawing.Size(75, 23);
            this.lblCountrySearch.TabIndex = 1;
            this.lblCountrySearch.Text = "Country:";
            // 
            // lblContactTitleSearch
            // 
            this.lblContactTitleSearch.AutoSize = true;
            this.lblContactTitleSearch.ForeColor = System.Drawing.Color.White;
            this.lblContactTitleSearch.Location = new System.Drawing.Point(28, 126);
            this.lblContactTitleSearch.Name = "lblContactTitleSearch";
            this.lblContactTitleSearch.Size = new System.Drawing.Size(111, 23);
            this.lblContactTitleSearch.TabIndex = 1;
            this.lblContactTitleSearch.Text = "Contact Title:";
            // 
            // lblCitySearch
            // 
            this.lblCitySearch.AutoSize = true;
            this.lblCitySearch.ForeColor = System.Drawing.Color.White;
            this.lblCitySearch.Location = new System.Drawing.Point(394, 38);
            this.lblCitySearch.Name = "lblCitySearch";
            this.lblCitySearch.Size = new System.Drawing.Size(43, 23);
            this.lblCitySearch.TabIndex = 1;
            this.lblCitySearch.Text = "City:";
            // 
            // lblPhoneSearch
            // 
            this.lblPhoneSearch.AutoSize = true;
            this.lblPhoneSearch.ForeColor = System.Drawing.Color.White;
            this.lblPhoneSearch.Location = new System.Drawing.Point(374, 113);
            this.lblPhoneSearch.Name = "lblPhoneSearch";
            this.lblPhoneSearch.Size = new System.Drawing.Size(63, 23);
            this.lblPhoneSearch.TabIndex = 1;
            this.lblPhoneSearch.Text = "Phone:";
            // 
            // lblCompanyNameSearch
            // 
            this.lblCompanyNameSearch.AutoSize = true;
            this.lblCompanyNameSearch.ForeColor = System.Drawing.Color.White;
            this.lblCompanyNameSearch.Location = new System.Drawing.Point(1, 54);
            this.lblCompanyNameSearch.Name = "lblCompanyNameSearch";
            this.lblCompanyNameSearch.Size = new System.Drawing.Size(138, 23);
            this.lblCompanyNameSearch.TabIndex = 1;
            this.lblCompanyNameSearch.Text = "Company Name:";
            // 
            // lblContactNameSearch
            // 
            this.lblContactNameSearch.AutoSize = true;
            this.lblContactNameSearch.ForeColor = System.Drawing.Color.White;
            this.lblContactNameSearch.Location = new System.Drawing.Point(14, 90);
            this.lblContactNameSearch.Name = "lblContactNameSearch";
            this.lblContactNameSearch.Size = new System.Drawing.Size(125, 23);
            this.lblContactNameSearch.TabIndex = 1;
            this.lblContactNameSearch.Text = "Contact Name:";
            // 
            // txtCitySearch
            // 
            this.txtCitySearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtCitySearch.ForeColor = System.Drawing.Color.White;
            this.txtCitySearch.Location = new System.Drawing.Point(441, 35);
            this.txtCitySearch.Name = "txtCitySearch";
            this.txtCitySearch.Size = new System.Drawing.Size(194, 30);
            this.txtCitySearch.TabIndex = 20;
            this.txtCitySearch.TextChanged += new System.EventHandler(this.txtCity_TextChanged);
            // 
            // txtCountrySearch
            // 
            this.txtCountrySearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtCountrySearch.ForeColor = System.Drawing.Color.White;
            this.txtCountrySearch.Location = new System.Drawing.Point(441, 74);
            this.txtCountrySearch.Name = "txtCountrySearch";
            this.txtCountrySearch.Size = new System.Drawing.Size(194, 30);
            this.txtCountrySearch.TabIndex = 21;
            this.txtCountrySearch.TextChanged += new System.EventHandler(this.txtCountry_TextChanged);
            // 
            // TxtPhoneSearch
            // 
            this.TxtPhoneSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.TxtPhoneSearch.ForeColor = System.Drawing.Color.White;
            this.TxtPhoneSearch.Location = new System.Drawing.Point(441, 110);
            this.TxtPhoneSearch.Name = "TxtPhoneSearch";
            this.TxtPhoneSearch.Size = new System.Drawing.Size(194, 30);
            this.TxtPhoneSearch.TabIndex = 22;
            this.TxtPhoneSearch.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // frmSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(1718, 700);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSuppliers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSuppliers";
            this.Load += new System.EventHandler(this.frmSuppliers_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnX;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private Label lblFax;
        private Label lblCountry;
        private Label lblCity;
        private Label lblContactName;
        private Label lblPhone;
        private Label lblPostalCode;
        private Label lblAddress;
        private Label lblCompanyName;
        private Label lblSuppliers;
        private Label lblRegion;
        private Label lblContactTitle;
        private Label lblSupplierID;
        private TextBox txtFax;
        private TextBox txtCountry;
        private TextBox txtCity;
        private TextBox txtContactName;
        private TextBox txtPhone;
        private TextBox txtPostalCode;
        private TextBox txtAddress;
        private TextBox txtCompanyName;
        private TextBox txtRegion;
        private TextBox txtContactTitle;
        private TextBox txtSupplierID;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Label lblHomePage;
        private TextBox txtHomePage;
        private GroupBox groupBox2;
        private RadioButton rdbContactTitle;
        private Button btnListallSuppliers;
        private RadioButton rdbCountry;
        private Button btnSearch;
        private RadioButton rdbPhone;
        private RadioButton rdbCompanyName;
        private RadioButton rdbCity;
        private RadioButton rdbContactName;
        private RadioButton rdbSupplierID;
        private TextBox txtContactTitleSearch;
        private TextBox txtSupplierIDSearch;
        private TextBox txtCompanyNameSearch;
        private TextBox txtContactNameSearch;
        private Label lblSupplierIDSearch;
        private Label lblCountrySearch;
        private Label lblContactTitleSearch;
        private Label lblCitySearch;
        private Label lblPhoneSearch;
        private Label lblCompanyNameSearch;
        private Label lblContactNameSearch;
        private TextBox txtCitySearch;
        private TextBox txtCountrySearch;
        private TextBox TxtPhoneSearch;
    }
}