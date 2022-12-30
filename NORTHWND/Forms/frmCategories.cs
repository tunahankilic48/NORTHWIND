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
    public partial class frmCategories : Form
    {
        SqlConnection con = new SqlConnection("Server=DESKTOP-A10URF2\\SQLEXPRESS;Database=NORTHWND;Trusted_Connection=True;");
        ErrorProvider erpCategoryID = new ErrorProvider();
        private frmHomePage _frm;

        public frmCategories(frmHomePage frm)
        {
            InitializeComponent();
            _frm = frm;
        }
        void ListTheDataonDataGridView()
        {
            SqlCommand cmd = new SqlCommand("select CategoryID, CategoryName, Description from Categories", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void CleanTheControls()
        {
            foreach (Control control in this.groupBox1.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
            }
        }
        private void frmCategories_Load(object sender, EventArgs e)
        {
            ListTheDataonDataGridView();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCategoryID.Text = dataGridView1.CurrentRow.Cells["CategoryID"].Value.ToString();
            txtCategoryName.Text = dataGridView1.CurrentRow.Cells["CategoryName"].Value.ToString();
            txtDescription.Text = dataGridView1.CurrentRow.Cells["Description"].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (!(txtCategoryName.Text.Length > 15 || string.IsNullOrEmpty(txtCategoryName.Text)))
            {
                SqlCommand cmd = new SqlCommand("insert into Categories (CategoryName, Description) values (@CategoryName, @Description)", con);
                cmd.Parameters.AddWithValue("@CategoryName", txtCategoryName.Text);
                cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                if (con.State == ConnectionState.Closed)
                    con.Open();
                try
                {
                    DialogResult dialogResult = MessageBox.Show($"Are You Sure Adding {txtCategoryName.Text}", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"{txtCategoryName.Text} Added into Categories Table", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("The Adding Has Been Cancelled.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                    ListTheDataonDataGridView();
                    CleanTheControls();
                }
            }
            else
                MessageBox.Show($"The Lenght of the Company Nume must be less than 15 characters and cannot be Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCategoryID.Text))
            {
                SqlCommand cmd = new SqlCommand("delete from Categories where CategoryID = @categoryID", con);
                cmd.Parameters.AddWithValue("@categoryID", int.Parse(txtCategoryID.Text));
                if (con.State == ConnectionState.Closed)
                    con.Open();
                try
                {
                    DialogResult dialogResult = MessageBox.Show($"Are You Sure Deleting {txtCategoryName.Text}", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"{txtCategoryName.Text} Deleted from Categories Table", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("The Deletion Has Been Cancelled.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                    ListTheDataonDataGridView();
                    CleanTheControls();
                }
            }
            else
                MessageBox.Show("Category ID is neccessary for deletion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!(txtCategoryName.Text.Length > 15 || string.IsNullOrEmpty(txtCategoryName.Text)) && !string.IsNullOrEmpty(txtCategoryID.Text))
            {
                SqlCommand cmd = new SqlCommand("update Categories set CategoryName = @categoryName, Description = @description where CategoryID = @categoryID", con);
                cmd.Parameters.AddWithValue("@categoryID", int.Parse(txtCategoryID.Text));
                cmd.Parameters.AddWithValue("@CategoryName", txtCategoryName.Text);
                cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                if (con.State == ConnectionState.Closed)
                    con.Open();
                try
                {
                    DialogResult dialogResult = MessageBox.Show($"Are You Sure Updating {txtCategoryName.Text}", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"{txtCategoryName.Text} Updated on Categories Table", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("The Update Has Been Cancelled.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                    ListTheDataonDataGridView();
                    CleanTheControls();
                }
            }
            else
                MessageBox.Show($"The Lenght of the Company Name must be less than 15 characters and CategoryID and Company Name cannot be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnX_Click(object sender, EventArgs e)
        {
            _frm.Show();
            this.Close();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rdbID.Checked)
            {
                if (int.TryParse(txtCategoryIDSearch.Text, out int categoryID))
                {
                    erpCategoryID.Clear();
                    SqlCommand cmd = new SqlCommand("select CategoryID, CategoryName, Description from Categories where CategoryID = @categoryID", con);
                    cmd.Parameters.AddWithValue("@categoryID", categoryID);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    erpCategoryID.SetError(txtCategoryIDSearch, "The characters must be numeric only");
                }
            }
            else if (rdbName.Checked)
            {
                SqlCommand cmd1 = new SqlCommand("select CategoryID, CategoryName, Description from Categories where CategoryName like @categoryName ", con);
                cmd1.Parameters.AddWithValue("@categoryName", "%" + txtCategoryNameSearch.Text + "%");
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;
            }
            else if (rdbDescription.Checked)
            {
                SqlCommand cmd2 = new SqlCommand("select CategoryID, CategoryName, Description from Categories where Description like @description ", con);
                cmd2.Parameters.AddWithValue("@description", "%" + txtDescriptionSearch.Text + "%");
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dataGridView1.DataSource = dt2;
            }
            else
            {
                MessageBox.Show("You should choose one of the search option.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ListTheDataonDataGridView();
        }
    }
}
