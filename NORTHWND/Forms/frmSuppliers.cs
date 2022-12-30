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
    public partial class frmSuppliers : Form
    {
        public frmSuppliers(frmHomePage frm)
        {
            InitializeComponent();
            _frm = frm;
        }
        SqlConnection con = new SqlConnection("Server=DESKTOP-A10URF2\\SQLEXPRESS;Database=NORTHWND;Trusted_Connection=True;");

        ErrorProvider erpCompanyName = new ErrorProvider(), erpContactName = new ErrorProvider(), erpContactTitle = new ErrorProvider(), erpAddress = new ErrorProvider(), erpCity = new ErrorProvider(), erpRegion = new ErrorProvider(), erpPostalCode = new ErrorProvider(), erpCountry = new ErrorProvider(), erpPhone = new ErrorProvider(), erpFax = new ErrorProvider(), erpSupplierID = new ErrorProvider();

        private frmHomePage _frm;

        void ListTheDataonDataGridView()
        {
            SqlCommand cmd = new SqlCommand("select * from Suppliers", con);
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
                //else if (control is ComboBox)
                //{
                //    ((DateTimePicker)control).Value = DateTime.Now;
                //}
            }
        }
        private void frmSuppliers_Load(object sender, EventArgs e)
        {
            ListTheDataonDataGridView();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSupplierID.Text = dataGridView1.CurrentRow.Cells["SupplierID"].Value.ToString();
            txtCompanyName.Text = dataGridView1.CurrentRow.Cells["CompanyName"].Value.ToString();
            txtContactName.Text = dataGridView1.CurrentRow.Cells["ContactName"].Value.ToString();
            txtContactTitle.Text = dataGridView1.CurrentRow.Cells["ContactTitle"].Value.ToString();
            txtAddress.Text = dataGridView1.CurrentRow.Cells["Address"].Value.ToString();
            txtCity.Text = dataGridView1.CurrentRow.Cells["City"].Value.ToString();
            txtRegion.Text = dataGridView1.CurrentRow.Cells["Region"].Value.ToString();
            txtPostalCode.Text = dataGridView1.CurrentRow.Cells["PostalCode"].Value.ToString();
            txtCountry.Text = dataGridView1.CurrentRow.Cells["Country"].Value.ToString();
            txtPhone.Text = dataGridView1.CurrentRow.Cells["Phone"].Value.ToString();
            txtFax.Text = dataGridView1.CurrentRow.Cells["Fax"].Value.ToString();
            txtHomePage.Text = dataGridView1.CurrentRow.Cells["HomePage"].Value.ToString();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            _frm.Show();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCompanyName.Text) && !(txtCompanyName.Text.Length > 40 || txtContactName.Text.Length > 30 || txtContactTitle.Text.Length > 30 || txtAddress.Text.Length > 60 || txtCity.Text.Length > 15 || txtRegion.Text.Length > 15 || txtPostalCode.Text.Length > 10 || txtCountry.Text.Length > 15 || txtPhone.Text.Length > 24 || txtFax.Text.Length > 24))
            {
                SqlCommand cmd = new SqlCommand("insert into Suppliers (CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax, HomePage) values (@companyName, @contactName, @contactTitle, @address, @city, @region, @postalCode, @Country, @phone, @fax, @homePage)", con);
                cmd.Parameters.AddWithValue("@companyName", txtCompanyName.Text);
                cmd.Parameters.AddWithValue("@contactName", txtContactName.Text);
                cmd.Parameters.AddWithValue("@contactTitle", txtContactTitle.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@city", txtCity.Text);
                cmd.Parameters.AddWithValue("@region", txtRegion.Text);
                cmd.Parameters.AddWithValue("@postalCode", txtPostalCode.Text);
                cmd.Parameters.AddWithValue("@country", txtCountry.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@fax", txtFax.Text);
                cmd.Parameters.AddWithValue("@homePage", txtHomePage.Text);
                if (con.State == ConnectionState.Closed)
                    con.Open();
                try
                {
                    DialogResult dialogResult = MessageBox.Show($"Are You Sure Adding {txtCompanyName.Text}", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"{txtCompanyName.Text} Added into Suppliers Table", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    con.Close();
                    ListTheDataonDataGridView();
                    CleanTheControls();
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtCompanyName.Text))
                {
                    MessageBox.Show("Company Name cannot be null.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Checked the errors and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSupplierID.Text))
            {
                SqlCommand cmd = new SqlCommand("delete from Suppliers where SupplierID = @supplierID", con);
                cmd.Parameters.AddWithValue("@supplierID", int.Parse(txtSupplierID.Text));
                if (con.State == ConnectionState.Closed)
                    con.Open();
                try
                {
                    DialogResult dialogResult = MessageBox.Show($"Are You Sure Deleting {txtCompanyName.Text}", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"{txtCompanyName.Text} Deleted from Suppliers Table", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("The Deleting Has Been Cancelled.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
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
            {
                MessageBox.Show("Company ID cannot be null for deletion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtCompanyName.Text) || string.IsNullOrEmpty(txtSupplierID.Text)) && !(txtCompanyName.Text.Length > 40 || txtContactName.Text.Length > 30 || txtContactTitle.Text.Length > 30 || txtAddress.Text.Length > 60 || txtCity.Text.Length > 15 || txtRegion.Text.Length > 15 || txtPostalCode.Text.Length > 10 || txtCountry.Text.Length > 15 || txtPhone.Text.Length > 24 || txtFax.Text.Length > 24))
            {
                SqlCommand cmd = new SqlCommand("update Suppliers set CompanyName = @companyName, ContactName = @contactName, ContactTitle = @contactTitle, Address = @address, City = @city, Region = @region, PostalCode = @postalCode, Country = @country, Phone = @phone, Fax = @fax, HomePage = @homePage where SupplierID = @supplierID", con);
                cmd.Parameters.AddWithValue("@supplierID", int.Parse(txtSupplierID.Text));
                cmd.Parameters.AddWithValue("@companyName", txtCompanyName.Text);
                cmd.Parameters.AddWithValue("@contactName", txtContactName.Text);
                cmd.Parameters.AddWithValue("@contactTitle", txtContactTitle.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@city", txtCity.Text);
                cmd.Parameters.AddWithValue("@region", txtRegion.Text);
                cmd.Parameters.AddWithValue("@postalCode", txtPostalCode.Text);
                cmd.Parameters.AddWithValue("@country", txtCountry.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@fax", txtFax.Text);
                cmd.Parameters.AddWithValue("@homePage", txtHomePage.Text);
                if (con.State == ConnectionState.Closed)
                    con.Open();
                try
                {
                    DialogResult dialogResult = MessageBox.Show($"Are You Sure Update {txtCompanyName.Text}", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"{txtCompanyName.Text} Updated on Customers Table", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    con.Close();
                    ListTheDataonDataGridView();
                    CleanTheControls();
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtCompanyName.Text) || string.IsNullOrEmpty(txtSupplierID.Text))
                {
                    MessageBox.Show("Company Name and Supplier ID cannot be null.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Checked the errors and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void btnListallSuppliers_Click(object sender, EventArgs e)
        {
            ListTheDataonDataGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rdbSupplierID.Checked)
            {
                int supplierID = 0;
                if (!string.IsNullOrEmpty(txtSupplierIDSearch.Text) && int.TryParse(txtSupplierIDSearch.Text, out supplierID))
                {
                    erpSupplierID.Clear();
                    SqlCommand cmd = new SqlCommand("select * from Suppliers where SupplierID = @supplierID", con);
                    cmd.Parameters.AddWithValue("@supplierID", supplierID);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    erpSupplierID.SetError(txtSupplierIDSearch, "Supplier ID must be integer");
                }
            }
            else if (rdbCompanyName.Checked)
            {
                SqlCommand cmd = new SqlCommand("select * from Suppliers where CompanyName like @companyName", con);
                cmd.Parameters.AddWithValue("@companyName", "%" + txtCompanyNameSearch.Text + "%");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (rdbContactName.Checked)
            {
                SqlCommand cmd = new SqlCommand("select * from Suppliers where ContactName like @contactName", con);
                cmd.Parameters.AddWithValue("@contactName", "%" + txtContactNameSearch.Text + "%");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (rdbContactTitle.Checked)
            {
                SqlCommand cmd = new SqlCommand("select * from Suppliers where ContactTitle like @contactTitle", con);
                cmd.Parameters.AddWithValue("@contactTitle", "%" + txtContactTitleSearch.Text + "%");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (rdbCity.Checked)
            {
                SqlCommand cmd = new SqlCommand("select * from Suppliers where City like @city", con);
                cmd.Parameters.AddWithValue("@city", "%" + txtCitySearch.Text + "%");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (rdbCountry.Checked)
            {
                SqlCommand cmd = new SqlCommand("select * from Suppliers where Country like @country", con);
                cmd.Parameters.AddWithValue("@country", "%" + txtCountrySearch.Text + "%");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (rdbPhone.Checked)
            {
                SqlCommand cmd = new SqlCommand("select * from Suppliers where Phone like @phone", con);
                cmd.Parameters.AddWithValue("@phone", "%" + TxtPhoneSearch.Text + "%");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Please choose one of the search options", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtCompanyName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCompanyName.Text) || txtCompanyName.Text.Length > 40)
            {
                erpCompanyName.SetError(txtCompanyName, "Company Name cannot be null and length must be less than 40 chracters.");
            }
            else
            {
                erpCompanyName.Clear();
            }
        }

        private void txtContactName_TextChanged(object sender, EventArgs e)
        {
            if (txtContactName.Text.Length > 30)
            {
                erpContactName.SetError(txtContactName, "Length of the Contact Name must be less than 30 chracters.");
            }
            else
            {
                erpContactName.Clear();
            }
        }

        private void txtContactTitle_TextChanged(object sender, EventArgs e)
        {
            if (txtContactTitle.Text.Length > 30)
            {
                erpContactTitle.SetError(txtContactTitle, "Length of the Contact Title must be less than 30 chracters.");
            }
            else
            {
                erpContactTitle.Clear();
            }
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            if (txtAddress.Text.Length > 60)
            {
                erpAddress.SetError(txtAddress, "Length of the Address must be less than 60 chracters.");
            }
            else
            {
                erpAddress.Clear();
            }
        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {
            if (txtCity.Text.Length > 15)
            {
                erpCity.SetError(txtCity, "Length of the City must be less than 15 chracters.");
            }
            else
            {
                erpCity.Clear();
            }
        }

        private void txtRegion_TextChanged(object sender, EventArgs e)
        {
            if (txtRegion.Text.Length > 15)
            {
                erpRegion.SetError(txtRegion, "Length of the Region must be less than 15 chracters.");
            }
            else
            {
                erpRegion.Clear();
            }
        }

        private void txtPostalCode_TextChanged(object sender, EventArgs e)
        {
            if (txtPostalCode.Text.Length > 10)
            {
                erpPostalCode.SetError(txtPostalCode, "Length of the Postal Code must be less than 10 chracters.");
            }
            else
            {
                erpPostalCode.Clear();
            }
        }

        private void txtCountry_TextChanged(object sender, EventArgs e)
        {
            if (txtCountry.Text.Length > 15)
            {
                erpCountry.SetError(txtCountry, "Length of the Country must be less than 15 chracters.");
            }
            else
            {
                erpCountry.Clear();
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtPhone.Text.Length > 24)
            {
                erpPhone.SetError(txtPhone, "Length of the Phone must be less than 24 chracters.");
            }
            else
            {
                erpPhone.Clear();
            }
        }

        private void txtFax_TextChanged(object sender, EventArgs e)
        {
            if (txtFax.Text.Length > 24)
            {
                erpFax.SetError(txtFax, "Length of the Fax must be less than 24 chracters.");
            }
            else
            {
                erpFax.Clear();
            }
        }
    }
}
