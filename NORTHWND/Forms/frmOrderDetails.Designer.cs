namespace NORTHWND.Forms
{
    partial class frmOrderDetails
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
            this.rdbOrderID = new System.Windows.Forms.RadioButton();
            this.btnListProducts = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rdbQuantity = new System.Windows.Forms.RadioButton();
            this.rdbUnitPrice = new System.Windows.Forms.RadioButton();
            this.rdbProduct = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbbProductSearch = new System.Windows.Forms.ComboBox();
            this.txtUnitPriceSearch = new System.Windows.Forms.TextBox();
            this.lblQuantitySearch = new System.Windows.Forms.Label();
            this.txtOrderIDSearch = new System.Windows.Forms.TextBox();
            this.lblProductSearch = new System.Windows.Forms.Label();
            this.lblOrderIDSearch = new System.Windows.Forms.Label();
            this.lblunitPriceSearch = new System.Windows.Forms.Label();
            this.txtQuantitySearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.lblProducts = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbProduct = new System.Windows.Forms.ComboBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.btnX = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbOrderID
            // 
            this.rdbOrderID.AutoSize = true;
            this.rdbOrderID.ForeColor = System.Drawing.Color.White;
            this.rdbOrderID.Location = new System.Drawing.Point(353, 18);
            this.rdbOrderID.Name = "rdbOrderID";
            this.rdbOrderID.Size = new System.Drawing.Size(113, 27);
            this.rdbOrderID.TabIndex = 12;
            this.rdbOrderID.TabStop = true;
            this.rdbOrderID.Text = "Product ID";
            this.rdbOrderID.UseVisualStyleBackColor = true;
            // 
            // btnListProducts
            // 
            this.btnListProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnListProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListProducts.Location = new System.Drawing.Point(567, 93);
            this.btnListProducts.Name = "btnListProducts";
            this.btnListProducts.Size = new System.Drawing.Size(210, 39);
            this.btnListProducts.TabIndex = 17;
            this.btnListProducts.Text = "List Products";
            this.btnListProducts.UseVisualStyleBackColor = false;
            this.btnListProducts.Click += new System.EventHandler(this.btnListProducts_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(567, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(210, 39);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rdbQuantity
            // 
            this.rdbQuantity.AutoSize = true;
            this.rdbQuantity.ForeColor = System.Drawing.Color.White;
            this.rdbQuantity.Location = new System.Drawing.Point(353, 132);
            this.rdbQuantity.Name = "rdbQuantity";
            this.rdbQuantity.Size = new System.Drawing.Size(97, 27);
            this.rdbQuantity.TabIndex = 15;
            this.rdbQuantity.TabStop = true;
            this.rdbQuantity.Text = "Quantity";
            this.rdbQuantity.UseVisualStyleBackColor = true;
            // 
            // rdbUnitPrice
            // 
            this.rdbUnitPrice.AutoSize = true;
            this.rdbUnitPrice.ForeColor = System.Drawing.Color.White;
            this.rdbUnitPrice.Location = new System.Drawing.Point(353, 93);
            this.rdbUnitPrice.Name = "rdbUnitPrice";
            this.rdbUnitPrice.Size = new System.Drawing.Size(105, 27);
            this.rdbUnitPrice.TabIndex = 14;
            this.rdbUnitPrice.TabStop = true;
            this.rdbUnitPrice.Text = "Unit Price";
            this.rdbUnitPrice.UseVisualStyleBackColor = true;
            // 
            // rdbProduct
            // 
            this.rdbProduct.AutoSize = true;
            this.rdbProduct.ForeColor = System.Drawing.Color.White;
            this.rdbProduct.Location = new System.Drawing.Point(353, 57);
            this.rdbProduct.Name = "rdbProduct";
            this.rdbProduct.Size = new System.Drawing.Size(91, 27);
            this.rdbProduct.TabIndex = 13;
            this.rdbProduct.TabStop = true;
            this.rdbProduct.Text = "Product";
            this.rdbProduct.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbbProductSearch);
            this.groupBox2.Controls.Add(this.btnListProducts);
            this.groupBox2.Controls.Add(this.rdbOrderID);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.txtUnitPriceSearch);
            this.groupBox2.Controls.Add(this.lblQuantitySearch);
            this.groupBox2.Controls.Add(this.txtOrderIDSearch);
            this.groupBox2.Controls.Add(this.rdbQuantity);
            this.groupBox2.Controls.Add(this.rdbUnitPrice);
            this.groupBox2.Controls.Add(this.lblProductSearch);
            this.groupBox2.Controls.Add(this.lblOrderIDSearch);
            this.groupBox2.Controls.Add(this.lblunitPriceSearch);
            this.groupBox2.Controls.Add(this.txtQuantitySearch);
            this.groupBox2.Controls.Add(this.rdbProduct);
            this.groupBox2.Location = new System.Drawing.Point(2, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(798, 165);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            // 
            // cbbProductSearch
            // 
            this.cbbProductSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.cbbProductSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbProductSearch.FormattingEnabled = true;
            this.cbbProductSearch.Location = new System.Drawing.Point(104, 53);
            this.cbbProductSearch.Name = "cbbProductSearch";
            this.cbbProductSearch.Size = new System.Drawing.Size(210, 31);
            this.cbbProductSearch.TabIndex = 9;
            // 
            // txtUnitPriceSearch
            // 
            this.txtUnitPriceSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtUnitPriceSearch.ForeColor = System.Drawing.Color.White;
            this.txtUnitPriceSearch.Location = new System.Drawing.Point(104, 90);
            this.txtUnitPriceSearch.Name = "txtUnitPriceSearch";
            this.txtUnitPriceSearch.Size = new System.Drawing.Size(210, 30);
            this.txtUnitPriceSearch.TabIndex = 10;
            // 
            // lblQuantitySearch
            // 
            this.lblQuantitySearch.AutoSize = true;
            this.lblQuantitySearch.ForeColor = System.Drawing.Color.White;
            this.lblQuantitySearch.Location = new System.Drawing.Point(23, 132);
            this.lblQuantitySearch.Name = "lblQuantitySearch";
            this.lblQuantitySearch.Size = new System.Drawing.Size(80, 23);
            this.lblQuantitySearch.TabIndex = 1;
            this.lblQuantitySearch.Text = "Quantity:";
            // 
            // txtOrderIDSearch
            // 
            this.txtOrderIDSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtOrderIDSearch.ForeColor = System.Drawing.Color.White;
            this.txtOrderIDSearch.Location = new System.Drawing.Point(104, 18);
            this.txtOrderIDSearch.Name = "txtOrderIDSearch";
            this.txtOrderIDSearch.Size = new System.Drawing.Size(210, 30);
            this.txtOrderIDSearch.TabIndex = 8;
            // 
            // lblProductSearch
            // 
            this.lblProductSearch.AutoSize = true;
            this.lblProductSearch.ForeColor = System.Drawing.Color.White;
            this.lblProductSearch.Location = new System.Drawing.Point(29, 55);
            this.lblProductSearch.Name = "lblProductSearch";
            this.lblProductSearch.Size = new System.Drawing.Size(74, 23);
            this.lblProductSearch.TabIndex = 1;
            this.lblProductSearch.Text = "Product:";
            // 
            // lblOrderIDSearch
            // 
            this.lblOrderIDSearch.AutoSize = true;
            this.lblOrderIDSearch.ForeColor = System.Drawing.Color.White;
            this.lblOrderIDSearch.Location = new System.Drawing.Point(23, 21);
            this.lblOrderIDSearch.Name = "lblOrderIDSearch";
            this.lblOrderIDSearch.Size = new System.Drawing.Size(80, 23);
            this.lblOrderIDSearch.TabIndex = 1;
            this.lblOrderIDSearch.Text = "Order ID:";
            // 
            // lblunitPriceSearch
            // 
            this.lblunitPriceSearch.AutoSize = true;
            this.lblunitPriceSearch.ForeColor = System.Drawing.Color.White;
            this.lblunitPriceSearch.Location = new System.Drawing.Point(15, 93);
            this.lblunitPriceSearch.Name = "lblunitPriceSearch";
            this.lblunitPriceSearch.Size = new System.Drawing.Size(88, 23);
            this.lblunitPriceSearch.TabIndex = 1;
            this.lblunitPriceSearch.Text = "Unit Price:";
            // 
            // txtQuantitySearch
            // 
            this.txtQuantitySearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtQuantitySearch.ForeColor = System.Drawing.Color.White;
            this.txtQuantitySearch.Location = new System.Drawing.Point(104, 129);
            this.txtQuantitySearch.Name = "txtQuantitySearch";
            this.txtQuantitySearch.Size = new System.Drawing.Size(210, 30);
            this.txtQuantitySearch.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 186);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(798, 364);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(122, 398);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(210, 39);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(122, 340);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(210, 39);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.ForeColor = System.Drawing.Color.White;
            this.lblQuantity.Location = new System.Drawing.Point(41, 221);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(80, 23);
            this.lblQuantity.TabIndex = 1;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.ForeColor = System.Drawing.Color.White;
            this.lblDiscount.Location = new System.Drawing.Point(40, 257);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(81, 23);
            this.lblDiscount.TabIndex = 1;
            this.lblDiscount.Text = "Discount:";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.ForeColor = System.Drawing.Color.White;
            this.lblOrderID.Location = new System.Drawing.Point(41, 113);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(80, 23);
            this.lblOrderID.TabIndex = 1;
            this.lblOrderID.Text = "Order ID:";
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
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.ForeColor = System.Drawing.Color.White;
            this.lblUnitPrice.Location = new System.Drawing.Point(33, 185);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(88, 23);
            this.lblUnitPrice.TabIndex = 1;
            this.lblUnitPrice.Text = "Unit Price:";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.ForeColor = System.Drawing.Color.White;
            this.lblProduct.Location = new System.Drawing.Point(47, 148);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(74, 23);
            this.lblProduct.TabIndex = 1;
            this.lblProduct.Text = "Product:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtQuantity.ForeColor = System.Drawing.Color.White;
            this.txtQuantity.Location = new System.Drawing.Point(122, 218);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(210, 30);
            this.txtQuantity.TabIndex = 4;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbProduct);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.lblQuantity);
            this.groupBox1.Controls.Add(this.lblDiscount);
            this.groupBox1.Controls.Add(this.lblOrderID);
            this.groupBox1.Controls.Add(this.lblProducts);
            this.groupBox1.Controls.Add(this.lblUnitPrice);
            this.groupBox1.Controls.Add(this.lblProduct);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.txtDiscount);
            this.groupBox1.Controls.Add(this.txtOrderID);
            this.groupBox1.Controls.Add(this.txtUnitPrice);
            this.groupBox1.Location = new System.Drawing.Point(806, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 529);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // cbbProduct
            // 
            this.cbbProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.cbbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbProduct.FormattingEnabled = true;
            this.cbbProduct.Location = new System.Drawing.Point(122, 146);
            this.cbbProduct.Name = "cbbProduct";
            this.cbbProduct.Size = new System.Drawing.Size(210, 31);
            this.cbbProduct.TabIndex = 2;
            // 
            // txtDiscount
            // 
            this.txtDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtDiscount.ForeColor = System.Drawing.Color.White;
            this.txtDiscount.Location = new System.Drawing.Point(122, 254);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(210, 30);
            this.txtDiscount.TabIndex = 5;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // txtOrderID
            // 
            this.txtOrderID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtOrderID.ForeColor = System.Drawing.Color.White;
            this.txtOrderID.Location = new System.Drawing.Point(122, 110);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(210, 30);
            this.txtOrderID.TabIndex = 1;
            this.txtOrderID.TextChanged += new System.EventHandler(this.txtOrderID_TextChanged);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtUnitPrice.ForeColor = System.Drawing.Color.White;
            this.txtUnitPrice.Location = new System.Drawing.Point(122, 182);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(210, 30);
            this.txtUnitPrice.TabIndex = 3;
            this.txtUnitPrice.TextChanged += new System.EventHandler(this.txtUnitPrice_TextChanged);
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.Red;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.ForeColor = System.Drawing.Color.White;
            this.btnX.Location = new System.Drawing.Point(1180, 0);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(33, 33);
            this.btnX.TabIndex = 19;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // frmOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(1212, 573);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrderDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOrderDetails";
            this.Load += new System.EventHandler(this.frmOrderDetails_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RadioButton rdbOrderID;
        private Button btnListProducts;
        private Button btnSearch;
        private RadioButton rdbQuantity;
        private RadioButton rdbUnitPrice;
        private RadioButton rdbProduct;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Button btnDelete;
        private Button btnAdd;
        private Label lblQuantity;
        private Label lblDiscount;
        private Label lblOrderID;
        private Label lblProducts;
        private Label lblUnitPrice;
        private Label lblProduct;
        private TextBox txtQuantity;
        private GroupBox groupBox1;
        private TextBox txtDiscount;
        private TextBox txtOrderID;
        private TextBox txtUnitPrice;
        private Button btnX;
        private TextBox txtUnitPriceSearch;
        private Label lblQuantitySearch;
        private TextBox txtOrderIDSearch;
        private Label lblOrderIDSearch;
        private Label lblunitPriceSearch;
        private TextBox txtQuantitySearch;
        private ComboBox cbbProductSearch;
        private Label lblProductSearch;
        private ComboBox cbbProduct;
    }
}