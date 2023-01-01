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
    public partial class frmRegions : Form
    {

        public frmRegions(frmHomePage frm)
        {
            InitializeComponent();
            _frm = frm;
        }

        ErrorProvider erpRegiınDescription = new ErrorProvider(), erpRegionID = new ErrorProvider();

        private frmHomePage _frm;
        void ListTheDataonDataGridView()
        {
            SqlCommand cmd = new SqlCommand("select * from Region", Connection.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void frmRegions_Load(object sender, EventArgs e)
        {
            ListTheDataonDataGridView();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            _frm.Show();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int regionID = 0;
            if (!(string.IsNullOrEmpty(txtRegionID.Text) || string.IsNullOrEmpty(txtRegionDescription.Text)) && (int.TryParse(txtRegionID.Text, out regionID) || !(regionID <= 0)))
            {

                SqlCommand cmd = new SqlCommand("insert into Region (RegionID, RegionDescription) values (@regionID, @regionDescription)", Connection.con);
                cmd.Parameters.AddWithValue("@regionID", int.Parse(txtRegionID.Text));
                cmd.Parameters.AddWithValue("@regionDescription", txtRegionDescription.Text);
                if (Connection.con.State == ConnectionState.Closed)
                    Connection.con.Open();
                try
                {
                    DialogResult dialogResult = MessageBox.Show($"Are You Sure Adding {txtRegionDescription.Text}", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"{txtRegionDescription.Text} Added into Region Table", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    ExtensionMethod.CleanTheControls(this);
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtRegionID.Text) || string.IsNullOrEmpty(txtRegionDescription.Text))
                {
                    MessageBox.Show("Region ID and region description cannot be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Checked the errors then try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtRegionID.Text)))
            {
                SqlCommand cmd = new SqlCommand("delete from Region where RegionID = @regionID", Connection.con);
                cmd.Parameters.AddWithValue("@regionID", int.Parse(txtRegionID.Text));
                if (Connection.con.State == ConnectionState.Closed)
                    Connection.con.Open();
                try
                {
                    DialogResult dialogResult = MessageBox.Show($"Are You Sure Delete {txtRegionDescription.Text}", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"{txtRegionDescription.Text} Deleted from Region Table", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    ExtensionMethod.CleanTheControls(this);
                }
            }

            else
            {
                MessageBox.Show("Region ID couldn't be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int regionID = 0;
            if (!(string.IsNullOrEmpty(txtRegionID.Text) || string.IsNullOrEmpty(txtRegionDescription.Text)) && (int.TryParse(txtRegionID.Text, out regionID) || !(regionID <= 0)))
            {

                SqlCommand cmd = new SqlCommand("update Region set RegionDescription = @regionDescription where RegionID = @regionID", Connection.con);
                cmd.Parameters.AddWithValue("@regionID", int.Parse(txtRegionID.Text));
                cmd.Parameters.AddWithValue("@regionDescription", txtRegionDescription.Text);
                if (Connection.con.State == ConnectionState.Closed)
                    Connection.con.Open();
                try
                {
                    DialogResult dialogResult = MessageBox.Show($"Are You Sure Update {txtRegionDescription.Text}", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"{txtRegionDescription.Text} Update on Region Table", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("The Uptade Has Been Cancelled.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
                    ExtensionMethod.CleanTheControls(this);
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtRegionID.Text) || string.IsNullOrEmpty(txtRegionDescription.Text))
                {
                    MessageBox.Show("Region ID and region description cannot be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Checked the errors then try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRegionID.Text = dataGridView1.CurrentRow.Cells["RegionID"].Value.ToString();
            txtRegionDescription.Text = dataGridView1.CurrentRow.Cells["RegionDescription"].Value.ToString();
        }
        private void txtRegionDescription_TextChanged(object sender, EventArgs e)
        {
            if (txtRegionDescription.Text.Length > 50)
            {
                erpRegiınDescription.SetError(txtRegionDescription, "Maximum 50 characters can be written");
            }
            else
            {
                erpRegiınDescription.Clear();
            }
        }

        private void txtRegionID_TextChanged(object sender, EventArgs e)
        {
            int regionID;
            if (string.IsNullOrEmpty(txtRegionID.Text) || !(int.TryParse(txtRegionID.Text, out regionID)) || regionID <= 0)
            {
                erpRegionID.SetError(txtRegionID, "Only positive integers can be accepted");
            }
            else
            {
                erpRegionID.Clear();
            }
        }
    }
}
