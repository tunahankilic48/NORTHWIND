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
    public partial class frmOrders : Form
    {
        public frmOrders(frmHomePage frm)
        {
            InitializeComponent();
            _frm = frm;
        }

        ErrorProvider erpOrderDate = new ErrorProvider(), erpRequiredDate = new ErrorProvider(), erpShippedDate = new ErrorProvider(), erpFreight = new ErrorProvider(), erpShipCity = new ErrorProvider(), erpShipCountry = new ErrorProvider(), erpShipRegion = new ErrorProvider(), erpShipPostalCode = new ErrorProvider(), erpShipName = new ErrorProvider(), erpShipAddress = new ErrorProvider(), erpOrderID = new ErrorProvider();

        private frmHomePage _frm;

        void ListTheDataToDataGridView()
        {
            SqlCommand cmd = new SqlCommand("Select OrderID, c.CompanyName, (FirstName + ' ' + LastName) as Employee, OrderDate, RequiredDate, ShippedDate, s.CompanyName, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry, o.CustomerID, o.EmployeeID, o.ShipVia from Orders as o join Customers as c on o.CustomerID = c.CustomerID join Employees as e on o.EmployeeID = e.EmployeeID join Shippers as s on s.ShipperID = o.ShipVia", Connection.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["CustomerID"].Visible = false;
            dataGridView1.Columns["EmployeeID"].Visible = false;
            dataGridView1.Columns["ShipVia"].Visible = false;
        }
        void FillcbbCustomer()
        {
            SqlCommand cmd = new SqlCommand("select CustomerID, CompanyName from Customers order by CompanyName", Connection.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbCustomer.ValueMember = "CustomerID";
            cbbCustomer.DisplayMember = "CompanyName";
            cbbCustomer.DataSource = dt;
        }
        void FillcbbCustomerSearch()
        {
            SqlCommand cmd = new SqlCommand("select CustomerID, CompanyName from Customers order by CompanyName", Connection.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbCustomerSearch.ValueMember = "CustomerID";
            cbbCustomerSearch.DisplayMember = "CompanyName";
            cbbCustomerSearch.DataSource = dt;
        }
        void FillcbbEmployee()
        {
            SqlCommand cmd = new SqlCommand("select EmployeeID, (FirstName + ' ' + LastName) as Employee from Employees order by FirstName", Connection.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbEmployee.ValueMember = "EmployeeID";
            cbbEmployee.DisplayMember = "Employee";
            cbbEmployee.DataSource = dt;
        }
        void FillcbbEmployeeSearch()
        {
            SqlCommand cmd = new SqlCommand("select EmployeeID, (FirstName + ' ' + LastName) as Employee from Employees order by FirstName", Connection.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbEmployeeSearch.ValueMember = "EmployeeID";
            cbbEmployeeSearch.DisplayMember = "Employee";
            cbbEmployeeSearch.DataSource = dt;
        }
        void FillcbbShipVia()
        {
            SqlCommand cmd = new SqlCommand("select ShipperID, CompanyName from Shippers order by CompanyName", Connection.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbShipVia.ValueMember = "ShipperID";
            cbbShipVia.DisplayMember = "CompanyName";
            cbbShipVia.DataSource = dt;
        }
        void FillcbbShipViaSearch()
        {
            SqlCommand cmd = new SqlCommand("select ShipperID, CompanyName from Shippers order by CompanyName", Connection.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbShipViaSearch.ValueMember = "ShipperID";
            cbbShipViaSearch.DisplayMember = "CompanyName";
            cbbShipViaSearch.DataSource = dt;
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
                else if (control is DateTimePicker)
                {
                    ((DateTimePicker)control).Value = DateTime.Now;
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
                else if (control is DateTimePicker)
                {
                    ((DateTimePicker)control).Value = DateTime.Now;
                }
            }
        }
        private void frmOrders_Load(object sender, EventArgs e)
        {
            ListTheDataToDataGridView();
            FillcbbCustomer();
            FillcbbCustomerSearch();
            FillcbbEmployee();
            FillcbbEmployeeSearch();
            FillcbbShipVia();
            FillcbbShipViaSearch();
            CleanTheControls();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtOrderID.Text = dataGridView1.CurrentRow.Cells["OrderID"].Value.ToString();
            if (!string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells["CustomerID"].Value.ToString()))
                cbbCustomer.SelectedValue = dataGridView1.CurrentRow.Cells["CustomerID"].Value.ToString();
            else
                cbbCustomer.SelectedValue = -1;

            if (!string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells["EmployeeID"].Value.ToString()))
                cbbEmployee.SelectedValue = dataGridView1.CurrentRow.Cells["EmployeeID"].Value.ToString();
            else
                cbbEmployee.SelectedValue = -1;

            if (!string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells["ShipVia"].Value.ToString()))
                cbbShipVia.SelectedValue = dataGridView1.CurrentRow.Cells["ShipVia"].Value.ToString();
            else
                cbbShipVia.SelectedValue = -1;

            if (!string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells["OrderDate"].Value.ToString()))
                dtpOrderDate.Value = (DateTime)dataGridView1.CurrentRow.Cells["OrderDate"].Value;
            else
                dtpOrderDate.Value = DateTime.Now;

            if (!string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells["ShippedDate"].Value.ToString()))
                dtpShippedDate.Value = (DateTime)dataGridView1.CurrentRow.Cells["ShippedDate"].Value;
            else
                dtpShippedDate.Value = DateTime.Now;

            if (!string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells["Requireddate"].Value.ToString()))
                dtpRequiredDate.Value = (DateTime)dataGridView1.CurrentRow.Cells["Requireddate"].Value;
            else
                dtpRequiredDate.Value = DateTime.Now;

            txtShipName.Text = dataGridView1.CurrentRow.Cells["ShipName"].Value.ToString();
            txtShipAddress.Text = dataGridView1.CurrentRow.Cells["ShipAddress"].Value.ToString();
            txtShipCity.Text = dataGridView1.CurrentRow.Cells["ShipCity"].Value.ToString();
            txtShipRegion.Text = dataGridView1.CurrentRow.Cells["ShipRegion"].Value.ToString();
            txtShipPostalCode.Text = dataGridView1.CurrentRow.Cells["ShipPostalCode"].Value.ToString();
            txtShipCountry.Text = dataGridView1.CurrentRow.Cells["ShipCountry"].Value.ToString();
            txtFreight.Text = dataGridView1.CurrentRow.Cells["Freight"].Value.ToString();
        }
        private void btnX_Click(object sender, EventArgs e)
        {
            _frm.Show();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal freight = 0;
            if ((string.IsNullOrEmpty(txtFreight.Text) ? true : decimal.TryParse(txtFreight.Text, out freight) ? freight >= 0 : true) && !(txtShipName.Text.Length > 40 || txtShipAddress.Text.Length > 60 || txtShipCity.Text.Length > 15 || txtShipRegion.Text.Length > 15 || txtShipPostalCode.Text.Length > 10 || txtShipCountry.Text.Length > 15 || dtpOrderDate.Value > DateTime.Now))
            {
                SqlCommand cmd = new SqlCommand("insert into Orders (CustomerID, EmployeeID, OrderDate, RequiredDate, ShippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry) values (@customerID, @employeeID, @orderDate, @requiredDate, @shippedDate, @shipVia, @freight, @shipName, @shipAddress, @shipCity, @shipRegion, @shipPostalCode, @shipCountry)", Connection.con);
                cmd.Parameters.AddWithValue("@customerID", cbbCustomer.SelectedValue);
                cmd.Parameters.AddWithValue("@employeeID", cbbEmployee.SelectedValue);
                cmd.Parameters.AddWithValue("@orderDate", dtpOrderDate.Value);
                cmd.Parameters.AddWithValue("@requiredDate", dtpRequiredDate.Value);
                cmd.Parameters.AddWithValue("@shippedDate", dtpShippedDate.Value);
                cmd.Parameters.AddWithValue("@shipVia", cbbShipVia.SelectedValue);
                cmd.Parameters.AddWithValue("@freight", txtFreight.Text);
                cmd.Parameters.AddWithValue("@shipName", txtShipName.Text);
                cmd.Parameters.AddWithValue("@shipAddress", txtShipAddress.Text);
                cmd.Parameters.AddWithValue("@shipCity", txtShipCity.Text);
                cmd.Parameters.AddWithValue("@shipRegion", txtShipRegion.Text);
                cmd.Parameters.AddWithValue("@shipPostalCode", txtShipPostalCode.Text);
                cmd.Parameters.AddWithValue("@shipCountry", txtShipCountry.Text);
                if (Connection.con.State == ConnectionState.Closed)
                    Connection.con.Open();
                try
                {
                    DialogResult dialogResult = MessageBox.Show("Are You Sure Adding New Order", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("New Order Added into Orders Table", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    ListTheDataToDataGridView();
                    CleanTheControls();
                }
            }
            else
                MessageBox.Show("Checked the errors then try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtOrderID.Text))
            {
                SqlCommand cmd = new SqlCommand("delete from Orders where OrderID = @orderID", Connection.con);
                cmd.Parameters.AddWithValue("@orderID", txtOrderID.Text);
                if (Connection.con.State == ConnectionState.Closed)
                    Connection.con.Open();
                try
                {
                    DialogResult dialogResult = MessageBox.Show($"Are You Sure Delete {txtOrderID.Text}", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"{txtOrderID.Text} Deleted from Orders Table", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    ListTheDataToDataGridView();
                    CleanTheControls();
                }
            }
            else
            {
                MessageBox.Show("Order ID cannot be null in update process", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            decimal freight = 0;
            if ((string.IsNullOrEmpty(txtFreight.Text) ? true : decimal.TryParse(txtFreight.Text, out freight) ? freight >= 0 : false) && !string.IsNullOrEmpty(txtOrderID.Text) && !(txtShipName.Text.Length > 40 || txtShipAddress.Text.Length > 60 || txtShipCity.Text.Length > 15 || txtShipRegion.Text.Length > 15 || txtShipPostalCode.Text.Length > 10 || txtShipCountry.Text.Length > 15 || dtpOrderDate.Value > DateTime.Now))
            {
                SqlCommand cmd = new SqlCommand("update Orders set CustomerID = @customerID, EmployeeID = @employeeID, OrderDate = @orderDate, RequiredDate = @requiredDate, ShippedDate = @shippedDate, ShipVia = @shipVia, Freight = @freight, ShipName = @shipName, ShipAddress = @shipAddress, ShipCity = @shipCity, ShipRegion = @shipRegion, ShipPostalCode = @shipPostalCode, ShipCountry = @shipCountry where OrderID = @orderID", Connection.con);
                cmd.Parameters.AddWithValue("@orderID", txtOrderID.Text);
                cmd.Parameters.AddWithValue("@customerID", cbbCustomer.SelectedValue);
                cmd.Parameters.AddWithValue("@employeeID", cbbEmployee.SelectedValue);
                cmd.Parameters.AddWithValue("@orderDate", dtpOrderDate.Value);
                cmd.Parameters.AddWithValue("@requiredDate", dtpRequiredDate.Value);
                cmd.Parameters.AddWithValue("@shippedDate", dtpShippedDate.Value);
                cmd.Parameters.AddWithValue("@shipVia", cbbShipVia.SelectedValue);
                cmd.Parameters.AddWithValue("@freight", txtFreight.Text);
                cmd.Parameters.AddWithValue("@shipName", txtShipName.Text);
                cmd.Parameters.AddWithValue("@shipAddress", txtShipAddress.Text);
                cmd.Parameters.AddWithValue("@shipCity", txtShipCity.Text);
                cmd.Parameters.AddWithValue("@shipRegion", txtShipRegion.Text);
                cmd.Parameters.AddWithValue("@shipPostalCode", txtShipPostalCode.Text);
                cmd.Parameters.AddWithValue("@shipCountry", txtShipCountry.Text);

                if (Connection.con.State == ConnectionState.Closed)
                    Connection.con.Open();
                try
                {
                    DialogResult dialogResult = MessageBox.Show($"Are You Sure Update {txtOrderID.Text}", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"{txtOrderID.Text} Updated on Orders Table", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    ListTheDataToDataGridView();
                    CleanTheControls();
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtOrderID.Text))
                {
                    MessageBox.Show("Order ID cannot be null in update process", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Checked the errors then try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(rdbOrderID.Checked)
            {
                if (!string.IsNullOrEmpty(txtOrderIDSearch.Text))
                {
                    SqlCommand cmd = new SqlCommand("Select OrderID, c.CompanyName, (FirstName + ' ' + LastName) as Employee, OrderDate, RequiredDate, ShippedDate, s.CompanyName, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry, o.CustomerID, o.EmployeeID, o.ShipVia from Orders as o join Customers as c on o.CustomerID = c.CustomerID join Employees as e on o.EmployeeID = e.EmployeeID join Shippers as s on s.ShipperID = o.ShipVia where OrderID = @orderID", Connection.con);
                    cmd.Parameters.AddWithValue("@orderID", txtOrderIDSearch.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["CustomerID"].Visible = false;
                    dataGridView1.Columns["EmployeeID"].Visible = false;
                    dataGridView1.Columns["ShipVia"].Visible = false;
                }
            }
            else if (rdbCustomer.Checked)
            {
                SqlCommand cmd = new SqlCommand("Select OrderID, c.CompanyName, (FirstName + ' ' + LastName) as Employee, OrderDate, RequiredDate, ShippedDate, s.CompanyName, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry, o.CustomerID, o.EmployeeID, o.ShipVia from Orders as o join Customers as c on o.CustomerID = c.CustomerID join Employees as e on o.EmployeeID = e.EmployeeID join Shippers as s on s.ShipperID = o.ShipVia where o.CustomerID = @customerID", Connection.con);
                cmd.Parameters.AddWithValue("@customerID", cbbCustomerSearch.SelectedValue);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["CustomerID"].Visible = false;
                dataGridView1.Columns["EmployeeID"].Visible = false;
                dataGridView1.Columns["ShipVia"].Visible = false;
            }
            else if (rdbEmployee.Checked)
            {
                SqlCommand cmd = new SqlCommand("Select OrderID, c.CompanyName, (FirstName + ' ' + LastName) as Employee, OrderDate, RequiredDate, ShippedDate, s.CompanyName, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry, o.CustomerID, o.EmployeeID, o.ShipVia from Orders as o join Customers as c on o.CustomerID = c.CustomerID join Employees as e on o.EmployeeID = e.EmployeeID join Shippers as s on s.ShipperID = o.ShipVia where o.EmployeeID = @employeeID", Connection.con);
                cmd.Parameters.AddWithValue("@employeeID", cbbEmployeeSearch.SelectedValue);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["CustomerID"].Visible = false;
                dataGridView1.Columns["EmployeeID"].Visible = false;
                dataGridView1.Columns["ShipVia"].Visible = false;
            }
            else if (rdbShipVia.Checked)
            {
                SqlCommand cmd = new SqlCommand("Select OrderID, c.CompanyName, (FirstName + ' ' + LastName) as Employee, OrderDate, RequiredDate, ShippedDate, s.CompanyName, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry, o.CustomerID, o.EmployeeID, o.ShipVia from Orders as o join Customers as c on o.CustomerID = c.CustomerID join Employees as e on o.EmployeeID = e.EmployeeID join Shippers as s on s.ShipperID = o.ShipVia where ShipVia = @shipVia", Connection.con);
                cmd.Parameters.AddWithValue("@shipVia", cbbShipVia.SelectedValue);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["CustomerID"].Visible = false;
                dataGridView1.Columns["EmployeeID"].Visible = false;
                dataGridView1.Columns["ShipVia"].Visible = false;
            }
            else if (rdbOrderDate.Checked)
            {
                SqlCommand cmd = new SqlCommand("Select OrderID, c.CompanyName, (FirstName + ' ' + LastName) as Employee, OrderDate, RequiredDate, ShippedDate, s.CompanyName, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry, o.CustomerID, o.EmployeeID, o.ShipVia from Orders as o join Customers as c on o.CustomerID = c.CustomerID join Employees as e on o.EmployeeID = e.EmployeeID join Shippers as s on s.ShipperID = o.ShipVia where OrderDate >= @orderDate", Connection.con);
                cmd.Parameters.AddWithValue("@orderDate", dtpOrderdateSearch.Value);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["CustomerID"].Visible = false;
                dataGridView1.Columns["EmployeeID"].Visible = false;
                dataGridView1.Columns["ShipVia"].Visible = false;
            }
            else if (rdbRequiredDate.Checked)
            {
                SqlCommand cmd = new SqlCommand("Select OrderID, c.CompanyName, (FirstName + ' ' + LastName) as Employee, OrderDate, RequiredDate, ShippedDate, s.CompanyName, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry, o.CustomerID, o.EmployeeID, o.ShipVia from Orders as o join Customers as c on o.CustomerID = c.CustomerID join Employees as e on o.EmployeeID = e.EmployeeID join Shippers as s on s.ShipperID = o.ShipVia where RequiredDate >= @requiredDate", Connection.con);
                cmd.Parameters.AddWithValue("@requiredDate", dtpRequiredDateSearch.Value);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["CustomerID"].Visible = false;
                dataGridView1.Columns["EmployeeID"].Visible = false;
                dataGridView1.Columns["ShipVia"].Visible = false;
            }
            else if (rdbShippedDate.Checked)
            {
                SqlCommand cmd = new SqlCommand("Select OrderID, c.CompanyName, (FirstName + ' ' + LastName) as Employee, OrderDate, RequiredDate, ShippedDate, s.CompanyName, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry, o.CustomerID, o.EmployeeID, o.ShipVia from Orders as o join Customers as c on o.CustomerID = c.CustomerID join Employees as e on o.EmployeeID = e.EmployeeID join Shippers as s on s.ShipperID = o.ShipVia where ShippedDate >= @shippedDate", Connection.con);
                cmd.Parameters.AddWithValue("@shippedDate", dtpShippedDateSearch.Value);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["CustomerID"].Visible = false;
                dataGridView1.Columns["EmployeeID"].Visible = false;
                dataGridView1.Columns["ShipVia"].Visible = false;
            }
            else if (rdbCity.Checked)
            {
                SqlCommand cmd = new SqlCommand("Select OrderID, c.CompanyName, (FirstName + ' ' + LastName) as Employee, OrderDate, RequiredDate, ShippedDate, s.CompanyName, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry, o.CustomerID, o.EmployeeID, o.ShipVia from Orders as o join Customers as c on o.CustomerID = c.CustomerID join Employees as e on o.EmployeeID = e.EmployeeID join Shippers as s on s.ShipperID = o.ShipVia where ShipCity like @shipCity", Connection.con);
                cmd.Parameters.AddWithValue("@shipCity", "%" + txtShipCitySearch.Text + "%");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["CustomerID"].Visible = false;
                dataGridView1.Columns["EmployeeID"].Visible = false;
                dataGridView1.Columns["ShipVia"].Visible = false;
            }
            else if (rdbCountry.Checked)
            {
                SqlCommand cmd = new SqlCommand("Select OrderID, c.CompanyName, (FirstName + ' ' + LastName) as Employee, OrderDate, RequiredDate, ShippedDate, s.CompanyName, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry, o.CustomerID, o.EmployeeID, o.ShipVia from Orders as o join Customers as c on o.CustomerID = c.CustomerID join Employees as e on o.EmployeeID = e.EmployeeID join Shippers as s on s.ShipperID = o.ShipVia where ShipCountry like @shipCountry", Connection.con);
                cmd.Parameters.AddWithValue("@shipCountry", "%" + txtShipCountrySearch.Text + "%");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["CustomerID"].Visible = false;
                dataGridView1.Columns["EmployeeID"].Visible = false;
                dataGridView1.Columns["ShipVia"].Visible = false;
            }
            else if (rdbName.Checked)
            {
                SqlCommand cmd = new SqlCommand("Select OrderID, c.CompanyName, (FirstName + ' ' + LastName) as Employee, OrderDate, RequiredDate, ShippedDate, s.CompanyName, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry, o.CustomerID, o.EmployeeID, o.ShipVia from Orders as o join Customers as c on o.CustomerID = c.CustomerID join Employees as e on o.EmployeeID = e.EmployeeID join Shippers as s on s.ShipperID = o.ShipVia where ShipName like @shipName", Connection.con);
                cmd.Parameters.AddWithValue("@shipName", "%" + txtShipNameSearch.Text + "%");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["CustomerID"].Visible = false;
                dataGridView1.Columns["EmployeeID"].Visible = false;
                dataGridView1.Columns["ShipVia"].Visible = false;
            }
            else if (rdbFreight.Checked)
            {
                decimal freight = 0;
                if (decimal.TryParse(txtFreightSearch.Text, out freight))
                {
                    erpFreight.Clear();
                    SqlCommand cmd = new SqlCommand("Select OrderID, c.CompanyName, (FirstName + ' ' + LastName) as Employee, OrderDate, RequiredDate, ShippedDate, s.CompanyName, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry, o.CustomerID, o.EmployeeID, o.ShipVia from Orders as o join Customers as c on o.CustomerID = c.CustomerID join Employees as e on o.EmployeeID = e.EmployeeID join Shippers as s on s.ShipperID = o.ShipVia where Freight >= @freight", Connection.con);
                    cmd.Parameters.AddWithValue("@freight", freight);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["CustomerID"].Visible = false;
                    dataGridView1.Columns["EmployeeID"].Visible = false;
                    dataGridView1.Columns["ShipVia"].Visible = false;
                }
                else
                    erpFreight.SetError(txtFreightSearch, "Only positive integers are accepted.");
            }
            else
            {
                MessageBox.Show("Please choose one of the search option.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnListallOrders_Click(object sender, EventArgs e)
        {
            ListTheDataToDataGridView();
        }

        private void txtFreight_TextChanged(object sender, EventArgs e)
        {
            decimal freight = 0;
            if (!decimal.TryParse(txtFreight.Text, out freight) || freight < 0)
            {
                erpFreight.SetError(txtFreight, "Only positive integers are accepted.");
            }
            else
            {
                erpFreight.Clear();
            }
        }
        private void txtShipName_TextChanged(object sender, EventArgs e)
        {
            if (txtShipName.Text.Length > 40)
            {
                erpShipName.SetError(txtShipName, "The length of the Ship Name cannot be more than 40 characters.");
            }
            else
            {
                erpShipName.Clear();
            }
        }
        private void txtShipAddress_TextChanged(object sender, EventArgs e)
        {
            {
                if (txtShipAddress.Text.Length > 60)
                {
                    erpShipAddress.SetError(txtShipAddress, "The length of the Ship Address cannot be more than 60 characters.");
                }
                else
                {
                    erpShipAddress.Clear();
                }
            }
        }
        private void txtShipCity_TextChanged(object sender, EventArgs e)
        {
            if (txtShipCity.Text.Length > 15)
            {
                erpShipCity.SetError(txtShipCity, "The length of the Ship City cannot be more than 15 characters.");
            }
            else
            {
                erpShipCity.Clear();
            }
        }
        private void txtShipRegion_TextChanged(object sender, EventArgs e)
        {
            if (txtShipRegion.Text.Length > 15)
            {
                erpShipRegion.SetError(txtShipRegion, "The length of the Ship Region cannot be more than 15 characters.");
            }
            else
            {
                erpShipRegion.Clear();
            }
        }
        private void txtShipPostalCode_TextChanged(object sender, EventArgs e)
        {
            if (txtShipPostalCode.Text.Length > 10)
            {
                erpShipPostalCode.SetError(txtShipPostalCode, "The length of the Ship Postal Code cannot be more than 10 characters.");
            }
            else
            {
                erpShipPostalCode.Clear();
            }
        }
        private void txtShipCountry_TextChanged(object sender, EventArgs e)
        {
            if (txtShipCountry.Text.Length > 15)
            {
                erpShipCountry.SetError(txtShipCountry, "The length of the Ship Country cannot be more than 15 characters.");
            }
            else
            {
                erpShipCountry.Clear();
            }
        }
        private void dtpOrderDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpOrderDate.Value > DateTime.Now)
            {
                erpOrderDate.SetError(dtpOrderDate, "Order Date Cannot be future date");
            }
            else
            {
                erpOrderDate.Clear();
            }
        }
    }
}
