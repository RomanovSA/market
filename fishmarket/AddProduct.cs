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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
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
            
            DataProducts.Insert(Manufacturer, Name, Country, Supplier, Animal, Type, Price, Valid, stock, Expected);
            ProductsForm productform = new ProductsForm();
            productform.OpenForm();
            productform.Show();
            this.Close();
        }
    }
}
