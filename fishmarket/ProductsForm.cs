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
    public partial class ProductsForm : Form
    {
        FilterProducts filter = new FilterProducts();
        public ProductsForm()
        {
            InitializeComponent();
        }

        public void OpenForm()
        {
            //заполнение datagridview
            DataProducts.Load();
            DataTable dt = DataProducts.DBOperation();
            DataView dv = new DataView(dt);

            bsProducts.DataSource = dv;
            dgvProducts.DataSource = bsProducts;

            //фильтры
            if (dgvProducts.Rows.Count > 0)
            {
                cbManufacturer.DataSource = dv.ToTable(true, "Производитель");
                cbManufacturer.DisplayMember = "Производитель";
                cbManufacturer.Text = String.Empty;
                btDelManufacturer.Visible = false;

                cbName.DataSource = dv.ToTable(true, "Наименование");
                cbName.DisplayMember = "Наименование";
                cbName.Text = String.Empty;
                btDelName.Visible = false;

                cbCountry.DataSource = dv.ToTable(true, "Страна изготовления");
                cbCountry.DisplayMember = "Страна изготовления";
                cbCountry.Text = String.Empty;
                btDelCountry.Visible = false;

                cbAnimal.DataSource = dv.ToTable(true, "Животное");
                cbAnimal.DisplayMember = "Животное";
                cbAnimal.Text = String.Empty;
                btDelAnimal.Visible = false;
            }
        }

        private void btDelManufacturer_Click(object sender, EventArgs e)
        {
            cbManufacturer.Text = String.Empty;
            btDelManufacturer.Visible = false;
            cbManufacturer.Focus();
        }

        private void btDelName_Click(object sender, EventArgs e)
        {
            cbName.Text = String.Empty;
            btDelName.Visible = false;
            cbName.Focus();
        }

        private void btDelCountry_Click(object sender, EventArgs e)
        {
            cbCountry.Text = String.Empty;
            btDelCountry.Visible = false;
            cbCountry.Focus();
        }

        private void btDelAnimal_Click(object sender, EventArgs e)
        {
            cbAnimal.Text = String.Empty;
            btDelAnimal.Visible = false;
            cbAnimal.Focus();
        }

        private void cbManufacturer_TextChanged(object sender, EventArgs e)
        {
            filter.Manufacturer = cbManufacturer.Text.Trim();
            bsProducts.Filter = filter.getBindingText();
            if (cbManufacturer.Text != String.Empty)
            {
                btDelManufacturer.Visible = true;
            }
            else btDelManufacturer.Visible = false;
        }

        private void cbName_TextChanged(object sender, EventArgs e)
        {
            filter.Name = cbName.Text.Trim();
            bsProducts.Filter = filter.getBindingText();
            if (cbName.Text != String.Empty)
            {
                btDelName.Visible = true;
            }
            else btDelName.Visible = false;
        }

        private void cbCountry_TextChanged(object sender, EventArgs e)
        {
            filter.Country = cbCountry.Text.Trim();
            bsProducts.Filter = filter.getBindingText();
            if (cbCountry.Text != String.Empty)
            {
                btDelCountry.Visible = true;
            }
            else btDelCountry.Visible = false;
        }

        private void cbAnimal_TextChanged(object sender, EventArgs e)
        {
            filter.Animal = cbAnimal.Text.Trim();
            bsProducts.Filter = filter.getBindingText();
            if (cbAnimal.Text != String.Empty)
            {
                btDelAnimal.Visible = true;
            }
            else btDelAnimal.Visible = false;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            string del = dgvProducts.CurrentRow.Cells[0].ToString();

            DataProducts.Delete(del);
            OpenForm();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            AddProduct addsuppliers = new AddProduct();
            addsuppliers.ShowDialog();
        }

        private void btChange_Click(object sender, EventArgs e)
        {
            UpdateProduct updatesuppliers = new UpdateProduct();

            string Manufacturer = dgvProducts.CurrentRow.Cells[1].ToString();
            string Name = dgvProducts.CurrentRow.Cells[2].ToString();
            string Country = dgvProducts.CurrentRow.Cells[3].ToString();
            string Supplier = dgvProducts.CurrentRow.Cells[4].ToString();
            string Animal = dgvProducts.CurrentRow.Cells[5].ToString();
            string Type = dgvProducts.CurrentRow.Cells[6].ToString();
            string Price = dgvProducts.CurrentRow.Cells[7].ToString();
            string Valid = dgvProducts.CurrentRow.Cells[8].ToString();
            string stock = dgvProducts.CurrentRow.Cells[9].ToString();
            string Expected = dgvProducts.CurrentRow.Cells[10].ToString();

            updatesuppliers.Zap(Manufacturer, Name, Country, Supplier, Animal, Type, Price, Valid, stock, Expected);
            updatesuppliers.ShowDialog();
        }
    }
}
