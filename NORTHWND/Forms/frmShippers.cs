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
    public partial class frmShippers : Form
    {
        public frmShippers(frmHomePage frm)
        {
            InitializeComponent();
            _frm = frm;
        }

        ErrorProvider erpSupplierID = new ErrorProvider(), erpCompanyName = new ErrorProvider(), erpPhone = new ErrorProvider();

        private frmHomePage _frm;

        void ListTheDataonDataGridView()
        {
            SqlCommand cmd = new SqlCommand("select * from Shippers", Connection.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void frmShippers_Load(object sender, EventArgs e)
        {
            ListTheDataonDataGridView();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtShipperID.Text = dataGridView1.CurrentRow.Cells["ShipperID"].Value.ToString();
            txtCompanyName.Text = dataGridView1.CurrentRow.Cells["CompanyName"].Value.ToString();
            txtPhone.Text = dataGridView1.CurrentRow.Cells["Phone"].Value.ToString();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            _frm.Show();
            this.Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!(txtPhone.Text.Length > 24) && !(txtCompanyName.Text.Length > 40) && !string.IsNullOrEmpty(txtCompanyName.Text))
            {

                SqlCommand cmd = new SqlCommand("insert into Shippers (CompanyName, Phone) values (@companyName, @phone)", Connection.con);
                cmd.Parameters.AddWithValue("@companyName", txtCompanyName.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                if (Connection.con.State == ConnectionState.Closed)
                    Connection.con.Open();
                try
                {
                    DialogResult dialogResult = MessageBox.Show($"Are You Sure Adding {txtCompanyName.Text}", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"{txtCompanyName.Text} Added into Shippers Table", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (string.IsNullOrEmpty(txtCompanyName.Text))
                {
                    MessageBox.Show("Company Name cannot be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Checked the errors and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtShipperID.Text))
            {
                SqlCommand cmd = new SqlCommand("delete from Shippers where ShipperID = @shipperID", Connection.con);
                cmd.Parameters.AddWithValue("@shipperID", int.Parse(txtShipperID.Text));
                if (Connection.con.State == ConnectionState.Closed)
                    Connection.con.Open();
                try
                {
                    DialogResult dialogResult = MessageBox.Show($"Are You Sure Delete {txtCompanyName.Text}", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"{txtCompanyName.Text} Deleted from Shippers Table", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                MessageBox.Show("Shipper ID cannot be null for deletion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!(txtPhone.Text.Length > 24) && !(txtCompanyName.Text.Length > 40) && !string.IsNullOrEmpty(txtCompanyName.Text) && !string.IsNullOrEmpty(txtShipperID.Text))
            {
                SqlCommand cmd = new SqlCommand("update Shippers set CompanyName = @companyName, Phone = @phone where ShipperID = @shipperID", Connection.con);
                cmd.Parameters.AddWithValue("@shipperID", int.Parse(txtShipperID.Text));
                cmd.Parameters.AddWithValue("@companyName", txtCompanyName.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                if (Connection.con.State == ConnectionState.Closed)
                    Connection.con.Open();
                try
                {
                    DialogResult dialogResult = MessageBox.Show($"Are You Sure Update {txtCompanyName.Text}", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"{txtCompanyName.Text} Updated on Shippers Table", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    ExtensionMethod.CleanTheControls(this);
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtCompanyName.Text) || string.IsNullOrEmpty(txtShipperID.Text))
                {
                    MessageBox.Show("Company Name and Shipper ID cannot be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Checked the errors and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtPhone.Text.Length > 24)
            {
                erpPhone.SetError(txtPhone, "The lenght of Company Name must be less than 24 characters");
            }
            else
            {
                erpPhone.Clear();
            }
        }

        private void txtCompanyName_TextChanged(object sender, EventArgs e)
        {
            if (txtCompanyName.Text.Length > 40)
            {
                erpCompanyName.SetError(txtCompanyName, "The lenght of Company Name must be less than 40 characters");
            }
            else
            {
                erpCompanyName.Clear();
            }
        }
    }
}
