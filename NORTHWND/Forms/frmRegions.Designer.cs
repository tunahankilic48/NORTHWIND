namespace NORTHWND.Forms
{
    partial class frmRegions
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbRegionDescription = new System.Windows.Forms.Label();
            this.lblRegions = new System.Windows.Forms.Label();
            this.lblRegionID = new System.Windows.Forms.Label();
            this.txtRegionDescription = new System.Windows.Forms.TextBox();
            this.txtRegionID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnX = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.lbRegionDescription);
            this.groupBox1.Controls.Add(this.lblRegions);
            this.groupBox1.Controls.Add(this.lblRegionID);
            this.groupBox1.Controls.Add(this.txtRegionDescription);
            this.groupBox1.Controls.Add(this.txtRegionID);
            this.groupBox1.Location = new System.Drawing.Point(351, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 309);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(224)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(158, 251);
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
            this.btnDelete.Location = new System.Drawing.Point(158, 206);
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
            this.btnAdd.Location = new System.Drawing.Point(158, 161);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(194, 39);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbRegionDescription
            // 
            this.lbRegionDescription.AutoSize = true;
            this.lbRegionDescription.ForeColor = System.Drawing.Color.White;
            this.lbRegionDescription.Location = new System.Drawing.Point(1, 119);
            this.lbRegionDescription.Name = "lbRegionDescription";
            this.lbRegionDescription.Size = new System.Drawing.Size(158, 23);
            this.lbRegionDescription.TabIndex = 1;
            this.lbRegionDescription.Text = "Region Description:";
            // 
            // lblRegions
            // 
            this.lblRegions.AutoSize = true;
            this.lblRegions.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegions.ForeColor = System.Drawing.Color.White;
            this.lblRegions.Location = new System.Drawing.Point(98, 24);
            this.lblRegions.Name = "lblRegions";
            this.lblRegions.Size = new System.Drawing.Size(137, 35);
            this.lblRegions.TabIndex = 1;
            this.lblRegions.Text = "REGİONS";
            // 
            // lblRegionID
            // 
            this.lblRegionID.AutoSize = true;
            this.lblRegionID.ForeColor = System.Drawing.Color.White;
            this.lblRegionID.Location = new System.Drawing.Point(70, 83);
            this.lblRegionID.Name = "lblRegionID";
            this.lblRegionID.Size = new System.Drawing.Size(89, 23);
            this.lblRegionID.TabIndex = 1;
            this.lblRegionID.Text = "Region ID:";
            // 
            // txtRegionDescription
            // 
            this.txtRegionDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtRegionDescription.ForeColor = System.Drawing.Color.White;
            this.txtRegionDescription.Location = new System.Drawing.Point(158, 116);
            this.txtRegionDescription.Name = "txtRegionDescription";
            this.txtRegionDescription.Size = new System.Drawing.Size(194, 30);
            this.txtRegionDescription.TabIndex = 2;
            this.txtRegionDescription.TextChanged += new System.EventHandler(this.txtRegionDescription_TextChanged);
            // 
            // txtRegionID
            // 
            this.txtRegionID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.txtRegionID.ForeColor = System.Drawing.Color.White;
            this.txtRegionID.Location = new System.Drawing.Point(158, 80);
            this.txtRegionID.Name = "txtRegionID";
            this.txtRegionID.Size = new System.Drawing.Size(194, 30);
            this.txtRegionID.TabIndex = 1;
            this.txtRegionID.TextChanged += new System.EventHandler(this.txtRegionID_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 32);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(340, 299);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.Red;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.ForeColor = System.Drawing.Color.White;
            this.btnX.Location = new System.Drawing.Point(725, 0);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(32, 33);
            this.btnX.TabIndex = 7;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // frmRegions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(756, 357);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegions";
            this.Load += new System.EventHandler(this.frmRegions_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private Label lbRegionDescription;
        private Label lblRegions;
        private Label lblRegionID;
        private TextBox txtRegionDescription;
        private TextBox txtRegionID;
        private DataGridView dataGridView1;
        private Button btnX;
    }
}