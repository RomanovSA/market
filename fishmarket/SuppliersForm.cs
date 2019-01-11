using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using fishmarket.classes;

namespace fishmarket
{
    public partial class SuppliersForm : Form
    {
        FilterSuppliers filter = new FilterSuppliers();
        public SuppliersForm()
        {
            InitializeComponent();
        }
        public void OpenForm()
        {
            DataSuppliers.Load();
            DataTable dt = DataSuppliers.DBOperation();
            DataView dv = new DataView(dt);
            bsSuppliers.DataSource = dv;
            dgvSuppliers.DataSource = bsSuppliers;
            //фильтры
            if (dgvSuppliers.Rows.Count > 0)
            {
                cbRegion.DataSource = dv.ToTable(true, "Область");
                cbRegion.DisplayMember = "Область";
                cbRegion.Text = String.Empty;
                btDelRegion.Visible = false;

                cbCity.DataSource = dv.ToTable(true, "Город");
                cbCity.DisplayMember = "Город";
                cbCity.Text = String.Empty;
                btDelCity.Visible = false;
            }
        }

        private void btDelRegion_Click(object sender, EventArgs e)
        {
            cbRegion.Text = String.Empty;
            btDelRegion.Visible = false;
            cbRegion.Focus();
        }

        private void btDelCity_Click(object sender, EventArgs e)
        {
            cbCity.Text = String.Empty;
            btDelCity.Visible = false;
            cbCity.Focus();
        }

        private void cbRegion_TextChanged(object sender, EventArgs e)
        {
            filter.Region = cbRegion.Text.Trim();
            bsSuppliers.Filter = filter.getBindingText();
            if (cbRegion.Text != String.Empty)
            {
                btDelRegion.Visible = true;
            }
            else btDelRegion.Visible = false;
        }

        private void cbCity_TextChanged(object sender, EventArgs e)
        {
            filter.City = cbCity.Text.Trim();
            bsSuppliers.Filter = filter.getBindingText();
            if (cbCity.Text != String.Empty)
            {
                btDelCity.Visible = true;
            }
            else btDelCity.Visible = false;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            string del = dgvSuppliers.CurrentRow.Cells[0].ToString();

            DataSuppliers.Delete(del);
            OpenForm();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            AddSuppliers addsuppliers = new AddSuppliers();
            addsuppliers.ShowDialog();
        }

        private void btChange_Click(object sender, EventArgs e)
        {
            UpdateSuppliers updatesuppliers = new UpdateSuppliers();

            string name = dgvSuppliers.CurrentRow.Cells[1].ToString();
            string region = dgvSuppliers.CurrentRow.Cells[2].ToString();
            string city = dgvSuppliers.CurrentRow.Cells[3].ToString();
            string adres = dgvSuppliers.CurrentRow.Cells[4].ToString();
            string tel = dgvSuppliers.CurrentRow.Cells[5].ToString();
            string email = dgvSuppliers.CurrentRow.Cells[6].ToString();
            
            updatesuppliers.Zap(name, region, city, adres, tel, email);
            updatesuppliers.ShowDialog();
        }
    }
}
