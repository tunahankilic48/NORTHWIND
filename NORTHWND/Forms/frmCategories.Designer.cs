namespace NORTHWND.Forms
{
    partial class frmCategories
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.lblCategories = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.lblCategoryID = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.lblCategoryIDSearch = new System.Windows.Forms.Label();
            this.txtCategoryIDSearch = new System.Windows.Forms.TextBox();
            this.btnX = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbName = new System.Windows.Forms.RadioButton();
            this.btnList = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rdbID = new System.Windows.Forms.RadioButton();
            this.lblCategoryNameSearch = new System.Windows.Forms.Label();
            this.txtCategoryNameSearch = new System.Windows.Forms.TextBox();
            this.txtDescriptionSearch = new System.Windows.Forms.TextBox();
            this.lblDescriotionSearch = new System.Windows.Forms.Label();
            this.rdbDescription = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 136);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1030, 334);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Controls.Add(this.lblCategoryName);
            this.groupBox1.Controls.Add(this.lblCategories);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.txtCategoryID);
            this.groupBox1.Controls.Add(this.lblCategoryID);
            this.groupBox1.Controls.Add(this.txtCategoryName);
            this.groupBox1.Location = new System.Drawing.Point(1050, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(142, 329);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(194, 39);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(142, 284);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(194, 39);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(142, 239);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(194, 39);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(36, 155);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(100, 23);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description:";
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.ForeColor = System.Drawing.Color.White;
            this.lblCategoryName.Location = new System.Drawing.Point(2, 119);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(134, 23);
            this.lblCategoryName.TabIndex = 1;
            this.lblCategoryName.Text = "Category Name:";
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCategories.ForeColor = System.Drawing.Color.White;
            this.lblCategories.Location = new System.Drawing.Point(98, 24);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(193, 35);
            this.lblCategories.TabIndex = 1;
            this.lblCategories.Text = "CATEGORIES";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtDescription.ForeColor = System.Drawing.Color.White;
            this.txtDescription.Location = new System.Drawing.Point(142, 152);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(194, 30);
            this.txtDescription.TabIndex = 2;
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtCategoryID.Enabled = false;
            this.txtCategoryID.ForeColor = System.Drawing.Color.White;
            this.txtCategoryID.Location = new System.Drawing.Point(142, 80);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.Size = new System.Drawing.Size(194, 30);
            this.txtCategoryID.TabIndex = 0;
            // 
            // lblCategoryID
            // 
            this.lblCategoryID.AutoSize = true;
            this.lblCategoryID.ForeColor = System.Drawing.Color.White;
            this.lblCategoryID.Location = new System.Drawing.Point(31, 83);
            this.lblCategoryID.Name = "lblCategoryID";
            this.lblCategoryID.Size = new System.Drawing.Size(105, 23);
            this.lblCategoryID.TabIndex = 1;
            this.lblCategoryID.Text = "Category ID:";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtCategoryName.ForeColor = System.Drawing.Color.White;
            this.txtCategoryName.Location = new System.Drawing.Point(142, 116);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(194, 30);
            this.txtCategoryName.TabIndex = 1;
            // 
            // lblCategoryIDSearch
            // 
            this.lblCategoryIDSearch.AutoSize = true;
            this.lblCategoryIDSearch.ForeColor = System.Drawing.Color.White;
            this.lblCategoryIDSearch.Location = new System.Drawing.Point(35, 32);
            this.lblCategoryIDSearch.Name = "lblCategoryIDSearch";
            this.lblCategoryIDSearch.Size = new System.Drawing.Size(105, 23);
            this.lblCategoryIDSearch.TabIndex = 1;
            this.lblCategoryIDSearch.Text = "Category ID:";
            // 
            // txtCategoryIDSearch
            // 
            this.txtCategoryIDSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtCategoryIDSearch.ForeColor = System.Drawing.Color.White;
            this.txtCategoryIDSearch.Location = new System.Drawing.Point(146, 29);
            this.txtCategoryIDSearch.Name = "txtCategoryIDSearch";
            this.txtCategoryIDSearch.Size = new System.Drawing.Size(194, 30);
            this.txtCategoryIDSearch.TabIndex = 6;
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.Red;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.ForeColor = System.Drawing.Color.White;
            this.btnX.Location = new System.Drawing.Point(1421, -2);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(33, 33);
            this.btnX.TabIndex = 14;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbName);
            this.groupBox2.Controls.Add(this.btnList);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.rdbID);
            this.groupBox2.Controls.Add(this.lblCategoryNameSearch);
            this.groupBox2.Controls.Add(this.txtCategoryNameSearch);
            this.groupBox2.Controls.Add(this.txtDescriptionSearch);
            this.groupBox2.Controls.Add(this.lblDescriotionSearch);
            this.groupBox2.Controls.Add(this.txtCategoryIDSearch);
            this.groupBox2.Controls.Add(this.lblCategoryIDSearch);
            this.groupBox2.Controls.Add(this.rdbDescription);
            this.groupBox2.Location = new System.Drawing.Point(14, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1030, 117);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // rdbName
            // 
            this.rdbName.AutoSize = true;
            this.rdbName.ForeColor = System.Drawing.Color.White;
            this.rdbName.Location = new System.Drawing.Point(680, 51);
            this.rdbName.Name = "rdbName";
            this.rdbName.Size = new System.Drawing.Size(152, 27);
            this.rdbName.TabIndex = 10;
            this.rdbName.TabStop = true;
            this.rdbName.Text = "Search in Name";
            this.rdbName.UseVisualStyleBackColor = true;
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.Location = new System.Drawing.Point(866, 63);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(158, 47);
            this.btnList.TabIndex = 13;
            this.btnList.Text = "List All Categories";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(866, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(158, 39);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rdbID
            // 
            this.rdbID.AutoSize = true;
            this.rdbID.ForeColor = System.Drawing.Color.White;
            this.rdbID.Location = new System.Drawing.Point(680, 18);
            this.rdbID.Name = "rdbID";
            this.rdbID.Size = new System.Drawing.Size(104, 27);
            this.rdbID.TabIndex = 9;
            this.rdbID.TabStop = true;
            this.rdbID.Text = "Search ID";
            this.rdbID.UseVisualStyleBackColor = true;
            // 
            // lblCategoryNameSearch
            // 
            this.lblCategoryNameSearch.AutoSize = true;
            this.lblCategoryNameSearch.ForeColor = System.Drawing.Color.White;
            this.lblCategoryNameSearch.Location = new System.Drawing.Point(6, 70);
            this.lblCategoryNameSearch.Name = "lblCategoryNameSearch";
            this.lblCategoryNameSearch.Size = new System.Drawing.Size(134, 23);
            this.lblCategoryNameSearch.TabIndex = 1;
            this.lblCategoryNameSearch.Text = "Category Name:";
            // 
            // txtCategoryNameSearch
            // 
            this.txtCategoryNameSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtCategoryNameSearch.ForeColor = System.Drawing.Color.White;
            this.txtCategoryNameSearch.Location = new System.Drawing.Point(146, 67);
            this.txtCategoryNameSearch.Name = "txtCategoryNameSearch";
            this.txtCategoryNameSearch.Size = new System.Drawing.Size(194, 30);
            this.txtCategoryNameSearch.TabIndex = 7;
            // 
            // txtDescriptionSearch
            // 
            this.txtDescriptionSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtDescriptionSearch.ForeColor = System.Drawing.Color.White;
            this.txtDescriptionSearch.Location = new System.Drawing.Point(464, 50);
            this.txtDescriptionSearch.Name = "txtDescriptionSearch";
            this.txtDescriptionSearch.Size = new System.Drawing.Size(194, 30);
            this.txtDescriptionSearch.TabIndex = 8;
            // 
            // lblDescriotionSearch
            // 
            this.lblDescriotionSearch.AutoSize = true;
            this.lblDescriotionSearch.ForeColor = System.Drawing.Color.White;
            this.lblDescriotionSearch.Location = new System.Drawing.Point(358, 53);
            this.lblDescriotionSearch.Name = "lblDescriotionSearch";
            this.lblDescriotionSearch.Size = new System.Drawing.Size(100, 23);
            this.lblDescriotionSearch.TabIndex = 1;
            this.lblDescriotionSearch.Text = "Description:";
            // 
            // rdbDescription
            // 
            this.rdbDescription.AutoSize = true;
            this.rdbDescription.ForeColor = System.Drawing.Color.White;
            this.rdbDescription.Location = new System.Drawing.Point(680, 84);
            this.rdbDescription.Name = "rdbDescription";
            this.rdbDescription.Size = new System.Drawing.Size(192, 27);
            this.rdbDescription.TabIndex = 11;
            this.rdbDescription.TabStop = true;
            this.rdbDescription.Text = "Search in Description";
            this.rdbDescription.UseVisualStyleBackColor = true;
            // 
            // frmCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(1450, 494);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCategories";
            this.Load += new System.EventHandler(this.frmCategories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private Label lblDescription;
        private Label lblCategoryName;
        private Label lblCategories;
        private Label lblCategoryIDSearch;
        private TextBox txtDescription;
        private TextBox txtCategoryName;
        private TextBox txtCategoryIDSearch;
        private Button btnX;
        private TextBox txtCategoryID;
        private Label lblCategoryID;
        private GroupBox groupBox2;
        private RadioButton rdbDescription;
        private RadioButton rdbName;
        private RadioButton rdbID;
        private Label lblCategoryNameSearch;
        private TextBox txtCategoryNameSearch;
        private TextBox txtDescriptionSearch;
        private Label lblDescriotionSearch;
        private Button btnSearch;
        private Button btnList;
    }
}