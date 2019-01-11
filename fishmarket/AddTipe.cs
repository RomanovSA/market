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
    public partial class AddTipe : Form
    {
        public AddTipe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string category = tbCategory.Text;
            string opisan = tbOpisan.Text;

            DataTipe.Insert(category, opisan);
            TipeForm orderform = new TipeForm();
            orderform.OpenForm();
            orderform.Show();
            this.Close();
        }
    }
}
