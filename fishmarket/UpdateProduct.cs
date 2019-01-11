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
    public partial class UpdateProduct : Form
    {
        public UpdateProduct()
        {
            InitializeComponent();
        }
        public void Zap(string Manufacturer, string Name, string Country, string Supplier, string Animal, string Type, string Price, string Valid, string stock, string Expected)
        {
            tbManufacturer.Text = Manufacturer;
            tbName.Text = Name;
            tbCountry.Text = Country;
            tbSupplier.Text = Supplier;
            tbAnimal.Text = Animal;
            tbType.Text = Type;
            tbPrice.Text = Price;
            tbValid.Text = Valid;
            tbStock.Text = stock;
            tbExpected.Text = Expected;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string Manufacturer = tbManufacturer.Text;
            string Name = tbName.Text;
            string Country = tbCountry.Text;
            string Supplier = tbSupplier.Text;
            string Animal = tbAnimal.Text;
            string Type = tbType.Text;
            string Price = tbPrice.Text;
            string Valid = tbValid.Text;
            string stock = tbStock.Text;
            string Expected = tbExpected.Text;

            DataProducts.Update(Manufacturer, Name, Country, Supplier, Animal, Type, Price, Valid, stock, Expected);
            ProductsForm productform = new ProductsForm();
            productform.OpenForm();
            productform.Show();
            this.Close();
        }
    }
}
