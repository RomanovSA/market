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
    public partial class AddOrder : Form
    {
        public AddOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string customer = tbCustomer.Text;
            string map = tbMap.Text;
            string employee = tbEmployee.Text;
            string courier = tbCourier.Text;
            string accommodation = tbAccommodation.Text;
            string purpose = tbPurpose.Text;
            string execution = tbExecution.Text;

            DataOrder.Insert(customer, map, employee, courier, accommodation, purpose, execution);
            OrderForm orderform = new OrderForm();
            orderform.OpenForm();
            orderform.Show();
            this.Close();
        }
    }
}
