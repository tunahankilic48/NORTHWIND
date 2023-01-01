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
    public partial class frmCustomers : Form
    {
        // to do Bulunmayan ID girildiğinde uyarı versin
        public frmCustomers(frmHomePage frm)
        {
            InitializeComponent();
            _frm = frm;
        }
        private frmHomePage _frm;

        void ListTheDataonDataGridView()
        {
            SqlCommand cmd = new SqlCommand("select * from Customers", Connection.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void frmCustomers_Load(object sender, EventArgs e)
        {

            ListTheDataonDataGridView();
            ExtensionMethod.CleanTheControls(this);

        }
        private void btnX_Click(object sender, EventArgs e)
        {
            _frm.Show();
            this.Close();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCustomerID.Text = dataGridView1.CurrentRow.Cells["CustomerID"].Value.ToString();
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
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!(txtFax.Text.Length > 24 || txtPhone.Text.Length > 24 || txtCountry.Text.Length > 15 || txtPostalCode.Text.Length > 10 || txtRegion.Text.Length > 15 || txtCity.Text.Length > 15 || txtAddress.Text.Length > 60 || txtContactTitle.Text.Length > 30 || txtContactName.Text.Length > 30 || txtCompanyName.Text.Length > 40 || txtCustomerID.Text.Length != 5 || string.IsNullOrEmpty(txtCustomerID.Text) || string.IsNullOrEmpty(txtCompanyName.Text)))
            {
                SqlCommand cmd = new SqlCommand("insert into Customers (CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax) values (@customerID, @companyName, @contactName, @contactTitle, @address, @city, @region, @postalCode, @Country, @phone, @fax)", Connection.con);
                cmd.Parameters.AddWithValue("@customerID", txtCustomerID.Text.ToUpper());
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
                if (Connection.con.State == ConnectionState.Closed)
                    Connection.con.Open();
                try
                {
                    DialogResult dialogResult = MessageBox.Show($"Are You Sure Adding {txtCustomerID.Text}", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"{txtCustomerID.Text} Added into Customers Table", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (string.IsNullOrEmpty(txtCustomerID.Text) || string.IsNullOrEmpty(txtCompanyName.Text))
                {
                    MessageBox.Show("Customer ID and Company Name couldn't be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Please check the errors and try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtCustomerID.Text)))
            {
                SqlCommand cmd = new SqlCommand("delete from Customers where CustomerID = @customerID", Connection.con);
                cmd.Parameters.AddWithValue("@customerID", txtCustomerID.Text.ToUpper());
                if (Connection.con.State == ConnectionState.Closed)
                    Connection.con.Open();
                try
                {
                    DialogResult dialogResult = MessageBox.Show($"Are You Sure Deleting {txtCustomerID.Text}", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"{txtCustomerID.Text} Deleted from Customers Table", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    Connection.con.Close();
                    ListTheDataonDataGridView();
                    ExtensionMethod.CleanTheControls(this);
                }
            }
            else
            {
                MessageBox.Show("Customer ID is neccessary for deletion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!(txtFax.Text.Length > 24 || txtPhone.Text.Length > 24 || txtCountry.Text.Length > 15 || txtPostalCode.Text.Length > 10 || txtRegion.Text.Length > 15 || txtCity.Text.Length > 15 || txtAddress.Text.Length > 60 || txtContactTitle.Text.Length > 30 || txtContactName.Text.Length > 30 || txtCompanyName.Text.Length > 40 || txtCustomerID.Text.Length != 5 || string.IsNullOrEmpty(txtCustomerID.Text) || string.IsNullOrEmpty(txtCompanyName.Text)))
            {
                SqlCommand cmd = new SqlCommand("update Customers set CompanyName = @companyName, ContactName = @contactName, ContactTitle = @contactTitle, Address = @address, City = @city, Region = @region, PostalCode = @postalCode, Country = @country, Phone = @phone, Fax = @fax where CustomerID = @customerID", Connection.con);
                cmd.Parameters.AddWithValue("@customerID", txtCustomerID.Text.ToUpper());
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
                if (Connection.con.State == ConnectionState.Closed)
                    Connection.con.Open();
                try
                {
                    DialogResult dialogResult = MessageBox.Show($"Are You Sure Update {txtCustomerID.Text}", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"{txtCustomerID.Text} Updated on Customers Table", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("The Update Has Been Cancelled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (string.IsNullOrEmpty(txtCustomerID.Text) || string.IsNullOrEmpty(txtCompanyName.Text))
                {
                    MessageBox.Show("Customer ID and Company Name couldn't be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Please check the errors and try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnListallCustomers_Click(object sender, EventArgs e)
        {
            ListTheDataonDataGridView();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rdbCustomerID.Checked)
            {
                SqlCommand cmd = new SqlCommand("select * from Customers where CustomerID = @customerID", Connection.con);
                cmd.Parameters.AddWithValue("@customerID", txtCustomerIDSearch.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (rdbCompanyName.Checked)
            {
                SqlCommand cmd1 = new SqlCommand("select * from Customers where CompanyName like @companyName", Connection.con);
                cmd1.Parameters.AddWithValue("@companyName", "%" + txtCompanyNameSearch.Text + "%");
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;
            }
            else if (rdbPhone.Checked)
            {
                SqlCommand cmd2 = new SqlCommand("select * from Customers where Phone like @phone", Connection.con);
                cmd2.Parameters.AddWithValue("@phone", "%" + txtPhoneSearch.Text + "%");
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dataGridView1.DataSource = dt2;
            }
            else if (rdbCity.Checked)
            {
                SqlCommand cmd3 = new SqlCommand("select * from Customers where City like @city", Connection.con);
                cmd3.Parameters.AddWithValue("@city", "%" + txtCitySearch.Text + "%");
                SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
                DataTable dt3 = new DataTable();
                da3.Fill(dt3);
                dataGridView1.DataSource = dt3;
            }
            else if (rdbCountry.Checked)
            {
                SqlCommand cmd4 = new SqlCommand("select * from Customers where Country like @country", Connection.con);
                cmd4.Parameters.AddWithValue("@country", "%" + txtCountrySearch.Text + "%");
                SqlDataAdapter da4 = new SqlDataAdapter(cmd4);
                DataTable dt4 = new DataTable();
                da4.Fill(dt4);
                dataGridView1.DataSource = dt4;
            }
            else if (rdbRegion.Checked)
            {
                SqlCommand cmd5 = new SqlCommand("select * from Customers where Region like @region", Connection.con);
                cmd5.Parameters.AddWithValue("@region", "%" + txtRegionSearch.Text + "%");
                SqlDataAdapter da5 = new SqlDataAdapter(cmd5);
                DataTable dt5 = new DataTable();
                da5.Fill(dt5);
                dataGridView1.DataSource = dt5;
            }
            else
            {
                MessageBox.Show("You have to choose one of the search option", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {
            if (txtCustomerID.Text.Length != 5)
            {
                erpCustomerID.SetError(txtCustomerID, "CustomerID must be 5 character");
            }
            else
            {
                erpCustomerID.Clear();
            }
        }
        private void txtCompanyName_TextChanged(object sender, EventArgs e)
        {
            if (txtCompanyName.Text.Length > 40)
            {
                erpCompanyName.SetError(txtCompanyName, "Length of the company name must be less than 40 character");
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
                erpContactName.SetError(txtContactName, "Length of the contact name must be less than 30 character");
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
                erpContactTitle.SetError(txtContactTitle, "Length of the contact title must be less than 30 character");
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
                erpAddress.SetError(txtContactTitle, "Length of the address must be less than 60 character");
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
                erpCity.SetError(txtCity, "Length of the city must be less than 15 character");
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
                erpRegion.SetError(txtRegion, "Length of the region must be less than 15 character");
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
                erpPostalCode.SetError(txtPostalCode, "Length of the postal code must be less than 10 character");
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
                erpCountry.SetError(txtCountry, "Length of the country must be less than 15 character");
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
                erpPhone.SetError(txtPhone, "Length of the phone must be less than 24 character");
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
                erpFax.SetError(txtFax, "Length of the fax must be less than 24 character");
            }
            else
            {
                erpFax.Clear();
            }
        }
    }
}
