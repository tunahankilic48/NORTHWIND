using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NORTHWND.Forms
{
    public partial class frmTerritories : Form
    {
        public frmTerritories(frmHomePage frm)
        {
            InitializeComponent();
            _frm = frm;
        }

        ErrorProvider erpTerritoryID = new ErrorProvider(), erpTerritoryDescription = new ErrorProvider();

        private frmHomePage _frm;

        void ListTheDataonDataGridView()
        {
            SqlCommand cmd = new SqlCommand("select TerritoryID, TerritoryDescription, RegionDescription, t.RegionID from Territories as t join Region as r on t.RegionID = r.RegionID", Connection.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["RegionID"].Visible = false;
        }
        void FillcbbRegion()
        {
            SqlCommand cmd = new SqlCommand("Select RegionID, RegionDescription from Region order by RegionDescription", Connection.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbRegion.ValueMember = "RegionID";
            cbbRegion.DisplayMember = "RegionDescription";
            cbbRegion.DataSource = dt;
        }
        void FillcbbRegionSearch()
        {
            SqlCommand cmd = new SqlCommand("Select RegionID, RegionDescription from Region order by RegionDescription", Connection.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbRegionSearch.ValueMember = "RegionID";
            cbbRegionSearch.DisplayMember = "RegionDescription";
            cbbRegionSearch.DataSource = dt;
        }

        void CleanTheControls()
        {
            foreach (Control control in this.groupBox1.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = 0;
                }
            }
            foreach (Control control in this.groupBox2.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = 0;
                }
            }
        }
        private void frmTerritories_Load(object sender, EventArgs e)
        {
            ListTheDataonDataGridView();
            FillcbbRegion();
            FillcbbRegionSearch();
            CleanTheControls();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTerritoryID.Text = dataGridView1.CurrentRow.Cells["TerritoryID"].Value.ToString();
            txtTerritoryDescription.Text = dataGridView1.CurrentRow.Cells["TerritoryDescription"].Value.ToString();
            cbbRegion.SelectedValue = dataGridView1.CurrentRow.Cells["RegionID"].Value;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            _frm.Show();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTerritoryID.Text) && !(txtTerritoryID.Text.Length > 20) && !string.IsNullOrEmpty(txtTerritoryDescription.Text) && !(txtTerritoryDescription.Text.Length > 50))
            {
                SqlCommand cmd = new SqlCommand("insert into Territories (TerritoryID, TerritoryDescription, RegionID) values (@territoryID, @territoryDescription, @regionID)", Connection.con);
                cmd.Parameters.AddWithValue("@territoryID", txtTerritoryID.Text);
                cmd.Parameters.AddWithValue("@territoryDescription", txtTerritoryDescription.Text);
                cmd.Parameters.AddWithValue("@regionID", cbbRegion.SelectedValue);
                if (Connection.con.State == ConnectionState.Closed)
                    Connection.con.Open();
                try
                {
                    DialogResult dialogResult = MessageBox.Show($"Are You Sure Adding {txtTerritoryDescription.Text}", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"{txtTerritoryDescription.Text} Added into Territories Table", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("The Adding Has Been Cancelled.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Connection.con.Close();
                    ListTheDataonDataGridView();
                    CleanTheControls();
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtTerritoryDescription.Text) || string.IsNullOrEmpty(txtTerritoryID.Text))
                    MessageBox.Show("Territory ID and Description cannot be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Checked the errors and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTerritoryID.Text))
            {
                SqlCommand cmd = new SqlCommand("delete from Territories where TerritoryID = @territoryID", Connection.con);
                cmd.Parameters.AddWithValue("@territoryID", txtTerritoryID.Text);
                if (Connection.con.State == ConnectionState.Closed)
                    Connection.con.Open();
                try
                {
                    DialogResult dialogResult = MessageBox.Show($"Are You Sure Delete {txtTerritoryDescription.Text}", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"{txtTerritoryDescription.Text} Delete from Territories Table", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("The Deletion Has Been Cancelled.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Connection.con.Close();
                    ListTheDataonDataGridView();
                    CleanTheControls();
                }
            }
            else
            {
                MessageBox.Show("Territory ID cannot be null for deletion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTerritoryID.Text) && !(txtTerritoryID.Text.Length > 20) && !string.IsNullOrEmpty(txtTerritoryDescription.Text) && !(txtTerritoryDescription.Text.Length > 50))
            {
                SqlCommand cmd = new SqlCommand("update Territories set TerritoryDescription = @territoryDescription, RegionID = @regionID where TerritoryID = @territoryID", Connection.con);
                cmd.Parameters.AddWithValue("@territoryID", txtTerritoryID.Text);
                cmd.Parameters.AddWithValue("@territoryDescription", txtTerritoryDescription.Text);
                cmd.Parameters.AddWithValue("@regionID", cbbRegion.SelectedValue);
                if (Connection.con.State == ConnectionState.Closed)
                    Connection.con.Open();
                try
                {
                    DialogResult dialogResult = MessageBox.Show($"Are You Sure Update {txtTerritoryDescription.Text}", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"{txtTerritoryDescription.Text} Updated on Territories Table", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("The Update Has Been Cancelled.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Connection.con.Close();
                    ListTheDataonDataGridView();
                    CleanTheControls();
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtTerritoryDescription.Text) || string.IsNullOrEmpty(txtTerritoryID.Text))
                    MessageBox.Show("Territory ID and Description cannot be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Checked the errors and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void txtTerritoryID_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTerritoryID.Text) || txtTerritoryID.Text.Length > 20)
            {
                erpTerritoryID.SetError(txtTerritoryID, "The length of the territory ID cannot be more than 20 character and null.");
            }
            else
            {
                erpTerritoryID.Clear();
            }
        }
        private void txtTerritoryDescription_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTerritoryDescription.Text) || txtTerritoryDescription.Text.Length > 50)
            {
                erpTerritoryID.SetError(txtTerritoryDescription, "The length of the territory description cannot be more than 50 character and null.");
            }
            else
            {
                erpTerritoryID.Clear();
            }
        }

        private void btnListTerritories_Click(object sender, EventArgs e)
        {
            ListTheDataonDataGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rdbID.Checked)
            {
                SqlCommand cmd = new SqlCommand("select TerritoryID, TerritoryDescription, RegionDescription, t.RegionID from Territories as t join Region as r on t.RegionID = r.RegionID where TerritoryID like @territoryID", Connection.con);
                cmd.Parameters.AddWithValue("@territoryID", "%" + txtTerritoryIDSearch.Text + "%");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["RegionID"].Visible = false;
            }
            else if (rdbDescription.Checked)
            {
                SqlCommand cmd = new SqlCommand("select TerritoryID, TerritoryDescription, RegionDescription, t.RegionID from Territories as t join Region as r on t.RegionID = r.RegionID where TerritoryDescription like @territoryDescription", Connection.con);
                cmd.Parameters.AddWithValue("@territoryDescription", "%" + txtTerritoryDescriptionSearch.Text + "%");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["RegionID"].Visible = false;
            }
            else if (rdbRegion.Checked)
            {
                SqlCommand cmd = new SqlCommand("select TerritoryID, TerritoryDescription, RegionDescription, t.RegionID from Territories as t join Region as r on t.RegionID = r.RegionID where t.RegionID = @regionID", Connection.con);
                cmd.Parameters.AddWithValue("@regionID", cbbRegionSearch.SelectedValue);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["RegionID"].Visible = false;
            }
        
            else
            {
                MessageBox.Show("One of the search oprions must be selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
