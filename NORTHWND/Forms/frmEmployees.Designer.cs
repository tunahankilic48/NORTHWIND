namespace NORTHWND.Forms
{
    partial class frmEmployees
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
            this.lblExtension = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblHomePhone = new System.Windows.Forms.Label();
            this.lblTitleofCourtesy = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblEmployees = new System.Windows.Forms.Label();
            this.lblHireDate = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtHomePhone = new System.Windows.Forms.TextBox();
            this.txtTitleofCourtesy = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbReportsTo = new System.Windows.Forms.ComboBox();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblReportsTo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbCountry = new System.Windows.Forms.RadioButton();
            this.rdbHireDate = new System.Windows.Forms.RadioButton();
            this.rdbNotes = new System.Windows.Forms.RadioButton();
            this.rdbLastname = new System.Windows.Forms.RadioButton();
            this.btnListallEmployees = new System.Windows.Forms.Button();
            this.rdbBirthDate = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rdbReportsto = new System.Windows.Forms.RadioButton();
            this.rdbFirstName = new System.Windows.Forms.RadioButton();
            this.rdbTitle = new System.Windows.Forms.RadioButton();
            this.rdbEmployeeID = new System.Windows.Forms.RadioButton();
            this.cbbReportstoSearch = new System.Windows.Forms.ComboBox();
            this.lblEmmployeeIDSearch = new System.Windows.Forms.Label();
            this.dtpHireDateSearch = new System.Windows.Forms.DateTimePicker();
            this.dtpBirthDateSearch = new System.Windows.Forms.DateTimePicker();
            this.txtEmployeeIDSearch = new System.Windows.Forms.TextBox();
            this.txtTitleSearch = new System.Windows.Forms.TextBox();
            this.txtFirstNameSearch = new System.Windows.Forms.TextBox();
            this.txtLastNameSearch = new System.Windows.Forms.TextBox();
            this.lblNotesSearch = new System.Windows.Forms.Label();
            this.lblCountrySearch = new System.Windows.Forms.Label();
            this.lblTitleSearch = new System.Windows.Forms.Label();
            this.lblFirstNameSearch = new System.Windows.Forms.Label();
            this.lblLastNameSearch = new System.Windows.Forms.Label();
            this.lblHireDateSearch = new System.Windows.Forms.Label();
            this.lblBirthDateSearch = new System.Windows.Forms.Label();
            this.lblReportstoSearch = new System.Windows.Forms.Label();
            this.tctNotesSearch = new System.Windows.Forms.TextBox();
            this.txtCountrySearch = new System.Windows.Forms.TextBox();
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
            this.btnX.Location = new System.Drawing.Point(1868, -1);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(33, 33);
            this.btnX.TabIndex = 37;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(149, 747);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(210, 39);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(149, 702);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(210, 39);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(149, 657);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(210, 39);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblExtension
            // 
            this.lblExtension.AutoSize = true;
            this.lblExtension.ForeColor = System.Drawing.Color.White;
            this.lblExtension.Location = new System.Drawing.Point(56, 548);
            this.lblExtension.Name = "lblExtension";
            this.lblExtension.Size = new System.Drawing.Size(87, 23);
            this.lblExtension.TabIndex = 1;
            this.lblExtension.Text = "Extension:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.ForeColor = System.Drawing.Color.White;
            this.lblCountry.Location = new System.Drawing.Point(68, 478);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(75, 23);
            this.lblCountry.TabIndex = 1;
            this.lblCountry.Text = "Country:";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.ForeColor = System.Drawing.Color.White;
            this.lblBirthDate.Location = new System.Drawing.Point(52, 262);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(91, 23);
            this.lblBirthDate.TabIndex = 1;
            this.lblBirthDate.Text = "Birth Date:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.ForeColor = System.Drawing.Color.White;
            this.lblLastName.Location = new System.Drawing.Point(48, 154);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(95, 23);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblHomePhone
            // 
            this.lblHomePhone.AutoSize = true;
            this.lblHomePhone.ForeColor = System.Drawing.Color.White;
            this.lblHomePhone.Location = new System.Drawing.Point(29, 512);
            this.lblHomePhone.Name = "lblHomePhone";
            this.lblHomePhone.Size = new System.Drawing.Size(114, 23);
            this.lblHomePhone.TabIndex = 1;
            this.lblHomePhone.Text = "Home Phone:";
            // 
            // lblTitleofCourtesy
            // 
            this.lblTitleofCourtesy.AutoSize = true;
            this.lblTitleofCourtesy.ForeColor = System.Drawing.Color.White;
            this.lblTitleofCourtesy.Location = new System.Drawing.Point(5, 226);
            this.lblTitleofCourtesy.Name = "lblTitleofCourtesy";
            this.lblTitleofCourtesy.Size = new System.Drawing.Size(138, 23);
            this.lblTitleofCourtesy.TabIndex = 1;
            this.lblTitleofCourtesy.Text = "Title of Courtesy:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.ForeColor = System.Drawing.Color.White;
            this.lblFirstName.Location = new System.Drawing.Point(47, 118);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(96, 23);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblEmployees
            // 
            this.lblEmployees.AutoSize = true;
            this.lblEmployees.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmployees.ForeColor = System.Drawing.Color.White;
            this.lblEmployees.Location = new System.Drawing.Point(104, 24);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(180, 35);
            this.lblEmployees.TabIndex = 1;
            this.lblEmployees.Text = "EMPLOYEES";
            // 
            // lblHireDate
            // 
            this.lblHireDate.AutoSize = true;
            this.lblHireDate.ForeColor = System.Drawing.Color.White;
            this.lblHireDate.Location = new System.Drawing.Point(57, 298);
            this.lblHireDate.Name = "lblHireDate";
            this.lblHireDate.Size = new System.Drawing.Size(86, 23);
            this.lblHireDate.TabIndex = 1;
            this.lblHireDate.Text = "Hire Date:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(97, 190);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(46, 23);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title:";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.ForeColor = System.Drawing.Color.White;
            this.lblEmployeeID.Location = new System.Drawing.Point(33, 82);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(110, 23);
            this.lblEmployeeID.TabIndex = 1;
            this.lblEmployeeID.Text = "Employee ID:";
            // 
            // txtExtension
            // 
            this.txtExtension.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtExtension.ForeColor = System.Drawing.Color.White;
            this.txtExtension.Location = new System.Drawing.Point(149, 546);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(210, 30);
            this.txtExtension.TabIndex = 13;
            this.txtExtension.TextChanged += new System.EventHandler(this.txtExtension_TextChanged);
            // 
            // txtCountry
            // 
            this.txtCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtCountry.ForeColor = System.Drawing.Color.White;
            this.txtCountry.Location = new System.Drawing.Point(149, 476);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(210, 30);
            this.txtCountry.TabIndex = 11;
            this.txtCountry.TextChanged += new System.EventHandler(this.txtCountry_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtLastName.ForeColor = System.Drawing.Color.White;
            this.txtLastName.Location = new System.Drawing.Point(149, 152);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(210, 30);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // txtHomePhone
            // 
            this.txtHomePhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtHomePhone.ForeColor = System.Drawing.Color.White;
            this.txtHomePhone.Location = new System.Drawing.Point(149, 510);
            this.txtHomePhone.Name = "txtHomePhone";
            this.txtHomePhone.Size = new System.Drawing.Size(210, 30);
            this.txtHomePhone.TabIndex = 12;
            this.txtHomePhone.TextChanged += new System.EventHandler(this.txtHomePhone_TextChanged);
            // 
            // txtTitleofCourtesy
            // 
            this.txtTitleofCourtesy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtTitleofCourtesy.ForeColor = System.Drawing.Color.White;
            this.txtTitleofCourtesy.Location = new System.Drawing.Point(149, 224);
            this.txtTitleofCourtesy.Name = "txtTitleofCourtesy";
            this.txtTitleofCourtesy.Size = new System.Drawing.Size(210, 30);
            this.txtTitleofCourtesy.TabIndex = 4;
            this.txtTitleofCourtesy.TextChanged += new System.EventHandler(this.txtTitleofCourtesy_TextChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtFirstName.ForeColor = System.Drawing.Color.White;
            this.txtFirstName.Location = new System.Drawing.Point(149, 116);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(210, 30);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtTitle.ForeColor = System.Drawing.Color.White;
            this.txtTitle.Location = new System.Drawing.Point(149, 188);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(210, 30);
            this.txtTitle.TabIndex = 3;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtEmployeeID.Enabled = false;
            this.txtEmployeeID.ForeColor = System.Drawing.Color.White;
            this.txtEmployeeID.Location = new System.Drawing.Point(149, 80);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(210, 30);
            this.txtEmployeeID.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbReportsTo);
            this.groupBox1.Controls.Add(this.dtpHireDate);
            this.groupBox1.Controls.Add(this.dtpBirthDate);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.lblExtension);
            this.groupBox1.Controls.Add(this.lblNotes);
            this.groupBox1.Controls.Add(this.lblCountry);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblBirthDate);
            this.groupBox1.Controls.Add(this.lblLastName);
            this.groupBox1.Controls.Add(this.lblReportsTo);
            this.groupBox1.Controls.Add(this.lblHomePhone);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblTitleofCourtesy);
            this.groupBox1.Controls.Add(this.lblFirstName);
            this.groupBox1.Controls.Add(this.lblEmployees);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblHireDate);
            this.groupBox1.Controls.Add(this.lblTitle);
            this.groupBox1.Controls.Add(this.lblEmployeeID);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtExtension);
            this.groupBox1.Controls.Add(this.txtNotes);
            this.groupBox1.Controls.Add(this.txtCountry);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.txtPostalCode);
            this.groupBox1.Controls.Add(this.txtHomePhone);
            this.groupBox1.Controls.Add(this.txtTitleofCourtesy);
            this.groupBox1.Controls.Add(this.txtRegion);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.txtEmployeeID);
            this.groupBox1.Location = new System.Drawing.Point(1497, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 795);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // cbbReportsTo
            // 
            this.cbbReportsTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.cbbReportsTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbReportsTo.ForeColor = System.Drawing.Color.White;
            this.cbbReportsTo.FormattingEnabled = true;
            this.cbbReportsTo.Location = new System.Drawing.Point(149, 620);
            this.cbbReportsTo.Name = "cbbReportsTo";
            this.cbbReportsTo.Size = new System.Drawing.Size(210, 31);
            this.cbbReportsTo.TabIndex = 15;
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.Location = new System.Drawing.Point(149, 299);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(210, 30);
            this.dtpHireDate.TabIndex = 6;
            this.dtpHireDate.ValueChanged += new System.EventHandler(this.dtpHireDate_ValueChanged);
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(149, 263);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(210, 30);
            this.dtpBirthDate.TabIndex = 5;
            this.dtpBirthDate.Value = new System.DateTime(2022, 12, 27, 0, 0, 0, 0);
            this.dtpBirthDate.ValueChanged += new System.EventHandler(this.dtpBirthDate_ValueChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(69, 334);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(74, 23);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Address:";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.ForeColor = System.Drawing.Color.White;
            this.lblNotes.Location = new System.Drawing.Point(84, 586);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(59, 23);
            this.lblNotes.TabIndex = 1;
            this.lblNotes.Text = "Notes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(100, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "City:";
            // 
            // lblReportsTo
            // 
            this.lblReportsTo.AutoSize = true;
            this.lblReportsTo.ForeColor = System.Drawing.Color.White;
            this.lblReportsTo.Location = new System.Drawing.Point(50, 624);
            this.lblReportsTo.Name = "lblReportsTo";
            this.lblReportsTo.Size = new System.Drawing.Size(93, 23);
            this.lblReportsTo.TabIndex = 1;
            this.lblReportsTo.Text = "Reports to:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 442);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Postal Code:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(76, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Region:";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtAddress.ForeColor = System.Drawing.Color.White;
            this.txtAddress.Location = new System.Drawing.Point(149, 332);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(210, 30);
            this.txtAddress.TabIndex = 7;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // txtNotes
            // 
            this.txtNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtNotes.ForeColor = System.Drawing.Color.White;
            this.txtNotes.Location = new System.Drawing.Point(149, 584);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(210, 30);
            this.txtNotes.TabIndex = 14;
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtCity.ForeColor = System.Drawing.Color.White;
            this.txtCity.Location = new System.Drawing.Point(149, 368);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(210, 30);
            this.txtCity.TabIndex = 8;
            this.txtCity.TextChanged += new System.EventHandler(this.txtCity_TextChanged);
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtPostalCode.ForeColor = System.Drawing.Color.White;
            this.txtPostalCode.Location = new System.Drawing.Point(149, 440);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(210, 30);
            this.txtPostalCode.TabIndex = 10;
            this.txtPostalCode.TextChanged += new System.EventHandler(this.txtPostalCode_TextChanged);
            // 
            // txtRegion
            // 
            this.txtRegion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtRegion.ForeColor = System.Drawing.Color.White;
            this.txtRegion.Location = new System.Drawing.Point(149, 404);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(210, 30);
            this.txtRegion.TabIndex = 9;
            this.txtRegion.TextChanged += new System.EventHandler(this.txtRegion_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 173);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1485, 643);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbCountry);
            this.groupBox2.Controls.Add(this.rdbHireDate);
            this.groupBox2.Controls.Add(this.rdbNotes);
            this.groupBox2.Controls.Add(this.rdbLastname);
            this.groupBox2.Controls.Add(this.btnListallEmployees);
            this.groupBox2.Controls.Add(this.rdbBirthDate);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.rdbReportsto);
            this.groupBox2.Controls.Add(this.rdbFirstName);
            this.groupBox2.Controls.Add(this.rdbTitle);
            this.groupBox2.Controls.Add(this.rdbEmployeeID);
            this.groupBox2.Controls.Add(this.cbbReportstoSearch);
            this.groupBox2.Controls.Add(this.lblEmmployeeIDSearch);
            this.groupBox2.Controls.Add(this.dtpHireDateSearch);
            this.groupBox2.Controls.Add(this.dtpBirthDateSearch);
            this.groupBox2.Controls.Add(this.txtEmployeeIDSearch);
            this.groupBox2.Controls.Add(this.txtTitleSearch);
            this.groupBox2.Controls.Add(this.txtFirstNameSearch);
            this.groupBox2.Controls.Add(this.txtLastNameSearch);
            this.groupBox2.Controls.Add(this.lblNotesSearch);
            this.groupBox2.Controls.Add(this.lblCountrySearch);
            this.groupBox2.Controls.Add(this.lblTitleSearch);
            this.groupBox2.Controls.Add(this.lblFirstNameSearch);
            this.groupBox2.Controls.Add(this.lblLastNameSearch);
            this.groupBox2.Controls.Add(this.lblHireDateSearch);
            this.groupBox2.Controls.Add(this.lblBirthDateSearch);
            this.groupBox2.Controls.Add(this.lblReportstoSearch);
            this.groupBox2.Controls.Add(this.tctNotesSearch);
            this.groupBox2.Controls.Add(this.txtCountrySearch);
            this.groupBox2.Location = new System.Drawing.Point(6, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1485, 146);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // rdbCountry
            // 
            this.rdbCountry.AutoSize = true;
            this.rdbCountry.ForeColor = System.Drawing.Color.White;
            this.rdbCountry.Location = new System.Drawing.Point(1154, 104);
            this.rdbCountry.Name = "rdbCountry";
            this.rdbCountry.Size = new System.Drawing.Size(92, 27);
            this.rdbCountry.TabIndex = 33;
            this.rdbCountry.TabStop = true;
            this.rdbCountry.Text = "Country";
            this.rdbCountry.UseVisualStyleBackColor = true;
            // 
            // rdbHireDate
            // 
            this.rdbHireDate.AutoSize = true;
            this.rdbHireDate.ForeColor = System.Drawing.Color.White;
            this.rdbHireDate.Location = new System.Drawing.Point(1045, 105);
            this.rdbHireDate.Name = "rdbHireDate";
            this.rdbHireDate.Size = new System.Drawing.Size(103, 27);
            this.rdbHireDate.TabIndex = 30;
            this.rdbHireDate.TabStop = true;
            this.rdbHireDate.Text = "Hire Date";
            this.rdbHireDate.UseVisualStyleBackColor = true;
            // 
            // rdbNotes
            // 
            this.rdbNotes.AutoSize = true;
            this.rdbNotes.ForeColor = System.Drawing.Color.White;
            this.rdbNotes.Location = new System.Drawing.Point(1154, 66);
            this.rdbNotes.Name = "rdbNotes";
            this.rdbNotes.Size = new System.Drawing.Size(76, 27);
            this.rdbNotes.TabIndex = 32;
            this.rdbNotes.TabStop = true;
            this.rdbNotes.Text = "Notes";
            this.rdbNotes.UseVisualStyleBackColor = true;
            // 
            // rdbLastname
            // 
            this.rdbLastname.AutoSize = true;
            this.rdbLastname.ForeColor = System.Drawing.Color.White;
            this.rdbLastname.Location = new System.Drawing.Point(912, 104);
            this.rdbLastname.Name = "rdbLastname";
            this.rdbLastname.Size = new System.Drawing.Size(112, 27);
            this.rdbLastname.TabIndex = 27;
            this.rdbLastname.TabStop = true;
            this.rdbLastname.Text = "Last Name";
            this.rdbLastname.UseVisualStyleBackColor = true;
            // 
            // btnListallEmployees
            // 
            this.btnListallEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnListallEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListallEmployees.Location = new System.Drawing.Point(1269, 90);
            this.btnListallEmployees.Name = "btnListallEmployees";
            this.btnListallEmployees.Size = new System.Drawing.Size(210, 44);
            this.btnListallEmployees.TabIndex = 35;
            this.btnListallEmployees.Text = "List all Employees";
            this.btnListallEmployees.UseVisualStyleBackColor = false;
            this.btnListallEmployees.Click += new System.EventHandler(this.btnListallEmployees_Click);
            // 
            // rdbBirthDate
            // 
            this.rdbBirthDate.AutoSize = true;
            this.rdbBirthDate.ForeColor = System.Drawing.Color.White;
            this.rdbBirthDate.Location = new System.Drawing.Point(1045, 67);
            this.rdbBirthDate.Name = "rdbBirthDate";
            this.rdbBirthDate.Size = new System.Drawing.Size(108, 27);
            this.rdbBirthDate.TabIndex = 29;
            this.rdbBirthDate.TabStop = true;
            this.rdbBirthDate.Text = "Birth Date";
            this.rdbBirthDate.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(1269, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(210, 44);
            this.btnSearch.TabIndex = 34;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rdbReportsto
            // 
            this.rdbReportsto.AutoSize = true;
            this.rdbReportsto.ForeColor = System.Drawing.Color.White;
            this.rdbReportsto.Location = new System.Drawing.Point(1154, 25);
            this.rdbReportsto.Name = "rdbReportsto";
            this.rdbReportsto.Size = new System.Drawing.Size(110, 27);
            this.rdbReportsto.TabIndex = 31;
            this.rdbReportsto.TabStop = true;
            this.rdbReportsto.Text = "Reports to";
            this.rdbReportsto.UseVisualStyleBackColor = true;
            // 
            // rdbFirstName
            // 
            this.rdbFirstName.AutoSize = true;
            this.rdbFirstName.ForeColor = System.Drawing.Color.White;
            this.rdbFirstName.Location = new System.Drawing.Point(912, 66);
            this.rdbFirstName.Name = "rdbFirstName";
            this.rdbFirstName.Size = new System.Drawing.Size(113, 27);
            this.rdbFirstName.TabIndex = 26;
            this.rdbFirstName.TabStop = true;
            this.rdbFirstName.Text = "First Name";
            this.rdbFirstName.UseVisualStyleBackColor = true;
            // 
            // rdbTitle
            // 
            this.rdbTitle.AutoSize = true;
            this.rdbTitle.ForeColor = System.Drawing.Color.White;
            this.rdbTitle.Location = new System.Drawing.Point(1045, 26);
            this.rdbTitle.Name = "rdbTitle";
            this.rdbTitle.Size = new System.Drawing.Size(63, 27);
            this.rdbTitle.TabIndex = 28;
            this.rdbTitle.TabStop = true;
            this.rdbTitle.Text = "Title";
            this.rdbTitle.UseVisualStyleBackColor = true;
            // 
            // rdbEmployeeID
            // 
            this.rdbEmployeeID.AutoSize = true;
            this.rdbEmployeeID.ForeColor = System.Drawing.Color.White;
            this.rdbEmployeeID.Location = new System.Drawing.Point(912, 25);
            this.rdbEmployeeID.Name = "rdbEmployeeID";
            this.rdbEmployeeID.Size = new System.Drawing.Size(127, 27);
            this.rdbEmployeeID.TabIndex = 25;
            this.rdbEmployeeID.TabStop = true;
            this.rdbEmployeeID.Text = "Employee ID";
            this.rdbEmployeeID.UseVisualStyleBackColor = true;
            // 
            // cbbReportstoSearch
            // 
            this.cbbReportstoSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.cbbReportstoSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbReportstoSearch.ForeColor = System.Drawing.Color.White;
            this.cbbReportstoSearch.FormattingEnabled = true;
            this.cbbReportstoSearch.Location = new System.Drawing.Point(709, 22);
            this.cbbReportstoSearch.Name = "cbbReportstoSearch";
            this.cbbReportstoSearch.Size = new System.Drawing.Size(188, 31);
            this.cbbReportstoSearch.TabIndex = 22;
            // 
            // lblEmmployeeIDSearch
            // 
            this.lblEmmployeeIDSearch.AutoSize = true;
            this.lblEmmployeeIDSearch.ForeColor = System.Drawing.Color.White;
            this.lblEmmployeeIDSearch.Location = new System.Drawing.Point(2, 26);
            this.lblEmmployeeIDSearch.Name = "lblEmmployeeIDSearch";
            this.lblEmmployeeIDSearch.Size = new System.Drawing.Size(110, 23);
            this.lblEmmployeeIDSearch.TabIndex = 1;
            this.lblEmmployeeIDSearch.Text = "Employee ID:";
            // 
            // dtpHireDateSearch
            // 
            this.dtpHireDateSearch.Location = new System.Drawing.Point(397, 99);
            this.dtpHireDateSearch.Name = "dtpHireDateSearch";
            this.dtpHireDateSearch.Size = new System.Drawing.Size(210, 30);
            this.dtpHireDateSearch.TabIndex = 21;
            this.dtpHireDateSearch.ValueChanged += new System.EventHandler(this.dtpHireDate_ValueChanged);
            // 
            // dtpBirthDateSearch
            // 
            this.dtpBirthDateSearch.Location = new System.Drawing.Point(397, 63);
            this.dtpBirthDateSearch.Name = "dtpBirthDateSearch";
            this.dtpBirthDateSearch.Size = new System.Drawing.Size(210, 30);
            this.dtpBirthDateSearch.TabIndex = 20;
            this.dtpBirthDateSearch.Value = new System.DateTime(2022, 12, 27, 0, 0, 0, 0);
            this.dtpBirthDateSearch.ValueChanged += new System.EventHandler(this.dtpBirthDate_ValueChanged);
            // 
            // txtEmployeeIDSearch
            // 
            this.txtEmployeeIDSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtEmployeeIDSearch.ForeColor = System.Drawing.Color.White;
            this.txtEmployeeIDSearch.Location = new System.Drawing.Point(118, 24);
            this.txtEmployeeIDSearch.Name = "txtEmployeeIDSearch";
            this.txtEmployeeIDSearch.Size = new System.Drawing.Size(181, 30);
            this.txtEmployeeIDSearch.TabIndex = 1;
            // 
            // txtTitleSearch
            // 
            this.txtTitleSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtTitleSearch.ForeColor = System.Drawing.Color.White;
            this.txtTitleSearch.Location = new System.Drawing.Point(397, 25);
            this.txtTitleSearch.Name = "txtTitleSearch";
            this.txtTitleSearch.Size = new System.Drawing.Size(210, 30);
            this.txtTitleSearch.TabIndex = 19;
            this.txtTitleSearch.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // txtFirstNameSearch
            // 
            this.txtFirstNameSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtFirstNameSearch.ForeColor = System.Drawing.Color.White;
            this.txtFirstNameSearch.Location = new System.Drawing.Point(118, 60);
            this.txtFirstNameSearch.Name = "txtFirstNameSearch";
            this.txtFirstNameSearch.Size = new System.Drawing.Size(181, 30);
            this.txtFirstNameSearch.TabIndex = 2;
            this.txtFirstNameSearch.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // txtLastNameSearch
            // 
            this.txtLastNameSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtLastNameSearch.ForeColor = System.Drawing.Color.White;
            this.txtLastNameSearch.Location = new System.Drawing.Point(118, 96);
            this.txtLastNameSearch.Name = "txtLastNameSearch";
            this.txtLastNameSearch.Size = new System.Drawing.Size(181, 30);
            this.txtLastNameSearch.TabIndex = 3;
            this.txtLastNameSearch.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // lblNotesSearch
            // 
            this.lblNotesSearch.AutoSize = true;
            this.lblNotesSearch.ForeColor = System.Drawing.Color.White;
            this.lblNotesSearch.Location = new System.Drawing.Point(644, 65);
            this.lblNotesSearch.Name = "lblNotesSearch";
            this.lblNotesSearch.Size = new System.Drawing.Size(59, 23);
            this.lblNotesSearch.TabIndex = 1;
            this.lblNotesSearch.Text = "Notes:";
            // 
            // lblCountrySearch
            // 
            this.lblCountrySearch.AutoSize = true;
            this.lblCountrySearch.ForeColor = System.Drawing.Color.White;
            this.lblCountrySearch.Location = new System.Drawing.Point(628, 101);
            this.lblCountrySearch.Name = "lblCountrySearch";
            this.lblCountrySearch.Size = new System.Drawing.Size(75, 23);
            this.lblCountrySearch.TabIndex = 1;
            this.lblCountrySearch.Text = "Country:";
            // 
            // lblTitleSearch
            // 
            this.lblTitleSearch.AutoSize = true;
            this.lblTitleSearch.ForeColor = System.Drawing.Color.White;
            this.lblTitleSearch.Location = new System.Drawing.Point(345, 27);
            this.lblTitleSearch.Name = "lblTitleSearch";
            this.lblTitleSearch.Size = new System.Drawing.Size(46, 23);
            this.lblTitleSearch.TabIndex = 1;
            this.lblTitleSearch.Text = "Title:";
            // 
            // lblFirstNameSearch
            // 
            this.lblFirstNameSearch.AutoSize = true;
            this.lblFirstNameSearch.ForeColor = System.Drawing.Color.White;
            this.lblFirstNameSearch.Location = new System.Drawing.Point(16, 62);
            this.lblFirstNameSearch.Name = "lblFirstNameSearch";
            this.lblFirstNameSearch.Size = new System.Drawing.Size(96, 23);
            this.lblFirstNameSearch.TabIndex = 1;
            this.lblFirstNameSearch.Text = "First Name:";
            // 
            // lblLastNameSearch
            // 
            this.lblLastNameSearch.AutoSize = true;
            this.lblLastNameSearch.ForeColor = System.Drawing.Color.White;
            this.lblLastNameSearch.Location = new System.Drawing.Point(17, 98);
            this.lblLastNameSearch.Name = "lblLastNameSearch";
            this.lblLastNameSearch.Size = new System.Drawing.Size(95, 23);
            this.lblLastNameSearch.TabIndex = 1;
            this.lblLastNameSearch.Text = "Last Name:";
            // 
            // lblHireDateSearch
            // 
            this.lblHireDateSearch.AutoSize = true;
            this.lblHireDateSearch.ForeColor = System.Drawing.Color.White;
            this.lblHireDateSearch.Location = new System.Drawing.Point(305, 98);
            this.lblHireDateSearch.Name = "lblHireDateSearch";
            this.lblHireDateSearch.Size = new System.Drawing.Size(86, 23);
            this.lblHireDateSearch.TabIndex = 1;
            this.lblHireDateSearch.Text = "Hire Date:";
            // 
            // lblBirthDateSearch
            // 
            this.lblBirthDateSearch.AutoSize = true;
            this.lblBirthDateSearch.ForeColor = System.Drawing.Color.White;
            this.lblBirthDateSearch.Location = new System.Drawing.Point(300, 62);
            this.lblBirthDateSearch.Name = "lblBirthDateSearch";
            this.lblBirthDateSearch.Size = new System.Drawing.Size(91, 23);
            this.lblBirthDateSearch.TabIndex = 1;
            this.lblBirthDateSearch.Text = "Birth Date:";
            // 
            // lblReportstoSearch
            // 
            this.lblReportstoSearch.AutoSize = true;
            this.lblReportstoSearch.ForeColor = System.Drawing.Color.White;
            this.lblReportstoSearch.Location = new System.Drawing.Point(610, 26);
            this.lblReportstoSearch.Name = "lblReportstoSearch";
            this.lblReportstoSearch.Size = new System.Drawing.Size(93, 23);
            this.lblReportstoSearch.TabIndex = 1;
            this.lblReportstoSearch.Text = "Reports to:";
            // 
            // tctNotesSearch
            // 
            this.tctNotesSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.tctNotesSearch.ForeColor = System.Drawing.Color.White;
            this.tctNotesSearch.Location = new System.Drawing.Point(709, 63);
            this.tctNotesSearch.Name = "tctNotesSearch";
            this.tctNotesSearch.Size = new System.Drawing.Size(188, 30);
            this.tctNotesSearch.TabIndex = 23;
            // 
            // txtCountrySearch
            // 
            this.txtCountrySearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtCountrySearch.ForeColor = System.Drawing.Color.White;
            this.txtCountrySearch.Location = new System.Drawing.Point(709, 99);
            this.txtCountrySearch.Name = "txtCountrySearch";
            this.txtCountrySearch.Size = new System.Drawing.Size(188, 30);
            this.txtCountrySearch.TabIndex = 24;
            this.txtCountrySearch.TextChanged += new System.EventHandler(this.txtCountry_TextChanged);
            // 
            // frmEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(1900, 830);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEmployees";
            this.Load += new System.EventHandler(this.frmEmployees_Load);
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
        private Label lblExtension;
        private Label lblCountry;
        private Label lblBirthDate;
        private Label lblLastName;
        private Label lblHomePhone;
        private Label lblTitleofCourtesy;
        private Label lblFirstName;
        private Label lblEmployees;
        private Label lblHireDate;
        private Label lblTitle;
        private Label lblEmployeeID;
        private TextBox txtExtension;
        private TextBox txtCountry;
        private TextBox txtLastName;
        private TextBox txtHomePhone;
        private TextBox txtTitleofCourtesy;
        private TextBox txtFirstName;
        private TextBox txtTitle;
        private TextBox txtEmployeeID;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Label lblAddress;
        private Label lblNotes;
        private Label label4;
        private Label lblReportsTo;
        private Label label2;
        private Label label1;
        private TextBox txtAddress;
        private TextBox txtNotes;
        private TextBox txtCity;
        private TextBox txtPostalCode;
        private TextBox txtRegion;
        private DateTimePicker dtpHireDate;
        private DateTimePicker dtpBirthDate;
        private ComboBox cbbReportsTo;
        private GroupBox groupBox2;
        private ComboBox cbbReportstoSearch;
        private Label lblEmmployeeIDSearch;
        private DateTimePicker dtpHireDateSearch;
        private DateTimePicker dtpBirthDateSearch;
        private TextBox txtEmployeeIDSearch;
        private TextBox txtTitleSearch;
        private TextBox txtFirstNameSearch;
        private TextBox txtLastNameSearch;
        private Label lblNotesSearch;
        private Label lblCountrySearch;
        private Label lblTitleSearch;
        private Label lblFirstNameSearch;
        private Label lblLastNameSearch;
        private Label lblHireDateSearch;
        private Label lblBirthDateSearch;
        private Label lblReportstoSearch;
        private TextBox tctNotesSearch;
        private TextBox txtCountrySearch;
        private RadioButton rdbCountry;
        private RadioButton rdbHireDate;
        private RadioButton rdbNotes;
        private RadioButton rdbLastname;
        private Button btnListallEmployees;
        private RadioButton rdbBirthDate;
        private Button btnSearch;
        private RadioButton rdbReportsto;
        private RadioButton rdbFirstName;
        private RadioButton rdbTitle;
        private RadioButton rdbEmployeeID;
    }
}