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
    public partial class frmEmployeeTerritories : Form
    {
        public frmEmployeeTerritories(frmHomePage frm)
        {
            InitializeComponent();
            _frm = frm;
        }

        SqlConnection con = new SqlConnection("Server=DESKTOP-A10URF2\\SQLEXPRESS;Database=NORTHWND;Trusted_Connection=True;");

        private frmHomePage _frm;
        
        void ListTheDataonDataGridView()
        {
            SqlCommand cmd = new SqlCommand("select (e.FirstName + ' ' + e.LastName) as Employee, t.TerritoryDescription from EmployeeTerritories as et join Employees as e on e.EmployeeID = et.EmployeeID join Territories as t on et.TerritoryID = t.TerritoryID", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void FillcbbEmployee()
        {
            SqlCommand cmd = new SqlCommand("select EmployeeID, (FirstName + ' ' + LastName) as EmployeeName from Employees order by FirstName", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbEmployee.ValueMember = "EmployeeID";
            cbbEmployee.DisplayMember = "EmployeeName";
            cbbEmployee.DataSource = dt;
        }
        void FillcbbEmployeeSearch()
        {
            SqlCommand cmd = new SqlCommand("select EmployeeID, (FirstName + ' ' + LastName) as EmployeeName from Employees order by FirstName", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbEmployeeSearch.ValueMember = "EmployeeID";
            cbbEmployeeSearch.DisplayMember = "EmployeeName";
            cbbEmployeeSearch.DataSource = dt;
        }
        void FillcbbTerritory()
        {
            SqlCommand cmd = new SqlCommand("select TerritoryID, TerritoryDescription from Territories order by TerritoryDescription", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbTerritory.ValueMember = "TerritoryID";
            cbbTerritory.DisplayMember = "TerritoryDescription";
            cbbTerritory.DataSource = dt;
        }
        void FillcbbTerritorySearch()
        {
            SqlCommand cmd = new SqlCommand("select TerritoryID, TerritoryDescription from Territories order by TerritoryDescription", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbTerritorySearch.ValueMember = "TerritoryID";
            cbbTerritorySearch.DisplayMember = "TerritoryDescription";
            cbbTerritorySearch.DataSource = dt;
        }
        void CleanTheControls()
        {
            foreach (Control control in this.groupBox1.Controls)
            {
                if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = 0;
                }
            }
            foreach (Control control in this.groupBox2.Controls)
            {
                if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = 0;
                }
            }
        }
        private void frmEmployeeTerritories_Load(object sender, EventArgs e)
        {
            ListTheDataonDataGridView();
            FillcbbTerritory();
            FillcbbEmployee();
            FillcbbEmployeeSearch();
            FillcbbTerritorySearch();
            CleanTheControls();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbEmployee.SelectedValue = dataGridView1.CurrentRow.Cells["EmployeeID"].Value;
            cbbTerritory.SelectedValue = dataGridView1.CurrentRow.Cells["TerritoryID"].Value;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            _frm.Show();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into EmployeeTerritories (EmployeeID, TerritoryID) values (@employeeID, @territoryID)", con);
            cmd.Parameters.AddWithValue("@employeeID", cbbEmployee.SelectedValue);
            cmd.Parameters.AddWithValue("@territoryID", cbbTerritory.SelectedValue);
            if (con.State == ConnectionState.Closed)
                con.Open();
            try
            {
                DialogResult dialogResult = MessageBox.Show($"Are You Sure Adding {cbbEmployee.SelectedText}", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show($"{cbbEmployee.SelectedText} Added into Employye Territories Table", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from EmployeeTerritories where EmployeeID = @employeeID and TerritoryID = @territoryID");
            cmd.Parameters.AddWithValue("@employeeID", cbbEmployee.SelectedValue);
            cmd.Parameters.AddWithValue("@territoryID", cbbTerritory.SelectedValue);
            if (con.State == ConnectionState.Closed)
                con.Open();
            try
            {
                DialogResult dialogResult = MessageBox.Show($"Are You Sure Delete {cbbEmployee.SelectedText}", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show($"{cbbEmployee.SelectedText} Delete from Employye Territories Table", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                con.Close();
                ListTheDataonDataGridView();
                CleanTheControls();
            }
        
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rdbEmployee.Checked)
            {
                SqlCommand cmd = new SqlCommand("select (e.FirstName + ' ' + e.LastName) as Employee, t.TerritoryDescription from EmployeeTerritories as et join Employees as e on e.EmployeeID = et.EmployeeID join Territories as t on et.TerritoryID = t.TerritoryID where et.EmployeeID = @employeeID", con);
                cmd.Parameters.AddWithValue("@employeeID", cbbEmployeeSearch.SelectedValue);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (rdbTerritory.Checked)
            {
                SqlCommand cmd1 = new SqlCommand("select (e.FirstName + ' ' + e.LastName) as Employee, t.TerritoryDescription from EmployeeTerritories as et join Employees as e on e.EmployeeID = et.EmployeeID join Territories as t on et.TerritoryID = t.TerritoryID where et.TerritoryID = @territoryID", con);
                cmd1.Parameters.AddWithValue("@territoryID", cbbTerritorySearch.SelectedValue);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;
            }
            else
            {
                MessageBox.Show("Please select one of the search options", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnListAll_Click(object sender, EventArgs e)
        {
            ListTheDataonDataGridView();
        }
    }
}
