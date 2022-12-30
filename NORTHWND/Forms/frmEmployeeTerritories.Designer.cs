namespace NORTHWND.Forms
{
    partial class frmEmployeeTerritories
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbTerritory = new System.Windows.Forms.ComboBox();
            this.cbbEmployee = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblTerritory = new System.Windows.Forms.Label();
            this.lblEmployeeTerritories = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.btnX = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbTerritory = new System.Windows.Forms.RadioButton();
            this.rdbEmployee = new System.Windows.Forms.RadioButton();
            this.btnListAll = new System.Windows.Forms.Button();
            this.cbbTerritorySearch = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbbEmployeeSearch = new System.Windows.Forms.ComboBox();
            this.lblEmployeeSearch = new System.Windows.Forms.Label();
            this.lblTerritorySearch = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbTerritory);
            this.groupBox1.Controls.Add(this.cbbEmployee);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.lblTerritory);
            this.groupBox1.Controls.Add(this.lblEmployeeTerritories);
            this.groupBox1.Controls.Add(this.lblEmployee);
            this.groupBox1.Location = new System.Drawing.Point(602, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 347);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // cbbTerritory
            // 
            this.cbbTerritory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.cbbTerritory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTerritory.ForeColor = System.Drawing.Color.White;
            this.cbbTerritory.FormattingEnabled = true;
            this.cbbTerritory.Location = new System.Drawing.Point(120, 122);
            this.cbbTerritory.Name = "cbbTerritory";
            this.cbbTerritory.Size = new System.Drawing.Size(218, 31);
            this.cbbTerritory.TabIndex = 2;
            // 
            // cbbEmployee
            // 
            this.cbbEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.cbbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEmployee.ForeColor = System.Drawing.Color.White;
            this.cbbEmployee.FormattingEnabled = true;
            this.cbbEmployee.Location = new System.Drawing.Point(120, 81);
            this.cbbEmployee.Name = "cbbEmployee";
            this.cbbEmployee.Size = new System.Drawing.Size(218, 31);
            this.cbbEmployee.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(120, 242);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(218, 39);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(120, 197);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(218, 39);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblTerritory
            // 
            this.lblTerritory.AutoSize = true;
            this.lblTerritory.ForeColor = System.Drawing.Color.White;
            this.lblTerritory.Location = new System.Drawing.Point(46, 121);
            this.lblTerritory.Name = "lblTerritory";
            this.lblTerritory.Size = new System.Drawing.Size(76, 23);
            this.lblTerritory.TabIndex = 1;
            this.lblTerritory.Text = "Territory:";
            // 
            // lblEmployeeTerritories
            // 
            this.lblEmployeeTerritories.AutoSize = true;
            this.lblEmployeeTerritories.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmployeeTerritories.ForeColor = System.Drawing.Color.White;
            this.lblEmployeeTerritories.Location = new System.Drawing.Point(4, 26);
            this.lblEmployeeTerritories.Name = "lblEmployeeTerritories";
            this.lblEmployeeTerritories.Size = new System.Drawing.Size(344, 35);
            this.lblEmployeeTerritories.TabIndex = 1;
            this.lblEmployeeTerritories.Text = "EMPLOYEE TERRITORIES";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.ForeColor = System.Drawing.Color.White;
            this.lblEmployee.Location = new System.Drawing.Point(34, 85);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(88, 23);
            this.lblEmployee.TabIndex = 1;
            this.lblEmployee.Text = "Employee:";
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.Red;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.ForeColor = System.Drawing.Color.White;
            this.btnX.Location = new System.Drawing.Point(949, -1);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(32, 33);
            this.btnX.TabIndex = 11;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 129);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(590, 238);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbTerritory);
            this.groupBox2.Controls.Add(this.rdbEmployee);
            this.groupBox2.Controls.Add(this.btnListAll);
            this.groupBox2.Controls.Add(this.cbbTerritorySearch);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.cbbEmployeeSearch);
            this.groupBox2.Controls.Add(this.lblEmployeeSearch);
            this.groupBox2.Controls.Add(this.lblTerritorySearch);
            this.groupBox2.Location = new System.Drawing.Point(6, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(590, 108);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // rdbTerritory
            // 
            this.rdbTerritory.AutoSize = true;
            this.rdbTerritory.ForeColor = System.Drawing.Color.White;
            this.rdbTerritory.Location = new System.Drawing.Point(288, 60);
            this.rdbTerritory.Name = "rdbTerritory";
            this.rdbTerritory.Size = new System.Drawing.Size(93, 27);
            this.rdbTerritory.TabIndex = 8;
            this.rdbTerritory.TabStop = true;
            this.rdbTerritory.Text = "Territory";
            this.rdbTerritory.UseVisualStyleBackColor = true;
            // 
            // rdbEmployee
            // 
            this.rdbEmployee.AutoSize = true;
            this.rdbEmployee.ForeColor = System.Drawing.Color.White;
            this.rdbEmployee.Location = new System.Drawing.Point(288, 21);
            this.rdbEmployee.Name = "rdbEmployee";
            this.rdbEmployee.Size = new System.Drawing.Size(105, 27);
            this.rdbEmployee.TabIndex = 7;
            this.rdbEmployee.TabStop = true;
            this.rdbEmployee.Text = "Employee";
            this.rdbEmployee.UseVisualStyleBackColor = true;
            // 
            // btnListAll
            // 
            this.btnListAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnListAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListAll.Location = new System.Drawing.Point(421, 60);
            this.btnListAll.Name = "btnListAll";
            this.btnListAll.Size = new System.Drawing.Size(163, 35);
            this.btnListAll.TabIndex = 10;
            this.btnListAll.Text = "List all";
            this.btnListAll.UseVisualStyleBackColor = false;
            this.btnListAll.Click += new System.EventHandler(this.btnListAll_Click);
            // 
            // cbbTerritorySearch
            // 
            this.cbbTerritorySearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.cbbTerritorySearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTerritorySearch.ForeColor = System.Drawing.Color.White;
            this.cbbTerritorySearch.FormattingEnabled = true;
            this.cbbTerritorySearch.Location = new System.Drawing.Point(92, 60);
            this.cbbTerritorySearch.Name = "cbbTerritorySearch";
            this.cbbTerritorySearch.Size = new System.Drawing.Size(190, 31);
            this.cbbTerritorySearch.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(421, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(163, 35);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbbEmployeeSearch
            // 
            this.cbbEmployeeSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.cbbEmployeeSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEmployeeSearch.ForeColor = System.Drawing.Color.White;
            this.cbbEmployeeSearch.FormattingEnabled = true;
            this.cbbEmployeeSearch.Location = new System.Drawing.Point(92, 19);
            this.cbbEmployeeSearch.Name = "cbbEmployeeSearch";
            this.cbbEmployeeSearch.Size = new System.Drawing.Size(190, 31);
            this.cbbEmployeeSearch.TabIndex = 5;
            // 
            // lblEmployeeSearch
            // 
            this.lblEmployeeSearch.AutoSize = true;
            this.lblEmployeeSearch.ForeColor = System.Drawing.Color.White;
            this.lblEmployeeSearch.Location = new System.Drawing.Point(6, 23);
            this.lblEmployeeSearch.Name = "lblEmployeeSearch";
            this.lblEmployeeSearch.Size = new System.Drawing.Size(88, 23);
            this.lblEmployeeSearch.TabIndex = 1;
            this.lblEmployeeSearch.Text = "Employee:";
            // 
            // lblTerritorySearch
            // 
            this.lblTerritorySearch.AutoSize = true;
            this.lblTerritorySearch.ForeColor = System.Drawing.Color.White;
            this.lblTerritorySearch.Location = new System.Drawing.Point(18, 59);
            this.lblTerritorySearch.Name = "lblTerritorySearch";
            this.lblTerritorySearch.Size = new System.Drawing.Size(76, 23);
            this.lblTerritorySearch.TabIndex = 1;
            this.lblTerritorySearch.Text = "Territory:";
            // 
            // frmEmployeeTerritories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(979, 379);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmployeeTerritories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEmployeeTerritories";
            this.Load += new System.EventHandler(this.frmEmployeeTerritories_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnDelete;
        private Button btnAdd;
        private Label lblTerritory;
        private Label lblEmployeeTerritories;
        private Label lblEmployee;
        private Button btnX;
        private DataGridView dataGridView1;
        private ComboBox cbbTerritory;
        private ComboBox cbbEmployee;
        private GroupBox groupBox2;
        private RadioButton rdbTerritory;
        private RadioButton rdbEmployee;
        private Button btnListAll;
        private ComboBox cbbTerritorySearch;
        private Button btnSearch;
        private ComboBox cbbEmployeeSearch;
        private Label lblEmployeeSearch;
        private Label lblTerritorySearch;
    }
}