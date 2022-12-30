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
    public partial class frmOrderDetails : Form
    {
        ErrorProvider erpOrderID = new ErrorProvider(), erpUnitPrice = new ErrorProvider(), erpQuantity = new ErrorProvider(), erpDiscount = new ErrorProvider();

        private frmHomePage _frm;

        public frmOrderDetails(frmHomePage frm)
        {
            InitializeComponent();
            _frm = frm;
        }
        void ListTheDataonDataGridView()
        {
            SqlCommand cmd = new SqlCommand("select OrderID, p.ProductName, od.UnitPrice, Quantity, Discount, p.ProductID from [Order Details] as od join Products as p on od.ProductID = p.ProductID", Connection.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["ProductID"].Visible = false;
        }
        void FillcbbProduct()
        {
            SqlCommand cmd = new SqlCommand("Select ProductID, ProductName from Products order by ProductName", Connection.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbProduct.ValueMember = "ProductID";
            cbbProduct.DisplayMember = "ProductName";
            cbbProduct.DataSource = dt;
        }
        void FillcbbProductSearch()
        {
            SqlCommand cmd = new SqlCommand("Select ProductID, ProductName from Products order by ProductName", Connection.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbProductSearch.ValueMember = "ProductID";
            cbbProductSearch.DisplayMember = "ProductName";
            cbbProductSearch.DataSource = dt;
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
                    ((ComboBox)control).SelectedIndex = 1;
                }
            }
        }
        private void frmOrderDetails_Load(object sender, EventArgs e)
        {
            ListTheDataonDataGridView();
            FillcbbProduct();
            FillcbbProductSearch();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtOrderID.Text = dataGridView1.CurrentRow.Cells["OrderID"].Value.ToString();
            if (!string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells["ProductID"].Value.ToString()))
                cbbProduct.SelectedValue = dataGridView1.CurrentRow.Cells["ProductID"].Value.ToString();
            else
                cbbProduct.SelectedValue = -1;
            txtQuantity.Text = dataGridView1.CurrentRow.Cells["Quantity"].Value.ToString();
            txtUnitPrice.Text = dataGridView1.CurrentRow.Cells["UnitPrice"].Value.ToString();
            txtDiscount.Text = dataGridView1.CurrentRow.Cells["Discount"].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int orderID = 0; decimal unitPrice = 0; short quantity = 0; decimal discount = 0;
            if (!(!int.TryParse(txtOrderID.Text, out orderID) || orderID <= 0) && !(!decimal.TryParse(txtUnitPrice.Text, out unitPrice) || unitPrice < 0) && !(!short.TryParse(txtQuantity.Text, out quantity) || quantity < 0) && !(!decimal.TryParse(txtDiscount.Text, out discount) || discount < 0))
            {
                SqlCommand cmd = new SqlCommand("insert into [Order Details] (OrderID, ProductID, UnitPrice, Quantity, Discount) values (@orderID, @productID, @unitPrice, @quantity, @discount)", Connection.con);
                cmd.Parameters.AddWithValue("@orderID", orderID);
                cmd.Parameters.AddWithValue("@productID", cbbProduct.SelectedValue);
                cmd.Parameters.AddWithValue("@unitPrice", unitPrice);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@discount", discount);
                if (Connection.con.State == ConnectionState.Closed)
                    Connection.con.Open();
                try
                {
                    DialogResult dialogResult = MessageBox.Show($"Are You Sure Adding {txtOrderID.Text}", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"{txtOrderID.Text} Added into Order Details Table", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("All fields must be filled, Please check the errors and try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int orderID = 0; decimal unitPrice = 0; short quantity = 0; decimal discount = 0;
            if (!(!int.TryParse(txtOrderID.Text, out orderID) || orderID <= 0) && !(!decimal.TryParse(txtUnitPrice.Text, out unitPrice) || unitPrice < 0) && !(!short.TryParse(txtQuantity.Text, out quantity) || quantity < 0) && !(!decimal.TryParse(txtDiscount.Text, out discount) || discount < 0))
            {
                SqlCommand cmd = new SqlCommand("delete from [Order Details] where OrderID = @orderID and ProductID = @productID and UnitPrice = @unitPrice and Quantity = @quantity and Discount = @discount", Connection.con);
                cmd.Parameters.AddWithValue("@orderID", orderID);
                cmd.Parameters.AddWithValue("@productID", cbbProduct.SelectedValue);
                cmd.Parameters.AddWithValue("@unitPrice", unitPrice);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@discount", discount);
                if (Connection.con.State == ConnectionState.Closed)
                    Connection.con.Open();
                try
                {
                    DialogResult dialogResult = MessageBox.Show($"Are You Sure Delete", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"Deleted from Order Details Table", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("All fields must be filled, Please check the errors and try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            _frm.Show();
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rdbOrderID.Checked)
            {
                int orderID = 0;
                if (!(!int.TryParse(txtOrderIDSearch.Text, out orderID) || orderID <= 0))
                {
                    erpOrderID.Clear();
                    SqlCommand cmd = new SqlCommand("select OrderID, p.ProductName, od.UnitPrice, Quantity, Discount, p.ProductID from [Order Details] as od join Products as p on od.ProductID = p.ProductID where OrderID = @orderID", Connection.con);
                    cmd.Parameters.AddWithValue("@orderID", orderID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["ProductID"].Visible = false;
                }
                else
                {
                    erpOrderID.SetError(txtOrderIDSearch, "Order ID can be positive integers only.");
                }
            }
            else if (rdbProduct.Checked)
            {
                SqlCommand cmd = new SqlCommand("select OrderID, p.ProductName, od.UnitPrice, Quantity, Discount, p.ProductID from [Order Details] as od join Products as p on od.ProductID = p.ProductID where od.ProductID = @productID", Connection.con);
                cmd.Parameters.AddWithValue("@productID", cbbProductSearch.SelectedValue);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["ProductID"].Visible = false;
            }
            else if (rdbUnitPrice.Checked)
            {
                decimal unitPrice = 0;
                if (!(!decimal.TryParse(txtUnitPriceSearch.Text, out unitPrice) || unitPrice < 0))
                {
                    erpUnitPrice.Clear();
                    SqlCommand cmd = new SqlCommand("select OrderID, p.ProductName, od.UnitPrice, Quantity, Discount, p.ProductID from [Order Details] as od join Products as p on od.ProductID = p.ProductID where od.UnitPrice > @unitPrice", Connection.con);
                    cmd.Parameters.AddWithValue("@unitPrice", unitPrice);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["ProductID"].Visible = false;
                }
                else
                {
                    erpUnitPrice.SetError(txtUnitPriceSearch, "Unit Price can be positive value only.");
                }
            }
            else if (rdbQuantity.Checked)
            {
                short quantity = 0;
                if (!(!short.TryParse(txtQuantitySearch.Text, out quantity) || quantity < 0))
                {
                    erpQuantity.Clear();
                    SqlCommand cmd = new SqlCommand("select OrderID, p.ProductName, od.UnitPrice, Quantity, Discount, p.ProductID from [Order Details] as od join Products as p on od.ProductID = p.ProductID where od.Quantity = @quantity", Connection.con);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["ProductID"].Visible = false;
                }
                else
                {
                    erpQuantity.SetError(txtQuantitySearch, "Quantity can be positive integers only.");
                }
            }
            else
            {
                MessageBox.Show("You have to choose one of the search option", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnListProducts_Click(object sender, EventArgs e)
        {
            ListTheDataonDataGridView();
        }

        private void txtOrderID_TextChanged(object sender, EventArgs e)
        {
            int orderID = 0;
            if (!int.TryParse(txtOrderID.Text, out orderID) || orderID <= 0)
            {
                erpOrderID.SetError(txtOrderID, "Order ID can be positive integers only.");
            }
            else
            {
                erpOrderID.Clear();
            }
        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {
            decimal unitPrice = 0;
            if (!decimal.TryParse(txtUnitPrice.Text, out unitPrice) || unitPrice < 0)
            {
                erpUnitPrice.SetError(txtUnitPrice, "Unit Price can be positive value only.");
            }
            else
            {
                erpUnitPrice.Clear();
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            short quantity = 0;
            if (!short.TryParse(txtQuantity.Text, out quantity) || quantity < 0)
            {
                erpQuantity.SetError(txtQuantity, "Quantity can be positive integers only.");
            }
            else
            {
                erpQuantity.Clear();
            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            decimal discount = 0;
            if (!decimal.TryParse(txtDiscount.Text, out discount) || discount < 0)
            {
                erpDiscount.SetError(txtDiscount, "Discount can be positive value only.");
            }
            else
            {
                erpDiscount.Clear();
            }
        }
    }
}
