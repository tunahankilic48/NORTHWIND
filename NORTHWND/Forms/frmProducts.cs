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
    public partial class frmProducts : Form
    {
        public frmProducts(frmHomePage frm)
        {
            InitializeComponent();
            _frm = frm;
        }

        ErrorProvider erpProductName = new ErrorProvider(), erpQuantityperUnit = new ErrorProvider(), erpUnitPrice = new ErrorProvider(), erpUnitsinStock = new ErrorProvider(), erpUnitsonOrder = new ErrorProvider(), erpReorderLevel = new ErrorProvider(), erpProductID = new ErrorProvider(), erpDiscontinued = new ErrorProvider();

        private frmHomePage _frm;

        void ListTheDataonDataGridView()
        {
            SqlCommand cmd = new SqlCommand("select ProductID, ProductName, s.CompanyName as Supplier, c.CategoryName, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued, p.SupplierID, p.CategoryID from Products as p join Suppliers as s on p.SupplierID = s.SupplierID join Categories as c on p.CategoryID = c.CategoryID", Connection.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["SupplierID"].Visible = false;
            dataGridView1.Columns["CategoryID"].Visible = false;
        }
        void FillcbbSupplier()
        {
            SqlCommand cmd = new SqlCommand("Select SupplierID, CompanyName from Suppliers order by CompanyName", Connection.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbSupplier.ValueMember = "SupplierID";
            cbbSupplier.DisplayMember = "CompanyName";
            cbbSupplier.DataSource = dt;
        }
        void FillcbbSupplierSearch()
        {
            SqlCommand cmd = new SqlCommand("Select SupplierID, CompanyName from Suppliers order by CompanyName", Connection.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbSupplierSearch.ValueMember = "SupplierID";
            cbbSupplierSearch.DisplayMember = "CompanyName";
            cbbSupplierSearch.DataSource = dt;
        }
        void FillcbbCategory()
        {
            SqlCommand cmd = new SqlCommand("Select CategoryID, CategoryName from Categories order by CategoryName", Connection.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbCategory.ValueMember = "CategoryID";
            cbbCategory.DisplayMember = "CategoryName";
            cbbCategory.DataSource = dt;
        }
        void FillcbbCategorySearch()
        {
            SqlCommand cmd = new SqlCommand("Select CategoryID, CategoryName from Categories order by CategoryName", Connection.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbCategorySearch.ValueMember = "CategoryID";
            cbbCategorySearch.DisplayMember = "CategoryName";
            cbbCategorySearch.DataSource = dt;
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
        private void frmProducts_Load(object sender, EventArgs e)
        {
            ListTheDataonDataGridView();
            FillcbbSupplier();
            FillcbbCategory();
            FillcbbCategorySearch();
            FillcbbSupplierSearch();
            CleanTheControls();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProductID.Text = dataGridView1.CurrentRow.Cells["ProductID"].Value.ToString();
            txtProductName.Text = dataGridView1.CurrentRow.Cells["ProductName"].Value.ToString();
            if (!string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells["SupplierID"].Value.ToString()))
                cbbSupplier.SelectedValue = dataGridView1.CurrentRow.Cells["SupplierID"].Value.ToString();
            else
                cbbSupplier.SelectedValue = -1;
            if (!string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells["CategoryID"].Value.ToString()))
                cbbCategory.SelectedValue = dataGridView1.CurrentRow.Cells["CategoryID"].Value.ToString();
            else
                cbbCategory.SelectedValue = -1;
            txtQuantityperUnit.Text = dataGridView1.CurrentRow.Cells["QuantityperUnit"].Value.ToString();
            txtUnitPrice.Text = dataGridView1.CurrentRow.Cells["UnitPrice"].Value.ToString();
            txtUnitsinStock.Text = dataGridView1.CurrentRow.Cells["UnitsinStock"].Value.ToString();
            txtlblUnitsonOrder.Text = dataGridView1.CurrentRow.Cells["UnitsonOrder"].Value.ToString();
            txtReorderLevel.Text = dataGridView1.CurrentRow.Cells["ReorderLevel"].Value.ToString();
            if (!string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells["Discontinued"].Value.ToString()))
            {
                if (!(bool)(dataGridView1.CurrentRow.Cells["Discontinued"].Value))
                    rdbNo.Checked = true;
                else
                    rdbYes.Checked = true;
            }
            else
                rdbNo.Checked = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal unitPrice = 0;
            short unitsInStock = 0, unitsOnOrder = 0, reorderLevel = 0;
            if(!string.IsNullOrEmpty(txtProductName.Text) && !(txtProductName.Text.Length > 40 || txtQuantityperUnit.Text.Length > 20) && (string.IsNullOrEmpty(txtUnitPrice.Text) ? true : decimal.TryParse(txtUnitPrice.Text, out unitPrice) && string.IsNullOrEmpty(txtUnitsinStock.Text) ? true : short.TryParse(txtUnitsinStock.Text, out unitsInStock) && string.IsNullOrEmpty(txtlblUnitsonOrder.Text) ? true : short.TryParse(txtlblUnitsonOrder.Text, out unitsOnOrder) && string.IsNullOrEmpty(txtReorderLevel.Text) ? true : short.TryParse(txtReorderLevel.Text, out reorderLevel)) && (rdbYes.Checked || rdbNo.Checked))
            {
                SqlCommand cmd = new SqlCommand("insert into Products (ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued) values (@productName, @supplierID, @categoryID, @quantityPerUnit, @unitPrice, @unitsInStock, @unitsOnOrder, @reorderLevel, @discontinued)", Connection.con);
                cmd.Parameters.AddWithValue("@productName", txtProductName.Text);
                cmd.Parameters.AddWithValue("@supplierID", cbbSupplier.SelectedValue);
                cmd.Parameters.AddWithValue("@categoryID", cbbCategory.SelectedValue);
                cmd.Parameters.AddWithValue("@quantityPerUnit", txtQuantityperUnit.Text);
                cmd.Parameters.AddWithValue("@unitPrice", unitPrice);
                cmd.Parameters.AddWithValue("@unitsInStock", unitsInStock);
                cmd.Parameters.AddWithValue("@unitsOnOrder", unitsOnOrder);
                cmd.Parameters.AddWithValue("@reorderLevel", reorderLevel);
                cmd.Parameters.AddWithValue("@discontinued", rdbYes.Checked ? true : false);
                if (Connection.con.State == ConnectionState.Closed)
                    Connection.con.Open();
                try
                {
                    DialogResult dialogResult = MessageBox.Show($"Are You Sure Adding {txtProductName.Text}", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"{txtProductName.Text} Added into Products Table", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if ((!rdbYes.Checked && !rdbNo.Checked) || string.IsNullOrEmpty(txtProductName.Text))
                {
                    MessageBox.Show("Product Name and Discontinued must be selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Please check the errors and try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtProductID.Text)))
            {
                SqlCommand cmd = new SqlCommand("delete from Products where ProductID = @productID", Connection.con);
                cmd.Parameters.AddWithValue("@productID", int.Parse(txtProductID.Text));
                if (Connection.con.State == ConnectionState.Closed)
                    Connection.con.Open();
                try
                {
                    DialogResult dialogResult = MessageBox.Show($"Are You Sure Delete {txtProductName.Text}", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"{txtProductName.Text} Deleted from Products Table", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    CleanTheControls();
                }
            }
            else
            {
                MessageBox.Show("Product ID is neccessary for deletion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            decimal unitPrice = 0;
            short unitsInStock = 0, unitsOnOrder = 0, reorderLevel = 0;
            if (!string.IsNullOrEmpty(txtProductName.Text) && !(txtProductName.Text.Length > 40 || txtQuantityperUnit.Text.Length > 20) && (string.IsNullOrEmpty(txtUnitPrice.Text) ? true : decimal.TryParse(txtUnitPrice.Text, out unitPrice) && string.IsNullOrEmpty(txtUnitsinStock.Text) ? true : short.TryParse(txtUnitsinStock.Text, out unitsInStock) && string.IsNullOrEmpty(txtlblUnitsonOrder.Text) ? true : short.TryParse(txtlblUnitsonOrder.Text, out unitsOnOrder) && string.IsNullOrEmpty(txtReorderLevel.Text) ? true : short.TryParse(txtReorderLevel.Text, out reorderLevel)) && (rdbYes.Checked || rdbNo.Checked))
            {
                SqlCommand cmd = new SqlCommand("update Products set ProductName = @productName, SupplierID = @supplierID, CategoryID = @categoryID, QuantityPerUnit = @quantityPerUnit, UnitPrice = @unitPrice, UnitsInStock = @unitsInStock, UnitsOnOrder = @unitsOnOrder, ReorderLevel = @reorderLevel, Discontinued = @discontinued where ProductID = @productID", Connection.con);
                cmd.Parameters.AddWithValue("@productID", int.Parse(txtProductID.Text));
                cmd.Parameters.AddWithValue("@productName", txtProductName.Text);
                cmd.Parameters.AddWithValue("@supplierID", cbbSupplier.SelectedValue);
                cmd.Parameters.AddWithValue("@categoryID", cbbCategory.SelectedValue);
                cmd.Parameters.AddWithValue("@quantityPerUnit", txtQuantityperUnit.Text);
                cmd.Parameters.AddWithValue("@unitPrice", decimal.Parse(txtUnitPrice.Text));
                cmd.Parameters.AddWithValue("@unitsInStock", int.Parse(txtUnitsinStock.Text));
                cmd.Parameters.AddWithValue("@unitsOnOrder", int.Parse(txtlblUnitsonOrder.Text));
                cmd.Parameters.AddWithValue("@reorderLevel", int.Parse(txtReorderLevel.Text));
                cmd.Parameters.AddWithValue("@discontinued", rdbYes.Checked ? true : false);
                if (Connection.con.State == ConnectionState.Closed)
                    Connection.con.Open();
                try
                {
                    DialogResult dialogResult = MessageBox.Show($"Are You Sure Update {txtProductName.Text}", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"{txtProductName.Text} Updated on Products Table", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (string.IsNullOrEmpty(txtProductID.Text) && (!rdbYes.Checked && !rdbNo.Checked) || string.IsNullOrEmpty(txtProductName.Text))
                {
                    MessageBox.Show("Product Name and Discontinued must be selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Please check the errors and try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnX_Click(object sender, EventArgs e)
        {
            _frm.Show();
            this.Close();
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            if (txtProductName.Text.Length > 40)
                erpProductName.SetError(txtProductName, "The lenght of the Product Name must be less than 40 characters");
            else
                erpProductName.Clear();
        }
        private void btnListProducts_Click(object sender, EventArgs e)
        {
            ListTheDataonDataGridView();
        }
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (rdbProductID.Checked)
            {
                if (int.TryParse(txtProductIDSearch.Text, out int productID))
                {
                    erpProductID.Clear();

                    SqlCommand cmd = new SqlCommand("select ProductID, ProductName, s.CompanyName as Supplier, c.CategoryName, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued, p.SupplierID, p.CategoryID from Products as p join Suppliers as s on p.SupplierID = s.SupplierID join Categories as c on p.CategoryID = c.CategoryID where ProductID = @productID", Connection.con);
                    cmd.Parameters.AddWithValue("@productID", productID);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["SupplierID"].Visible = false;
                    dataGridView1.Columns["CategoryID"].Visible = false;
                }
                else
                {
                    erpProductID.SetError(txtProductIDSearch, "The characters must be numeric only");

                }
            }
            else if (rdbProductName.Checked)
            {
                SqlCommand cmd1 = new SqlCommand("select ProductID, ProductName, s.CompanyName as Supplier, c.CategoryName, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued, p.SupplierID, p.CategoryID from Products as p join Suppliers as s on p.SupplierID = s.SupplierID join Categories as c on p.CategoryID = c.CategoryID where ProductName like @productName", Connection.con);
                cmd1.Parameters.AddWithValue("@productName", "%" + txtProductNameSearch.Text + "%");
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;
                dataGridView1.Columns["SupplierID"].Visible = false;
                dataGridView1.Columns["CategoryID"].Visible = false;
            }
            else if (rdbSupplier.Checked)
            {
                SqlCommand cmd2 = new SqlCommand("select ProductID, ProductName, s.CompanyName as Supplier, c.CategoryName, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued, p.SupplierID, p.CategoryID from Products as p join Suppliers as s on p.SupplierID = s.SupplierID join Categories as c on p.CategoryID = c.CategoryID where p.SupplierID = @supplierID", Connection.con);
                cmd2.Parameters.AddWithValue("@supplierID", cbbSupplierSearch.SelectedValue);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dataGridView1.DataSource = dt2;
                dataGridView1.Columns["SupplierID"].Visible = false;
                dataGridView1.Columns["CategoryID"].Visible = false;
            }
            else if (rdbCategory.Checked)
            {
                SqlCommand cmd3 = new SqlCommand("select ProductID, ProductName, s.CompanyName as Supplier, c.CategoryName, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued, p.SupplierID, p.CategoryID from Products as p join Suppliers as s on p.SupplierID = s.SupplierID join Categories as c on p.CategoryID = c.CategoryID where p.CategoryID = @categoryID", Connection.con);
                cmd3.Parameters.AddWithValue("@categoryID", cbbCategorySearch.SelectedValue);
                SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
                DataTable dt3 = new DataTable();
                da3.Fill(dt3);
                dataGridView1.DataSource = dt3;
                dataGridView1.Columns["SupplierID"].Visible = false;
                dataGridView1.Columns["CategoryID"].Visible = false;
            }
            else if (rdbReorderLevel.Checked)
            {
                if (short.TryParse(txtReorderLevelSearch.Text, out short reorderLevel))
                {
                    erpReorderLevel.Clear();
                    SqlCommand cmd4 = new SqlCommand("select ProductID, ProductName, s.CompanyName as Supplier, c.CategoryName, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued, p.SupplierID, p.CategoryID from Products as p join Suppliers as s on p.SupplierID = s.SupplierID join Categories as c on p.CategoryID = c.CategoryID where ReorderLevel >= @reorderLevel", Connection.con);
                    cmd4.Parameters.AddWithValue("@reorderLevel", reorderLevel);
                    SqlDataAdapter da4 = new SqlDataAdapter(cmd4);
                    DataTable dt4 = new DataTable();
                    da4.Fill(dt4);
                    dataGridView1.DataSource = dt4;
                    dataGridView1.Columns["SupplierID"].Visible = false;
                    dataGridView1.Columns["CategoryID"].Visible = false;
                }
                else
                {
                    erpReorderLevel.SetError(txtReorderLevelSearch, "The characters must be numeric only");
                }
            }
            else if (rdbUnitPrice.Checked)
            {
                if (short.TryParse(txtUnitPriceSearch.Text, out short unitPrice))
                {
                    erpUnitPrice.Clear();
                    SqlCommand cmd5 = new SqlCommand("select ProductID, ProductName, s.CompanyName as Supplier, c.CategoryName, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued, p.SupplierID, p.CategoryID from Products as p join Suppliers as s on p.SupplierID = s.SupplierID join Categories as c on p.CategoryID = c.CategoryID where UnitPrice >= @unitPrice", Connection.con);
                    cmd5.Parameters.AddWithValue("@unitPrice", unitPrice);
                    SqlDataAdapter da5 = new SqlDataAdapter(cmd5);
                    DataTable dt5 = new DataTable();
                    da5.Fill(dt5);
                    dataGridView1.DataSource = dt5;
                    dataGridView1.Columns["SupplierID"].Visible = false;
                    dataGridView1.Columns["CategoryID"].Visible = false;
                }
                else
                {
                    erpUnitPrice.SetError(txtUnitPriceSearch, "The characters must be numeric only");
                }
            }
            else if (rdbUnitsinStock.Checked)
            {
                if (short.TryParse(txtUnitsinStockSearch.Text, out short unitsinStock))
                {
                    erpUnitsinStock.Clear();
                    SqlCommand cmd6 = new SqlCommand("select ProductID, ProductName, s.CompanyName as Supplier, c.CategoryName, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued, p.SupplierID, p.CategoryID from Products as p join Suppliers as s on p.SupplierID = s.SupplierID join Categories as c on p.CategoryID = c.CategoryID where UnitsInStock >= @unitsinStock", Connection.con);
                    cmd6.Parameters.AddWithValue("@unitsinStock", unitsinStock);
                    SqlDataAdapter da6 = new SqlDataAdapter(cmd6);
                    DataTable dt6 = new DataTable();
                    da6.Fill(dt6);
                    dataGridView1.DataSource = dt6;
                    dataGridView1.Columns["SupplierID"].Visible = false;
                    dataGridView1.Columns["CategoryID"].Visible = false;
                }
                else
                {
                    erpUnitsinStock.SetError(txtUnitsinStockSearch, "The characters must be numeric only");
                }
            }
            else if (rdbDiscontinued.Checked)
            {
                if (rdbYesSearch.Checked || rdbNoSearch.Checked)
                {
                    erpDiscontinued.Clear();
                    SqlCommand cmd7 = new SqlCommand("select ProductID, ProductName, s.CompanyName as Supplier, c.CategoryName, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued, p.SupplierID, p.CategoryID from Products as p join Suppliers as s on p.SupplierID = s.SupplierID join Categories as c on p.CategoryID = c.CategoryID where Discontinued >= @discontinued", Connection.con);
                    cmd7.Parameters.AddWithValue("@discontinued", rdbYesSearch.Checked ? true : false);
                    SqlDataAdapter da7 = new SqlDataAdapter(cmd7);
                    DataTable dt7 = new DataTable();
                    da7.Fill(dt7);
                    dataGridView1.DataSource = dt7;
                    dataGridView1.Columns["SupplierID"].Visible = false;
                    dataGridView1.Columns["CategoryID"].Visible = false;
                }
                else
                {
                    erpDiscontinued.SetError(lblDiscountinuedSearch, "Yes or No must be checked in discontinued");
                }
            }
            else
            {
                
                MessageBox.Show("You have to choose one of the search option", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnListProducts_Click_1(object sender, EventArgs e)
        {
            ListTheDataonDataGridView();
        }
        private void txtQuantityperUnit_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantityperUnit.Text.Length > 20)
                erpQuantityperUnit.SetError(txtQuantityperUnit, "The lenght of the Quantity per Unit must be less than 20 characters");
            else
                erpQuantityperUnit.Clear();
        }
        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {
            if (!(decimal.TryParse(txtUnitPrice.Text, out decimal UnitPrice)))
                erpUnitPrice.SetError(txtUnitPrice, "The characters must be numeric only");
            else
                erpUnitPrice.Clear();
        }
        private void txtUnitsinStock_TextChanged(object sender, EventArgs e)
        {
            if (!(short.TryParse(txtUnitsinStock.Text, out short UnitsInStock)))
                erpUnitsinStock.SetError(txtUnitsinStock, "The characters must be numeric only");
            else
                erpUnitsinStock.Clear();
        }
        private void txtlblUnitsonOrder_TextChanged(object sender, EventArgs e)
        {
            if (!(short.TryParse(txtlblUnitsonOrder.Text, out short UnitsOnOrder)))
                erpUnitsonOrder.SetError(txtlblUnitsonOrder, "The characters must be numeric only");
            else
                erpUnitsonOrder.Clear();
        }
        private void txtReorderLevel_TextChanged(object sender, EventArgs e)
        {
            if (!(short.TryParse(txtReorderLevel.Text, out short UnitsInStock)))
                erpReorderLevel.SetError(txtReorderLevel, "The characters must be numeric only");
            else
                erpReorderLevel.Clear();
        }
    }
}
