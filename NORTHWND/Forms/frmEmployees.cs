using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NORTHWND.Forms
{
    public partial class frmEmployees : Form
    {
        public frmEmployees(frmHomePage frm)
        {
            InitializeComponent();
            _frm = frm;
        }

        ErrorProvider erpFirstName = new ErrorProvider(), erpLastName = new ErrorProvider(), erpTitle = new ErrorProvider(), erpTitleOfCourtesy = new ErrorProvider(), erpBirthDate = new ErrorProvider(), erpHireDate = new ErrorProvider(), erpAddress = new ErrorProvider(), erpCity = new ErrorProvider(), erpRegion = new ErrorProvider(), erpPostalCode = new ErrorProvider(), erpCountry = new ErrorProvider(), erpHomePhone = new ErrorProvider(), erpExtension = new ErrorProvider(), erpNotes = new ErrorProvider(), erpEmployeeID = new ErrorProvider();

        private frmHomePage _frm;

        void ListTheDataonDataGridView()
        {
            SqlCommand cmd = new SqlCommand("select e.EmployeeID, e.FirstName, e.LastName, e.Title, e.TitleOfCourtesy, e.BirthDate, e.HireDate, e.Address, e.City, e.Region, e.PostalCode, e.Country, e.HomePhone, e.Extension, e.Notes, (em.FirstName + ' ' + em.LastName) as ReportsTo, e.ReportsTo as Reportssto from Employees as e left join Employees as em on e.ReportsTo = em.EmployeeID", Connection.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["ReportssTo"].Visible = false;
        }
        void FillcbbReportsTo()
        {
            SqlCommand cmd = new SqlCommand("select EmployeeID, (FirstName + ' ' + LastName) as EmployeeName from Employees order by FirstName", Connection.con);
            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            cbbReportsTo.ValueMember = "EmployeeID";
            cbbReportsTo.DisplayMember = "EmployeeName";
            cbbReportsTo.DataSource = dt;
        }
        void FillcbbReportstoSearch()
        {
            SqlCommand cmd = new SqlCommand("select EmployeeID, (FirstName + ' ' + LastName) as EmployeeName from Employees order by FirstName", Connection.con);
            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            cbbReportstoSearch.ValueMember = "EmployeeID";
            cbbReportstoSearch.DisplayMember = "EmployeeName";
            cbbReportstoSearch.DataSource = dt;
        }
        private void frmEmployees_Load(object sender, EventArgs e)
        {
            ListTheDataonDataGridView();
            FillcbbReportsTo();
            FillcbbReportstoSearch();
            ExtensionMethod.CleanTheControls(this);
        }
        private void btnX_Click(object sender, EventArgs e)
        {
            _frm.Show();
            this.Close();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEmployeeID.Text = dataGridView1.CurrentRow.Cells["EmployeeID"].Value.ToString();
            txtFirstName.Text = dataGridView1.CurrentRow.Cells["FirstName"].Value.ToString();
            txtLastName.Text = dataGridView1.CurrentRow.Cells["LastName"].Value.ToString();
            txtTitle.Text = dataGridView1.CurrentRow.Cells["Title"].Value.ToString();
            txtTitleofCourtesy.Text = dataGridView1.CurrentRow.Cells["TitleOfCourtesy"].Value.ToString();
            txtAddress.Text = dataGridView1.CurrentRow.Cells["Address"].Value.ToString();
            txtCity.Text = dataGridView1.CurrentRow.Cells["City"].Value.ToString();
            txtRegion.Text = dataGridView1.CurrentRow.Cells["Region"].Value.ToString();
            txtPostalCode.Text = dataGridView1.CurrentRow.Cells["PostalCode"].Value.ToString();
            txtCountry.Text = dataGridView1.CurrentRow.Cells["Country"].Value.ToString();
            txtHomePhone.Text = dataGridView1.CurrentRow.Cells["HomePhone"].Value.ToString();
            txtExtension.Text = dataGridView1.CurrentRow.Cells["Extension"].Value.ToString();
            txtNotes.Text = dataGridView1.CurrentRow.Cells["Notes"].Value.ToString();

            if (!string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells["BirthDate"].Value.ToString()))
                dtpBirthDate.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells["BirthDate"].Value.ToString());
            else
                dtpBirthDate.Value = DateTime.Now;

            if (!string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells["HireDate"].Value.ToString()))
                dtpHireDate.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells["HireDate"].Value.ToString());
            else
                dtpHireDate.Value = DateTime.Now;

            if (!string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells["ReportssTo"].Value.ToString()))
                cbbReportsTo.SelectedValue = int.Parse(dataGridView1.CurrentRow.Cells["ReportssTo"].Value.ToString());
            else
                cbbReportsTo.SelectedValue = -1;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!(dtpBirthDate.Value > DateTime.Now || dtpHireDate.Value > DateTime.Now || txtAddress.Text.Length > 60 || txtCity.Text.Length > 15 || txtRegion.Text.Length > 15 || txtPostalCode.Text.Length > 10 || txtCountry.Text.Length > 15 || txtHomePhone.Text.Length > 24 || txtExtension.Text.Length > 4 || txtTitleofCourtesy.Text.Length > 25 || txtTitle.Text.Length > 30 || txtLastName.Text.Length > 20 || txtFirstName.Text.Length > 10 || string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text)))
            {
                SqlCommand cmd = new SqlCommand("insert into Employees (FirstName, LastName, Title, TitleOfCourtesy, BirthDate, HireDate, Address, City, Region, PostalCode, Country, HomePhone, Extension, Notes, ReportsTo) values (@FirstName, @LastName, @Title, @TitleOfCourtesy, @BirthDate, @HireDate, @Address, @City, @Region, @PostalCode, @Country, @HomePhone, @Extension, @Notes, @ReportsTo)", Connection.con);
                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
                cmd.Parameters.AddWithValue("@TitleOfCourtesy", txtTitleofCourtesy.Text);
                cmd.Parameters.AddWithValue("@BirthDate", DateTime.Parse(dtpBirthDate.Value.ToString()));
                cmd.Parameters.AddWithValue("@HireDate", DateTime.Parse(dtpHireDate.Value.ToString()));
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@City", txtCity.Text);
                cmd.Parameters.AddWithValue("@Region", txtRegion.Text);
                cmd.Parameters.AddWithValue("@PostalCode", txtPostalCode.Text);
                cmd.Parameters.AddWithValue("@Country", txtCountry.Text);
                cmd.Parameters.AddWithValue("@HomePhone", txtHomePhone.Text);
                cmd.Parameters.AddWithValue("@Extension", txtExtension.Text);
                cmd.Parameters.AddWithValue("@Notes", txtNotes.Text);
                cmd.Parameters.AddWithValue("@ReportsTo", cbbReportsTo.SelectedValue);
                if (Connection.con.State == ConnectionState.Closed)
                    Connection.con.Open();
                try
                {
                    DialogResult dialogResult = MessageBox.Show($"Are You Sure Adding {txtFirstName.Text} {txtLastName.Text}", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"{txtFirstName.Text} {txtLastName.Text} Added into Employees Table", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text))
                {
                    MessageBox.Show("First Name and Last Name couldn't be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Please check the errors and try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtEmployeeID.Text)))
            {
                SqlCommand cmd = new SqlCommand("delete from Employees where EmployeeID = @employeeID", Connection.con);
                cmd.Parameters.AddWithValue("@employeeID", int.Parse(txtEmployeeID.Text));
                if (Connection.con.State == ConnectionState.Closed)
                    Connection.con.Open();
                try
                {
                    DialogResult dialogResult = MessageBox.Show($"Are You Sure Deleting {txtFirstName.Text} {txtLastName.Text}", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"{txtFirstName.Text} {txtLastName.Text} Delete from Employees Table", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("The Delete Has Been Cancelled.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
                MessageBox.Show("Employee ID is neccessary for deletion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!(dtpBirthDate.Value > DateTime.Now || dtpHireDate.Value > DateTime.Now || txtAddress.Text.Length > 60 || txtCity.Text.Length > 15 || txtRegion.Text.Length > 15 || txtPostalCode.Text.Length > 10 || txtCountry.Text.Length > 15 || txtHomePhone.Text.Length > 24 || txtExtension.Text.Length > 4 || txtTitleofCourtesy.Text.Length > 25 || txtTitle.Text.Length > 30 || txtLastName.Text.Length > 20 || txtFirstName.Text.Length > 10 || string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text)) && string.IsNullOrEmpty(txtEmployeeID.Text))
            {
                SqlCommand cmd = new SqlCommand("update Employees set FirstName = @FirstName, LastName = @LastName, Title = @Title, TitleOfCourtesy = @TitleOfCourtesy, BirthDate = @BirthDate, HireDate = @HireDate, Address = @Address, City = @City, Region = @Region, PostalCode = @PostalCode, Country = @Country, HomePhone = @HomePhone, Extension = @Extension, Notes = @Notes, ReportsTo = @ReportsTo where EmployeeID = @employeeID", Connection.con);
                cmd.Parameters.AddWithValue("@employeeID", int.Parse(txtEmployeeID.Text));
                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
                cmd.Parameters.AddWithValue("@TitleOfCourtesy", txtTitleofCourtesy.Text);
                cmd.Parameters.AddWithValue("@BirthDate", DateTime.Parse(dtpBirthDate.Value.ToString()));
                cmd.Parameters.AddWithValue("@HireDate", DateTime.Parse(dtpHireDate.Value.ToString()));
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@City", txtCity.Text);
                cmd.Parameters.AddWithValue("@Region", txtRegion.Text);
                cmd.Parameters.AddWithValue("@PostalCode", txtPostalCode.Text);
                cmd.Parameters.AddWithValue("@Country", txtCountry.Text);
                cmd.Parameters.AddWithValue("@HomePhone", txtHomePhone.Text);
                cmd.Parameters.AddWithValue("@Extension", txtExtension.Text);
                cmd.Parameters.AddWithValue("@Notes", txtNotes.Text);
                cmd.Parameters.AddWithValue("@ReportsTo", cbbReportsTo.SelectedValue);
                if (Connection.con.State == ConnectionState.Closed)
                    Connection.con.Open();
                try
                {
                    DialogResult dialogResult = MessageBox.Show($"Are You Sure Update {txtFirstName.Text} {txtLastName.Text}", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"{txtFirstName.Text} {txtLastName.Text} Updated on Customers Table", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text) || string.IsNullOrEmpty(txtEmployeeID.Text))
                {
                    MessageBox.Show("EmployeeID, First Name and Last Name couldn't be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Please check the errors and try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rdbEmployeeID.Checked)
            {
                if (int.TryParse(txtEmployeeIDSearch.Text, out int employeeID))
                {
                    erpEmployeeID.Clear();
                    SqlCommand cmd = new SqlCommand("select e.EmployeeID, e.FirstName, e.LastName, e.Title, e.TitleOfCourtesy, e.BirthDate, e.HireDate, e.Address, e.City, e.Region, e.PostalCode, e.Country, e.HomePhone, e.Extension, e.Notes, (em.FirstName + ' ' + em.LastName) as ReportsTo, e.ReportsTo as Reportssto from Employees as e left join Employees as em on e.ReportsTo = em.EmployeeID where e.EmployeeID = @employeeID", Connection.con);
                    cmd.Parameters.AddWithValue("@employeeID", employeeID);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["ReportssTo"].Visible = false;
                }
                else
                {
                    erpEmployeeID.SetError(txtEmployeeIDSearch, "Only numeric caracters can be accepted");
                }
            }
            else if (rdbFirstName.Checked)
            {
                SqlCommand cmd1 = new SqlCommand("select e.EmployeeID, e.FirstName, e.LastName, e.Title, e.TitleOfCourtesy, e.BirthDate, e.HireDate, e.Address, e.City, e.Region, e.PostalCode, e.Country, e.HomePhone, e.Extension, e.Notes, (em.FirstName + ' ' + em.LastName) as ReportsTo, e.ReportsTo as Reportssto from Employees as e left join Employees as em on e.ReportsTo = em.EmployeeID where e.FirstName like @firstName", Connection.con);
                cmd1.Parameters.AddWithValue("@firstName", "%" + txtFirstNameSearch.Text + "%");
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;
                dataGridView1.Columns["ReportssTo"].Visible = false;
            }
            else if (rdbLastname.Checked)
            {
                SqlCommand cmd2 = new SqlCommand("select e.EmployeeID, e.FirstName, e.LastName, e.Title, e.TitleOfCourtesy, e.BirthDate, e.HireDate, e.Address, e.City, e.Region, e.PostalCode, e.Country, e.HomePhone, e.Extension, e.Notes, (em.FirstName + ' ' + em.LastName) as ReportsTo, e.ReportsTo as Reportssto from Employees as e left join Employees as em on e.ReportsTo = em.EmployeeID where e.LastName like @lastName", Connection.con);
                cmd2.Parameters.AddWithValue("@lastNAme", "%" + txtLastNameSearch.Text + "%");
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dataGridView1.DataSource = dt2;
                dataGridView1.Columns["ReportssTo"].Visible = false;
            }
            else if (rdbTitle.Checked)
            {
                SqlCommand cmd3 = new SqlCommand("select e.EmployeeID, e.FirstName, e.LastName, e.Title, e.TitleOfCourtesy, e.BirthDate, e.HireDate, e.Address, e.City, e.Region, e.PostalCode, e.Country, e.HomePhone, e.Extension, e.Notes, (em.FirstName + ' ' + em.LastName) as ReportsTo, e.ReportsTo as Reportssto from Employees as e left join Employees as em on e.ReportsTo = em.EmployeeID where e.Title like @title", Connection.con);
                cmd3.Parameters.AddWithValue("@title", "%" + txtTitleSearch.Text + "%");
                SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
                DataTable dt3 = new DataTable();
                da3.Fill(dt3);
                dataGridView1.DataSource = dt3;
                dataGridView1.Columns["ReportssTo"].Visible = false;
            }
            else if (rdbBirthDate.Checked)
            {
                SqlCommand cmd4 = new SqlCommand("select e.EmployeeID, e.FirstName, e.LastName, e.Title, e.TitleOfCourtesy, e.BirthDate, e.HireDate, e.Address, e.City, e.Region, e.PostalCode, e.Country, e.HomePhone, e.Extension, e.Notes, (em.FirstName + ' ' + em.LastName) as ReportsTo, e.ReportsTo as Reportssto from Employees as e left join Employees as em on e.ReportsTo = em.EmployeeID where e.BirthDate >= @birthDate", Connection.con);
                cmd4.Parameters.AddWithValue("@birthDate", DateTime.Parse(dtpBirthDateSearch.Value.ToString()));
                SqlDataAdapter da4 = new SqlDataAdapter(cmd4);
                DataTable dt4 = new DataTable();
                da4.Fill(dt4);
                dataGridView1.DataSource = dt4;
                dataGridView1.Columns["ReportssTo"].Visible = false;
            }
            else if (rdbHireDate.Checked)
            {
                SqlCommand cmd5 = new SqlCommand("select e.EmployeeID, e.FirstName, e.LastName, e.Title, e.TitleOfCourtesy, e.BirthDate, e.HireDate, e.Address, e.City, e.Region, e.PostalCode, e.Country, e.HomePhone, e.Extension, e.Notes, (em.FirstName + ' ' + em.LastName) as ReportsTo, e.ReportsTo as Reportssto from Employees as e left join Employees as em on e.ReportsTo = em.EmployeeID where e.HireDate >= @hireDate", Connection.con);
                cmd5.Parameters.AddWithValue("@hireDate", DateTime.Parse(dtpHireDateSearch.Value.ToString()));
                SqlDataAdapter da5 = new SqlDataAdapter(cmd5);
                DataTable dt5 = new DataTable();
                da5.Fill(dt5);
                dataGridView1.DataSource = dt5;
                dataGridView1.Columns["ReportssTo"].Visible = false;
            }
            else if (rdbReportsto.Checked)
            {
                SqlCommand cmd6 = new SqlCommand("select e.EmployeeID, e.FirstName, e.LastName, e.Title, e.TitleOfCourtesy, e.BirthDate, e.HireDate, e.Address, e.City, e.Region, e.PostalCode, e.Country, e.HomePhone, e.Extension, e.Notes, (em.FirstName + ' ' + em.LastName) as ReportsTo, e.ReportsTo as Reportssto from Employees as e left join Employees as em on e.ReportsTo = em.EmployeeID where e.ReportsTo = @reportsto", Connection.con);
                cmd6.Parameters.AddWithValue("@reportsto", cbbReportstoSearch.SelectedValue);
                SqlDataAdapter da6 = new SqlDataAdapter(cmd6);
                DataTable dt6 = new DataTable();
                da6.Fill(dt6);
                dataGridView1.DataSource = dt6;
                dataGridView1.Columns["ReportssTo"].Visible = false;
            }
            else if (rdbCountry.Checked)
            {
                SqlCommand cmd7 = new SqlCommand("select e.EmployeeID, e.FirstName, e.LastName, e.Title, e.TitleOfCourtesy, e.BirthDate, e.HireDate, e.Address, e.City, e.Region, e.PostalCode, e.Country, e.HomePhone, e.Extension, e.Notes, (em.FirstName + ' ' + em.LastName) as ReportsTo, e.ReportsTo as Reportssto from Employees as e left join Employees as em on e.ReportsTo = em.EmployeeID where e.Country like @country", Connection.con);
                cmd7.Parameters.AddWithValue("@country", "%" + txtCountrySearch.Text + "%");
                SqlDataAdapter da7 = new SqlDataAdapter(cmd7);
                DataTable dt7 = new DataTable();
                da7.Fill(dt7);
                dataGridView1.DataSource = dt7;
                dataGridView1.Columns["ReportssTo"].Visible = false;
            }
            else if (rdbNotes.Checked)
            {
                SqlCommand cmd8 = new SqlCommand("select e.EmployeeID, e.FirstName, e.LastName, e.Title, e.TitleOfCourtesy, e.BirthDate, e.HireDate, e.Address, e.City, e.Region, e.PostalCode, e.Country, e.HomePhone, e.Extension, e.Notes, (em.FirstName + ' ' + em.LastName) as ReportsTo, e.ReportsTo as Reportssto from Employees as e left join Employees as em on e.ReportsTo = em.EmployeeID where e.Notes like @notes", Connection.con);
                cmd8.Parameters.AddWithValue("@notes", "%" + txtNotes.Text + "%");
                SqlDataAdapter da8 = new SqlDataAdapter(cmd8);
                DataTable dt8 = new DataTable();
                da8.Fill(dt8);
                dataGridView1.DataSource = dt8;
                dataGridView1.Columns["ReportssTo"].Visible = false;
            }
            else
            {
                MessageBox.Show("You should choose one of the search options", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnListallEmployees_Click(object sender, EventArgs e)
        {
            ListTheDataonDataGridView();
        }

        private void dtpBirthDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpBirthDate.Value > DateTime.Now)
                erpBirthDate.SetError(dtpBirthDate, "The choosen date cannot be greater than today");
            else
                erpBirthDate.Clear();
        }

        private void dtpHireDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpHireDate.Value > DateTime.Now)
                erpHireDate.SetError(dtpHireDate, "The choosen date cannot be greater than today");
            else
                erpHireDate.Clear();
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            if (txtAddress.Text.Length > 60)
                erpAddress.SetError(txtAddress, "The lenght of the first name must be less than 60 characters");
            else
                erpAddress.Clear();
        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {
            if (txtCity.Text.Length > 15)
                erpCity.SetError(txtCity, "The lenght of the first name must be less than 15 characters");
            else
                erpCity.Clear();
        }

        private void txtRegion_TextChanged(object sender, EventArgs e)
        {
            if (txtRegion.Text.Length > 15)
                erpRegion.SetError(txtRegion, "The lenght of the first name must be less than 15 characters");
            else
                erpRegion.Clear();
        }

        private void txtPostalCode_TextChanged(object sender, EventArgs e)
        {
            if (txtPostalCode.Text.Length > 10)
                erpPostalCode.SetError(txtPostalCode, "The lenght of the first name must be less than 10 characters");
            else
                erpPostalCode.Clear();
        }

        private void txtCountry_TextChanged(object sender, EventArgs e)
        {
            if (txtCountry.Text.Length > 15)
                erpCountry.SetError(txtCountry, "The lenght of the first name must be less than 15 characters");
            else
                erpCountry.Clear();
        }

        private void txtHomePhone_TextChanged(object sender, EventArgs e)
        {
            if (txtHomePhone.Text.Length > 24)
                erpHomePhone.SetError(txtHomePhone, "The lenght of the first name must be less than 24 characters");
            else
                erpHomePhone.Clear();
        }

        private void txtExtension_TextChanged(object sender, EventArgs e)
        {
            if (txtExtension.Text.Length > 4)
                erpExtension.SetError(txtExtension, "The lenght of the first name must be less than 4 characters");
            else
                erpExtension.Clear();
        }

        private void txtTitleofCourtesy_TextChanged(object sender, EventArgs e)
        {
            if (txtTitleofCourtesy.Text.Length > 25)
                erpTitleOfCourtesy.SetError(txtTitleofCourtesy, "The lenght of the first name must be less than 25 characters");
            else
                erpTitleOfCourtesy.Clear();
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            if (txtTitle.Text.Length > 30)
                erpTitle.SetError(txtTitle, "The lenght of the first name must be less than 30 characters");
            else
                erpTitle.Clear();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if (txtLastName.Text.Length > 20)
                erpLastName.SetError(txtLastName, "The lenght of the first name must be less than 20 characters");
            else
                erpLastName.Clear();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Length > 10)
                erpFirstName.SetError(txtFirstName, "The lenght of the first name must be less than 10 characters");
            else
                erpFirstName.Clear();
        }
    }
}
