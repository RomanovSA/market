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
    public partial class OrderForm : Form
    {
        FilterOrder filter = new FilterOrder();
        public OrderForm()
        {
            InitializeComponent();
        }

        public void OpenForm()
        {
            DataOrder.Load();
            DataTable dt = DataOrder.DBOperation();
            DataView dv = new DataView(dt);
            bsOrder.DataSource = dv;
            dgvOrder.DataSource = bsOrder;

            //фильтры
            if (dgvOrder.Rows.Count > 0)
            {
                cbCustomer.DataSource = dv.ToTable(true, "Код клиента");
                cbCustomer.DisplayMember = "Код клиента";
                cbCustomer.Text = String.Empty;
                btDelCustomer.Visible = false;

                cbEmployee.DataSource = dv.ToTable(true, "Код сотрудника");
                cbEmployee.DisplayMember = "Код сотрудника";
                cbEmployee.Text = String.Empty;
                btDelEmployee.Visible = false;

                cbCourier.DataSource = dv.ToTable(true, "Код курьера");
                cbCourier.DisplayMember = "Код курьера";
                cbCourier.Text = String.Empty;
                btDelCourier.Visible = false;
            }
        }

        private void btDelCustomer_Click(object sender, EventArgs e)
        {
            cbCustomer.Text = String.Empty;
            btDelCustomer.Visible = false;
            cbCustomer.Focus();
        }

        private void btDelEmployee_Click(object sender, EventArgs e)
        {
            cbEmployee.Text = String.Empty;
            btDelEmployee.Visible = false;
            cbEmployee.Focus();
        }

        private void btDelCourier_Click(object sender, EventArgs e)
        {
            cbCourier.Text = String.Empty;
            btDelCourier.Visible = false;
            cbCourier.Focus();
        }

        private void cbCustomer_TextChanged(object sender, EventArgs e)
        {
            //filter.Customer = cbCustomer.Text.Trim();
            //bsOrder.Filter = filter.getBindingText();
            //if (cbCustomer.Text != String.Empty)
            //{
            //    btDelCustomer.Visible = true;
            //}
            //else btDelCustomer.Visible = false;
        }

        private void cbEmployee_TextChanged(object sender, EventArgs e)
        {
            //filter.Manufacturer = cbEmployee.Text.Trim();
            //bsOrder.Filter = filter.getBindingText();
            //if (cbEmployee.Text != String.Empty)
            //{
            //    btDelEmployee.Visible = true;
            //}
            //else btDelEmployee.Visible = false;
        }

        private void cbCourier_TextChanged(object sender, EventArgs e)
        {
            //filter.Courier = cbCourier.Text.Trim();
            //bsOrder.Filter = filter.getBindingText();
            //if (cbCourier.Text != String.Empty)
            //{
            //    btDelCourier.Visible = true;
            //}
            //else btDelCourier.Visible = false;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            string del = dgvOrder.CurrentRow.Cells[0].ToString();

            DataOrder.Delete(del);
            OpenForm();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            AddOrder addorder = new AddOrder();
            addorder.ShowDialog();
        }

        private void btChange_Click(object sender, EventArgs e)
        {
            UpdateOrders updateorder = new UpdateOrders();
            
            string customer = dgvOrder.CurrentRow.Cells[1].ToString();
            string map = dgvOrder.CurrentRow.Cells[2].ToString();
            string employee = dgvOrder.CurrentRow.Cells[3].ToString();
            string courier = dgvOrder.CurrentRow.Cells[4].ToString();
            string accommodation = dgvOrder.CurrentRow.Cells[5].ToString();
            string purpose = dgvOrder.CurrentRow.Cells[6].ToString();
            string execution = dgvOrder.CurrentRow.Cells[7].ToString();

            updateorder.Zap(customer, map, employee, courier, accommodation, purpose, execution);
            updateorder.ShowDialog();
        }
    }
}
