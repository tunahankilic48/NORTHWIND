namespace NORTHWND.Forms
{
    partial class frmProducts
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
            this.cbbSupplier = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblUnitsonOrder = new System.Windows.Forms.Label();
            this.lbReorderLevel = new System.Windows.Forms.Label();
            this.lblQuantityperUnit = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblUnitsinStock = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProducts = new System.Windows.Forms.Label();
            this.lblDiscontinued = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.txtlblUnitsonOrder = new System.Windows.Forms.TextBox();
            this.txtReorderLevel = new System.Windows.Forms.TextBox();
            this.txtQuantityperUnit = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtUnitsinStock = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.btnX = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbNo = new System.Windows.Forms.RadioButton();
            this.rdbYes = new System.Windows.Forms.RadioButton();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbProductID = new System.Windows.Forms.RadioButton();
            this.btnListProducts = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rdbDiscontinued = new System.Windows.Forms.RadioButton();
            this.rdbReorderLevel = new System.Windows.Forms.RadioButton();
            this.rdbCategory = new System.Windows.Forms.RadioButton();
            this.rdbSupplier = new System.Windows.Forms.RadioButton();
            this.rdbUnitPrice = new System.Windows.Forms.RadioButton();
            this.rdbUnitsinStock = new System.Windows.Forms.RadioButton();
            this.rdbProductName = new System.Windows.Forms.RadioButton();
            this.rdbNoSearch = new System.Windows.Forms.RadioButton();
            this.txtProductNameSearch = new System.Windows.Forms.TextBox();
            this.rdbYesSearch = new System.Windows.Forms.RadioButton();
            this.txtProductIDSearch = new System.Windows.Forms.TextBox();
            this.cbbCategorySearch = new System.Windows.Forms.ComboBox();
            this.lblProductIDSearch = new System.Windows.Forms.Label();
            this.cbbSupplierSearch = new System.Windows.Forms.ComboBox();
            this.lblProductNameSearch = new System.Windows.Forms.Label();
            this.lblSupplierSearch = new System.Windows.Forms.Label();
            this.lblCategorySearch = new System.Windows.Forms.Label();
            this.lblReorderLevelSearch = new System.Windows.Forms.Label();
            this.txtUnitPriceSearch = new System.Windows.Forms.TextBox();
            this.lblUnitPriceSearch = new System.Windows.Forms.Label();
            this.lblUnitsinStockSearch = new System.Windows.Forms.Label();
            this.lblDiscountinuedSearch = new System.Windows.Forms.Label();
            this.txtUnitsinStockSearch = new System.Windows.Forms.TextBox();
            this.txtReorderLevelSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbSupplier
            // 
            this.cbbSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.cbbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSupplier.ForeColor = System.Drawing.Color.White;
            this.cbbSupplier.FormattingEnabled = true;
            this.cbbSupplier.Location = new System.Drawing.Point(149, 152);
            this.cbbSupplier.Name = "cbbSupplier";
            this.cbbSupplier.Size = new System.Drawing.Size(210, 31);
            this.cbbSupplier.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(149, 597);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(210, 39);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(149, 541);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(210, 39);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(149, 483);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(210, 39);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblUnitsonOrder
            // 
            this.lblUnitsonOrder.AutoSize = true;
            this.lblUnitsonOrder.ForeColor = System.Drawing.Color.White;
            this.lblUnitsonOrder.Location = new System.Drawing.Point(21, 334);
            this.lblUnitsonOrder.Name = "lblUnitsonOrder";
            this.lblUnitsonOrder.Size = new System.Drawing.Size(127, 23);
            this.lblUnitsonOrder.TabIndex = 1;
            this.lblUnitsonOrder.Text = "Units on Order:";
            // 
            // lbReorderLevel
            // 
            this.lbReorderLevel.AutoSize = true;
            this.lbReorderLevel.ForeColor = System.Drawing.Color.White;
            this.lbReorderLevel.Location = new System.Drawing.Point(31, 370);
            this.lbReorderLevel.Name = "lbReorderLevel";
            this.lbReorderLevel.Size = new System.Drawing.Size(117, 23);
            this.lbReorderLevel.TabIndex = 1;
            this.lbReorderLevel.Text = "Reorder Level:";
            // 
            // lblQuantityperUnit
            // 
            this.lblQuantityperUnit.AutoSize = true;
            this.lblQuantityperUnit.ForeColor = System.Drawing.Color.White;
            this.lblQuantityperUnit.Location = new System.Drawing.Point(1, 226);
            this.lblQuantityperUnit.Name = "lblQuantityperUnit";
            this.lblQuantityperUnit.Size = new System.Drawing.Size(147, 23);
            this.lblQuantityperUnit.TabIndex = 1;
            this.lblQuantityperUnit.Text = "Quantity per Unit:";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.ForeColor = System.Drawing.Color.White;
            this.lblSupplier.Location = new System.Drawing.Point(72, 156);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(76, 23);
            this.lblSupplier.TabIndex = 1;
            this.lblSupplier.Text = "Supplier:";
            // 
            // lblUnitsinStock
            // 
            this.lblUnitsinStock.AutoSize = true;
            this.lblUnitsinStock.ForeColor = System.Drawing.Color.White;
            this.lblUnitsinStock.Location = new System.Drawing.Point(31, 298);
            this.lblUnitsinStock.Name = "lblUnitsinStock";
            this.lblUnitsinStock.Size = new System.Drawing.Size(117, 23);
            this.lblUnitsinStock.TabIndex = 1;
            this.lblUnitsinStock.Text = "Units in Stock:";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.ForeColor = System.Drawing.Color.White;
            this.lblProductName.Location = new System.Drawing.Point(23, 118);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(125, 23);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Product Name:";
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProducts.ForeColor = System.Drawing.Color.White;
            this.lblProducts.Location = new System.Drawing.Point(110, 23);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(166, 35);
            this.lblProducts.TabIndex = 1;
            this.lblProducts.Text = "PRODUCTS";
            // 
            // lblDiscontinued
            // 
            this.lblDiscontinued.AutoSize = true;
            this.lblDiscontinued.ForeColor = System.Drawing.Color.White;
            this.lblDiscontinued.Location = new System.Drawing.Point(28, 425);
            this.lblDiscontinued.Name = "lblDiscontinued";
            this.lblDiscontinued.Size = new System.Drawing.Size(120, 23);
            this.lblDiscontinued.TabIndex = 1;
            this.lblDiscontinued.Text = "Discountinued";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.ForeColor = System.Drawing.Color.White;
            this.lblUnitPrice.Location = new System.Drawing.Point(60, 262);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(88, 23);
            this.lblUnitPrice.TabIndex = 1;
            this.lblUnitPrice.Text = "Unit Price:";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.ForeColor = System.Drawing.Color.White;
            this.lblProductID.Location = new System.Drawing.Point(52, 82);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(96, 23);
            this.lblProductID.TabIndex = 1;
            this.lblProductID.Text = "Product ID:";
            // 
            // txtlblUnitsonOrder
            // 
            this.txtlblUnitsonOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtlblUnitsonOrder.ForeColor = System.Drawing.Color.White;
            this.txtlblUnitsonOrder.Location = new System.Drawing.Point(149, 332);
            this.txtlblUnitsonOrder.Name = "txtlblUnitsonOrder";
            this.txtlblUnitsonOrder.Size = new System.Drawing.Size(210, 30);
            this.txtlblUnitsonOrder.TabIndex = 8;
            this.txtlblUnitsonOrder.TextChanged += new System.EventHandler(this.txtlblUnitsonOrder_TextChanged);
            // 
            // txtReorderLevel
            // 
            this.txtReorderLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtReorderLevel.ForeColor = System.Drawing.Color.White;
            this.txtReorderLevel.Location = new System.Drawing.Point(149, 368);
            this.txtReorderLevel.Name = "txtReorderLevel";
            this.txtReorderLevel.Size = new System.Drawing.Size(210, 30);
            this.txtReorderLevel.TabIndex = 9;
            this.txtReorderLevel.TextChanged += new System.EventHandler(this.txtReorderLevel_TextChanged);
            // 
            // txtQuantityperUnit
            // 
            this.txtQuantityperUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtQuantityperUnit.ForeColor = System.Drawing.Color.White;
            this.txtQuantityperUnit.Location = new System.Drawing.Point(149, 224);
            this.txtQuantityperUnit.Name = "txtQuantityperUnit";
            this.txtQuantityperUnit.Size = new System.Drawing.Size(210, 30);
            this.txtQuantityperUnit.TabIndex = 5;
            this.txtQuantityperUnit.TextChanged += new System.EventHandler(this.txtQuantityperUnit_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 207);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1387, 502);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtUnitsinStock
            // 
            this.txtUnitsinStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtUnitsinStock.ForeColor = System.Drawing.Color.White;
            this.txtUnitsinStock.Location = new System.Drawing.Point(149, 296);
            this.txtUnitsinStock.Name = "txtUnitsinStock";
            this.txtUnitsinStock.Size = new System.Drawing.Size(210, 30);
            this.txtUnitsinStock.TabIndex = 7;
            this.txtUnitsinStock.TextChanged += new System.EventHandler(this.txtUnitsinStock_TextChanged);
            // 
            // txtProductName
            // 
            this.txtProductName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtProductName.ForeColor = System.Drawing.Color.White;
            this.txtProductName.Location = new System.Drawing.Point(149, 116);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(210, 30);
            this.txtProductName.TabIndex = 2;
            this.txtProductName.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtUnitPrice.ForeColor = System.Drawing.Color.White;
            this.txtUnitPrice.Location = new System.Drawing.Point(149, 260);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(210, 30);
            this.txtUnitPrice.TabIndex = 6;
            this.txtUnitPrice.TextChanged += new System.EventHandler(this.txtUnitPrice_TextChanged);
            // 
            // txtProductID
            // 
            this.txtProductID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtProductID.Enabled = false;
            this.txtProductID.ForeColor = System.Drawing.Color.White;
            this.txtProductID.Location = new System.Drawing.Point(149, 80);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(210, 30);
            this.txtProductID.TabIndex = 1;
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.Red;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.ForeColor = System.Drawing.Color.White;
            this.btnX.Location = new System.Drawing.Point(1766, 0);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(33, 33);
            this.btnX.TabIndex = 35;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbNo);
            this.groupBox1.Controls.Add(this.rdbYes);
            this.groupBox1.Controls.Add(this.cbbCategory);
            this.groupBox1.Controls.Add(this.cbbSupplier);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.lblUnitsonOrder);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.lbReorderLevel);
            this.groupBox1.Controls.Add(this.lblCategory);
            this.groupBox1.Controls.Add(this.lblQuantityperUnit);
            this.groupBox1.Controls.Add(this.lblSupplier);
            this.groupBox1.Controls.Add(this.lblUnitsinStock);
            this.groupBox1.Controls.Add(this.lblProductName);
            this.groupBox1.Controls.Add(this.lblProducts);
            this.groupBox1.Controls.Add(this.lblDiscontinued);
            this.groupBox1.Controls.Add(this.lblUnitPrice);
            this.groupBox1.Controls.Add(this.lblProductID);
            this.groupBox1.Controls.Add(this.txtlblUnitsonOrder);
            this.groupBox1.Controls.Add(this.txtReorderLevel);
            this.groupBox1.Controls.Add(this.txtQuantityperUnit);
            this.groupBox1.Controls.Add(this.txtUnitsinStock);
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.Controls.Add(this.txtUnitPrice);
            this.groupBox1.Controls.Add(this.txtProductID);
            this.groupBox1.Location = new System.Drawing.Point(1395, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 687);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // rdbNo
            // 
            this.rdbNo.AutoSize = true;
            this.rdbNo.ForeColor = System.Drawing.Color.White;
            this.rdbNo.Location = new System.Drawing.Point(155, 439);
            this.rdbNo.Name = "rdbNo";
            this.rdbNo.Size = new System.Drawing.Size(54, 27);
            this.rdbNo.TabIndex = 11;
            this.rdbNo.TabStop = true;
            this.rdbNo.Text = "No";
            this.rdbNo.UseVisualStyleBackColor = true;
            // 
            // rdbYes
            // 
            this.rdbYes.AutoSize = true;
            this.rdbYes.ForeColor = System.Drawing.Color.White;
            this.rdbYes.Location = new System.Drawing.Point(155, 406);
            this.rdbYes.Name = "rdbYes";
            this.rdbYes.Size = new System.Drawing.Size(55, 27);
            this.rdbYes.TabIndex = 10;
            this.rdbYes.TabStop = true;
            this.rdbYes.Text = "Yes";
            this.rdbYes.UseVisualStyleBackColor = true;
            // 
            // cbbCategory
            // 
            this.cbbCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.cbbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCategory.ForeColor = System.Drawing.Color.White;
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Location = new System.Drawing.Point(149, 187);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(210, 31);
            this.cbbCategory.TabIndex = 4;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.ForeColor = System.Drawing.Color.White;
            this.lblCategory.Location = new System.Drawing.Point(65, 191);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(83, 23);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Category:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.rdbNoSearch);
            this.groupBox2.Controls.Add(this.txtProductNameSearch);
            this.groupBox2.Controls.Add(this.rdbYesSearch);
            this.groupBox2.Controls.Add(this.txtProductIDSearch);
            this.groupBox2.Controls.Add(this.cbbCategorySearch);
            this.groupBox2.Controls.Add(this.lblProductIDSearch);
            this.groupBox2.Controls.Add(this.cbbSupplierSearch);
            this.groupBox2.Controls.Add(this.lblProductNameSearch);
            this.groupBox2.Controls.Add(this.lblSupplierSearch);
            this.groupBox2.Controls.Add(this.lblCategorySearch);
            this.groupBox2.Controls.Add(this.lblReorderLevelSearch);
            this.groupBox2.Controls.Add(this.txtUnitPriceSearch);
            this.groupBox2.Controls.Add(this.lblUnitPriceSearch);
            this.groupBox2.Controls.Add(this.lblUnitsinStockSearch);
            this.groupBox2.Controls.Add(this.lblDiscountinuedSearch);
            this.groupBox2.Controls.Add(this.txtUnitsinStockSearch);
            this.groupBox2.Controls.Add(this.txtReorderLevelSearch);
            this.groupBox2.Location = new System.Drawing.Point(2, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1387, 183);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbProductID);
            this.groupBox3.Controls.Add(this.btnListProducts);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.rdbDiscontinued);
            this.groupBox3.Controls.Add(this.rdbReorderLevel);
            this.groupBox3.Controls.Add(this.rdbCategory);
            this.groupBox3.Controls.Add(this.rdbSupplier);
            this.groupBox3.Controls.Add(this.rdbUnitPrice);
            this.groupBox3.Controls.Add(this.rdbUnitsinStock);
            this.groupBox3.Controls.Add(this.rdbProductName);
            this.groupBox3.Location = new System.Drawing.Point(708, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(679, 183);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            // 
            // rdbProductID
            // 
            this.rdbProductID.AutoSize = true;
            this.rdbProductID.ForeColor = System.Drawing.Color.White;
            this.rdbProductID.Location = new System.Drawing.Point(33, 29);
            this.rdbProductID.Name = "rdbProductID";
            this.rdbProductID.Size = new System.Drawing.Size(113, 27);
            this.rdbProductID.TabIndex = 24;
            this.rdbProductID.TabStop = true;
            this.rdbProductID.Text = "Product ID";
            this.rdbProductID.UseVisualStyleBackColor = true;
            // 
            // btnListProducts
            // 
            this.btnListProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnListProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListProducts.Location = new System.Drawing.Point(439, 101);
            this.btnListProducts.Name = "btnListProducts";
            this.btnListProducts.Size = new System.Drawing.Size(210, 39);
            this.btnListProducts.TabIndex = 33;
            this.btnListProducts.Text = "List Products";
            this.btnListProducts.UseVisualStyleBackColor = false;
            this.btnListProducts.Click += new System.EventHandler(this.btnListProducts_Click_1);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(439, 43);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(210, 39);
            this.btnSearch.TabIndex = 32;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // rdbDiscontinued
            // 
            this.rdbDiscontinued.AutoSize = true;
            this.rdbDiscontinued.ForeColor = System.Drawing.Color.White;
            this.rdbDiscontinued.Location = new System.Drawing.Point(174, 143);
            this.rdbDiscontinued.Name = "rdbDiscontinued";
            this.rdbDiscontinued.Size = new System.Drawing.Size(141, 27);
            this.rdbDiscontinued.TabIndex = 31;
            this.rdbDiscontinued.TabStop = true;
            this.rdbDiscontinued.Text = "Discountinued";
            this.rdbDiscontinued.UseVisualStyleBackColor = true;
            // 
            // rdbReorderLevel
            // 
            this.rdbReorderLevel.AutoSize = true;
            this.rdbReorderLevel.ForeColor = System.Drawing.Color.White;
            this.rdbReorderLevel.Location = new System.Drawing.Point(174, 29);
            this.rdbReorderLevel.Name = "rdbReorderLevel";
            this.rdbReorderLevel.Size = new System.Drawing.Size(134, 27);
            this.rdbReorderLevel.TabIndex = 28;
            this.rdbReorderLevel.TabStop = true;
            this.rdbReorderLevel.Text = "Reorder Level";
            this.rdbReorderLevel.UseVisualStyleBackColor = true;
            // 
            // rdbCategory
            // 
            this.rdbCategory.AutoSize = true;
            this.rdbCategory.ForeColor = System.Drawing.Color.White;
            this.rdbCategory.Location = new System.Drawing.Point(33, 143);
            this.rdbCategory.Name = "rdbCategory";
            this.rdbCategory.Size = new System.Drawing.Size(100, 27);
            this.rdbCategory.TabIndex = 27;
            this.rdbCategory.TabStop = true;
            this.rdbCategory.Text = "Category";
            this.rdbCategory.UseVisualStyleBackColor = true;
            // 
            // rdbSupplier
            // 
            this.rdbSupplier.AutoSize = true;
            this.rdbSupplier.ForeColor = System.Drawing.Color.White;
            this.rdbSupplier.Location = new System.Drawing.Point(33, 104);
            this.rdbSupplier.Name = "rdbSupplier";
            this.rdbSupplier.Size = new System.Drawing.Size(93, 27);
            this.rdbSupplier.TabIndex = 26;
            this.rdbSupplier.TabStop = true;
            this.rdbSupplier.Text = "Supplier";
            this.rdbSupplier.UseVisualStyleBackColor = true;
            // 
            // rdbUnitPrice
            // 
            this.rdbUnitPrice.AutoSize = true;
            this.rdbUnitPrice.ForeColor = System.Drawing.Color.White;
            this.rdbUnitPrice.Location = new System.Drawing.Point(174, 68);
            this.rdbUnitPrice.Name = "rdbUnitPrice";
            this.rdbUnitPrice.Size = new System.Drawing.Size(105, 27);
            this.rdbUnitPrice.TabIndex = 29;
            this.rdbUnitPrice.TabStop = true;
            this.rdbUnitPrice.Text = "Unit Price";
            this.rdbUnitPrice.UseVisualStyleBackColor = true;
            // 
            // rdbUnitsinStock
            // 
            this.rdbUnitsinStock.AutoSize = true;
            this.rdbUnitsinStock.ForeColor = System.Drawing.Color.White;
            this.rdbUnitsinStock.Location = new System.Drawing.Point(174, 104);
            this.rdbUnitsinStock.Name = "rdbUnitsinStock";
            this.rdbUnitsinStock.Size = new System.Drawing.Size(134, 27);
            this.rdbUnitsinStock.TabIndex = 30;
            this.rdbUnitsinStock.TabStop = true;
            this.rdbUnitsinStock.Text = "Units in Stock";
            this.rdbUnitsinStock.UseVisualStyleBackColor = true;
            // 
            // rdbProductName
            // 
            this.rdbProductName.AutoSize = true;
            this.rdbProductName.ForeColor = System.Drawing.Color.White;
            this.rdbProductName.Location = new System.Drawing.Point(33, 68);
            this.rdbProductName.Name = "rdbProductName";
            this.rdbProductName.Size = new System.Drawing.Size(142, 27);
            this.rdbProductName.TabIndex = 25;
            this.rdbProductName.TabStop = true;
            this.rdbProductName.Text = "Product Name";
            this.rdbProductName.UseVisualStyleBackColor = true;
            // 
            // rdbNoSearch
            // 
            this.rdbNoSearch.AutoSize = true;
            this.rdbNoSearch.ForeColor = System.Drawing.Color.White;
            this.rdbNoSearch.Location = new System.Drawing.Point(647, 150);
            this.rdbNoSearch.Name = "rdbNoSearch";
            this.rdbNoSearch.Size = new System.Drawing.Size(54, 27);
            this.rdbNoSearch.TabIndex = 23;
            this.rdbNoSearch.TabStop = true;
            this.rdbNoSearch.Text = "No";
            this.rdbNoSearch.UseVisualStyleBackColor = true;
            // 
            // txtProductNameSearch
            // 
            this.txtProductNameSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtProductNameSearch.ForeColor = System.Drawing.Color.White;
            this.txtProductNameSearch.Location = new System.Drawing.Point(128, 52);
            this.txtProductNameSearch.Name = "txtProductNameSearch";
            this.txtProductNameSearch.Size = new System.Drawing.Size(210, 30);
            this.txtProductNameSearch.TabIndex = 16;
            this.txtProductNameSearch.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
            // 
            // rdbYesSearch
            // 
            this.rdbYesSearch.AutoSize = true;
            this.rdbYesSearch.ForeColor = System.Drawing.Color.White;
            this.rdbYesSearch.Location = new System.Drawing.Point(647, 117);
            this.rdbYesSearch.Name = "rdbYesSearch";
            this.rdbYesSearch.Size = new System.Drawing.Size(55, 27);
            this.rdbYesSearch.TabIndex = 22;
            this.rdbYesSearch.TabStop = true;
            this.rdbYesSearch.Text = "Yes";
            this.rdbYesSearch.UseVisualStyleBackColor = true;
            // 
            // txtProductIDSearch
            // 
            this.txtProductIDSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtProductIDSearch.ForeColor = System.Drawing.Color.White;
            this.txtProductIDSearch.Location = new System.Drawing.Point(128, 16);
            this.txtProductIDSearch.Name = "txtProductIDSearch";
            this.txtProductIDSearch.Size = new System.Drawing.Size(210, 30);
            this.txtProductIDSearch.TabIndex = 15;
            // 
            // cbbCategorySearch
            // 
            this.cbbCategorySearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.cbbCategorySearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCategorySearch.ForeColor = System.Drawing.Color.White;
            this.cbbCategorySearch.FormattingEnabled = true;
            this.cbbCategorySearch.Location = new System.Drawing.Point(128, 125);
            this.cbbCategorySearch.Name = "cbbCategorySearch";
            this.cbbCategorySearch.Size = new System.Drawing.Size(210, 31);
            this.cbbCategorySearch.TabIndex = 18;
            // 
            // lblProductIDSearch
            // 
            this.lblProductIDSearch.AutoSize = true;
            this.lblProductIDSearch.ForeColor = System.Drawing.Color.White;
            this.lblProductIDSearch.Location = new System.Drawing.Point(31, 18);
            this.lblProductIDSearch.Name = "lblProductIDSearch";
            this.lblProductIDSearch.Size = new System.Drawing.Size(96, 23);
            this.lblProductIDSearch.TabIndex = 1;
            this.lblProductIDSearch.Text = "Product ID:";
            // 
            // cbbSupplierSearch
            // 
            this.cbbSupplierSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.cbbSupplierSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSupplierSearch.ForeColor = System.Drawing.Color.White;
            this.cbbSupplierSearch.FormattingEnabled = true;
            this.cbbSupplierSearch.Location = new System.Drawing.Point(128, 88);
            this.cbbSupplierSearch.Name = "cbbSupplierSearch";
            this.cbbSupplierSearch.Size = new System.Drawing.Size(210, 31);
            this.cbbSupplierSearch.TabIndex = 17;
            // 
            // lblProductNameSearch
            // 
            this.lblProductNameSearch.AutoSize = true;
            this.lblProductNameSearch.ForeColor = System.Drawing.Color.White;
            this.lblProductNameSearch.Location = new System.Drawing.Point(2, 54);
            this.lblProductNameSearch.Name = "lblProductNameSearch";
            this.lblProductNameSearch.Size = new System.Drawing.Size(125, 23);
            this.lblProductNameSearch.TabIndex = 1;
            this.lblProductNameSearch.Text = "Product Name:";
            // 
            // lblSupplierSearch
            // 
            this.lblSupplierSearch.AutoSize = true;
            this.lblSupplierSearch.ForeColor = System.Drawing.Color.White;
            this.lblSupplierSearch.Location = new System.Drawing.Point(51, 92);
            this.lblSupplierSearch.Name = "lblSupplierSearch";
            this.lblSupplierSearch.Size = new System.Drawing.Size(76, 23);
            this.lblSupplierSearch.TabIndex = 1;
            this.lblSupplierSearch.Text = "Supplier:";
            // 
            // lblCategorySearch
            // 
            this.lblCategorySearch.AutoSize = true;
            this.lblCategorySearch.ForeColor = System.Drawing.Color.White;
            this.lblCategorySearch.Location = new System.Drawing.Point(44, 129);
            this.lblCategorySearch.Name = "lblCategorySearch";
            this.lblCategorySearch.Size = new System.Drawing.Size(83, 23);
            this.lblCategorySearch.TabIndex = 1;
            this.lblCategorySearch.Text = "Category:";
            // 
            // lblReorderLevelSearch
            // 
            this.lblReorderLevelSearch.AutoSize = true;
            this.lblReorderLevelSearch.ForeColor = System.Drawing.Color.White;
            this.lblReorderLevelSearch.Location = new System.Drawing.Point(373, 18);
            this.lblReorderLevelSearch.Name = "lblReorderLevelSearch";
            this.lblReorderLevelSearch.Size = new System.Drawing.Size(117, 23);
            this.lblReorderLevelSearch.TabIndex = 1;
            this.lblReorderLevelSearch.Text = "Reorder Level:";
            // 
            // txtUnitPriceSearch
            // 
            this.txtUnitPriceSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtUnitPriceSearch.ForeColor = System.Drawing.Color.White;
            this.txtUnitPriceSearch.Location = new System.Drawing.Point(491, 53);
            this.txtUnitPriceSearch.Name = "txtUnitPriceSearch";
            this.txtUnitPriceSearch.Size = new System.Drawing.Size(210, 30);
            this.txtUnitPriceSearch.TabIndex = 20;
            this.txtUnitPriceSearch.TextChanged += new System.EventHandler(this.txtUnitPrice_TextChanged);
            // 
            // lblUnitPriceSearch
            // 
            this.lblUnitPriceSearch.AutoSize = true;
            this.lblUnitPriceSearch.ForeColor = System.Drawing.Color.White;
            this.lblUnitPriceSearch.Location = new System.Drawing.Point(402, 55);
            this.lblUnitPriceSearch.Name = "lblUnitPriceSearch";
            this.lblUnitPriceSearch.Size = new System.Drawing.Size(88, 23);
            this.lblUnitPriceSearch.TabIndex = 1;
            this.lblUnitPriceSearch.Text = "Unit Price:";
            // 
            // lblUnitsinStockSearch
            // 
            this.lblUnitsinStockSearch.AutoSize = true;
            this.lblUnitsinStockSearch.ForeColor = System.Drawing.Color.White;
            this.lblUnitsinStockSearch.Location = new System.Drawing.Point(373, 89);
            this.lblUnitsinStockSearch.Name = "lblUnitsinStockSearch";
            this.lblUnitsinStockSearch.Size = new System.Drawing.Size(117, 23);
            this.lblUnitsinStockSearch.TabIndex = 1;
            this.lblUnitsinStockSearch.Text = "Units in Stock:";
            // 
            // lblDiscountinuedSearch
            // 
            this.lblDiscountinuedSearch.AutoSize = true;
            this.lblDiscountinuedSearch.ForeColor = System.Drawing.Color.White;
            this.lblDiscountinuedSearch.Location = new System.Drawing.Point(505, 136);
            this.lblDiscountinuedSearch.Name = "lblDiscountinuedSearch";
            this.lblDiscountinuedSearch.Size = new System.Drawing.Size(120, 23);
            this.lblDiscountinuedSearch.TabIndex = 1;
            this.lblDiscountinuedSearch.Text = "Discountinued";
            // 
            // txtUnitsinStockSearch
            // 
            this.txtUnitsinStockSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtUnitsinStockSearch.ForeColor = System.Drawing.Color.White;
            this.txtUnitsinStockSearch.Location = new System.Drawing.Point(491, 87);
            this.txtUnitsinStockSearch.Name = "txtUnitsinStockSearch";
            this.txtUnitsinStockSearch.Size = new System.Drawing.Size(210, 30);
            this.txtUnitsinStockSearch.TabIndex = 21;
            this.txtUnitsinStockSearch.TextChanged += new System.EventHandler(this.txtUnitsinStock_TextChanged);
            // 
            // txtReorderLevelSearch
            // 
            this.txtReorderLevelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtReorderLevelSearch.ForeColor = System.Drawing.Color.White;
            this.txtReorderLevelSearch.Location = new System.Drawing.Point(491, 16);
            this.txtReorderLevelSearch.Name = "txtReorderLevelSearch";
            this.txtReorderLevelSearch.Size = new System.Drawing.Size(210, 30);
            this.txtReorderLevelSearch.TabIndex = 19;
            this.txtReorderLevelSearch.TextChanged += new System.EventHandler(this.txtReorderLevel_TextChanged);
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(1800, 721);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProducts";
            this.Load += new System.EventHandler(this.frmProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox cbbSupplier;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private Label lblUnitsonOrder;
        private Label lbReorderLevel;
        private Label lblQuantityperUnit;
        private Label lblSupplier;
        private Label lblUnitsinStock;
        private Label lblProductName;
        private Label lblProducts;
        private Label lblDiscontinued;
        private Label lblUnitPrice;
        private Label lblProductID;
        private TextBox txtlblUnitsonOrder;
        private TextBox txtReorderLevel;
        private TextBox txtQuantityperUnit;
        private DataGridView dataGridView1;
        private TextBox txtUnitsinStock;
        private TextBox txtProductName;
        private TextBox txtUnitPrice;
        private TextBox txtProductID;
        private Button btnX;
        private GroupBox groupBox1;
        private ComboBox cbbCategory;
        private Label lblCategory;
        private RadioButton rdbNo;
        private RadioButton rdbYes;
        private GroupBox groupBox2;
        private RadioButton rdbDiscontinued;
        private RadioButton rdbCategory;
        private RadioButton rdbUnitPrice;
        private RadioButton rdbProductName;
        private RadioButton rdbUnitsinStock;
        private RadioButton rdbSupplier;
        private RadioButton rdbReorderLevel;
        private RadioButton rdbProductID;
        private RadioButton rdbNoSearch;
        private TextBox txtProductNameSearch;
        private RadioButton rdbYesSearch;
        private TextBox txtProductIDSearch;
        private ComboBox cbbCategorySearch;
        private Label lblProductIDSearch;
        private ComboBox cbbSupplierSearch;
        private Label lblProductNameSearch;
        private Label lblSupplierSearch;
        private Label lblCategorySearch;
        private Label lblReorderLevelSearch;
        private TextBox txtUnitPriceSearch;
        private Label lblUnitPriceSearch;
        private Label lblUnitsinStockSearch;
        private Label lblDiscountinuedSearch;
        private TextBox txtUnitsinStockSearch;
        private TextBox txtReorderLevelSearch;
        private Button btnListProducts;
        private Button btnSearch;
        private GroupBox groupBox3;
    }
}