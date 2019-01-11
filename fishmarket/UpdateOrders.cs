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
    public partial class UpdateOrders : Form
    {
        public UpdateOrders()
        {
            InitializeComponent();
        }
        public void Zap(string customer, string map, string employee, string courier, string accommodation, string purpose, string execution)
        {
            tbCustomer.Text = customer;
            tbMap.Text = map;
            tbEmployee.Text = employee;
            tbCourier.Text = courier;
            tbAccommodation.Text = accommodation;
            tbPurpose.Text = purpose;
            tbExecution.Text = execution;
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

            DataOrder.Update(customer, map, employee, courier, accommodation, purpose, execution);
            OrderForm orderform = new OrderForm();
            orderform.OpenForm();
            orderform.Show();
            this.Close();
        }
    }
}
