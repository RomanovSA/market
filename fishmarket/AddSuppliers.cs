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
    public partial class AddSuppliers : Form
    {
        public AddSuppliers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string region = tbRegion.Text;
            string city = tbCity.Text;
            string adres = tbAdres.Text;
            string tel = tbTel.Text;
            string email = tbEMail.Text;

            DataSuppliers.Insert(name, region, city, adres, tel, email);
            SuppliersForm suppliersform = new SuppliersForm();
            suppliersform.OpenForm();
            suppliersform.Show();
            this.Close();
        }
    }
}
