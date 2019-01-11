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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btProducts_Click(object sender, EventArgs e)
        {
            MainContr.ProductForm();
        }

        private void btOrders_Click(object sender, EventArgs e)
        {
            MainContr.OrdersForm();
        }

        private void btProviders_Click(object sender, EventArgs e)
        {
            MainContr.ProvidersForm();
        }

        private void btRequest_Click(object sender, EventArgs e)
        {
            MainContr.RequestForm();
        }

        private void btTipe_Click(object sender, EventArgs e)
        {
            MainContr.TipeForm();
        }
    }
}
