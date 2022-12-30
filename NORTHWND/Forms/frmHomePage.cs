using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NORTHWND.Forms
{
    public partial class frmHomePage : Form
    {
        public frmHomePage()
        {
            InitializeComponent();
        }

        private void pnlCategories_Click(object sender, EventArgs e)
        {
            frmCategories frm = new frmCategories(this);
            frm.Show();
            this.Hide();
        }

        private void lblCategories_Click(object sender, EventArgs e)
        {
            frmCategories frm = new frmCategories(this);
            frm.Show();
            this.Hide();
        }

        private void pnlCustomers_Click(object sender, EventArgs e)
        {
            frmCustomers frm = new frmCustomers(this);
            frm.Show();
            this.Hide();
        }

        private void lblCustomers_Click(object sender, EventArgs e)
        {
            frmCustomers frm = new frmCustomers(this);
            frm.Show();
            this.Hide();
        }

        private void pnlEmployees_Click(object sender, EventArgs e)
        {
            frmEmployees frm = new frmEmployees(this);
            frm.Show();
            this.Hide();
        }

        private void lblEmployees_Click(object sender, EventArgs e)
        {
            frmEmployees frm = new frmEmployees(this);
            frm.Show();
            this.Hide();
        }

        private void pnlProducts_Click(object sender, EventArgs e)
        {
            frmProducts frm = new frmProducts(this);
            frm.Show();
            this.Hide();
        }

        private void lblProducts_Click(object sender, EventArgs e)
        {
            frmProducts frm = new frmProducts(this);
            frm.Show();
            this.Hide();
        }

        private void pnlRegions_Click(object sender, EventArgs e)
        {
            frmRegions frm = new frmRegions(this);
            frm.Show();
            this.Hide();
        }

        private void lblRegions_Click(object sender, EventArgs e)
        {
            frmRegions frm = new frmRegions(this);
            frm.Show();
            this.Hide();
        }

        private void pnlShippers_Click(object sender, EventArgs e)
        {
            frmShippers frm = new frmShippers(this);
            frm.Show();
            this.Hide();
        }

        private void lblShippers_Click(object sender, EventArgs e)
        {
            frmShippers frm = new frmShippers(this);
            frm.Show();
            this.Hide();
        }

        private void pnlTerritories_Click(object sender, EventArgs e)
        {
            frmTerritories frm = new frmTerritories(this);
            frm.Show();
            this.Hide();
        }

        private void lblTerritories_Click(object sender, EventArgs e)
        {
            frmTerritories frm = new frmTerritories(this);
            frm.Show();
            this.Hide();
        }

        private void pnlEmployeeTerritories_Click(object sender, EventArgs e)
        {
            frmEmployeeTerritories frm = new frmEmployeeTerritories(this);
            frm.Show();
            this.Hide();
        }

        private void lblEmployeeTerritories_Click(object sender, EventArgs e)
        {
            frmEmployeeTerritories frm = new frmEmployeeTerritories(this);
            frm.Show();
            this.Hide();
        }

        private void pnlSuppliers_Click(object sender, EventArgs e)
        {
            frmSuppliers frm = new frmSuppliers(this);
            frm.Show();
            this.Hide();
        }

        private void lblSuppliers_Click(object sender, EventArgs e)
        {
            frmSuppliers frm = new frmSuppliers(this);
            frm.Show();
            this.Hide();
        }

        private void pnlExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Are You Sure You Want to Exit? ", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Are You Sure You Want to Exit? ", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void pnlOrders_Click(object sender, EventArgs e)
        {
            frmOrders frm = new frmOrders(this);
            frm.Show();
            this.Hide();
        }

        private void lblOrders_Click(object sender, EventArgs e)
        {
            frmOrders frm = new frmOrders(this);
            frm.Show();
            this.Hide();
        }

        private void pnlOrderDetails_Click(object sender, EventArgs e)
        {
            frmOrderDetails frm = new frmOrderDetails(this);
            frm.Show();
            this.Hide();
        }

        private void lblOrderDetails_Click(object sender, EventArgs e)
        {
            frmOrderDetails frm = new frmOrderDetails(this);
            frm.Show();
            this.Hide();
        }
    }
}
