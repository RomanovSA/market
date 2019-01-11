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
    public partial class UpdateTipe : Form
    {
        public UpdateTipe()
        {
            InitializeComponent();
        }
        public void Zap(string category, string opisan)
        {
            tbCategory.Text = category;
            tbOpisan.Text = opisan;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string category = tbCategory.Text;
            string opisan = tbOpisan.Text;

            DataTipe.Update(category, opisan);
            OrderForm orderform = new OrderForm();
            orderform.OpenForm();
            orderform.Show();
            this.Close();
        }
    }
}
