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
    public partial class TipeForm : Form
    {
        FilterTipe filter = new FilterTipe();
        public TipeForm()
        {
            InitializeComponent();
        }

        public void OpenForm()
        {
            //заполнение datagridview
            DataTipe.Load();
            DataTable dt = DataTipe.DBOperation();
            DataView dv = new DataView(dt);

            bsTipe.DataSource = dv;
            dgvTipe.DataSource = bsTipe;

            //фильтры
            if (dgvTipe.Rows.Count > 0)
            {
                cbCategory.DataSource = dv.ToTable(true, "Категория");
                cbCategory.DisplayMember = "Категория";
                cbCategory.Text = String.Empty;
                btDelCategory.Visible = false;

                cbOpisan.DataSource = dv.ToTable(true, "Описание");
                cbOpisan.DisplayMember = "Описание";
                cbOpisan.Text = String.Empty;
                btDelOpisan.Visible = false;
            }
        }

        private void btDelCategory_Click(object sender, EventArgs e)
        {
            cbCategory.Text = String.Empty;
            btDelCategory.Visible = false;
            cbCategory.Focus();
        }

        private void btDelOpisan_Click(object sender, EventArgs e)
        {
            cbOpisan.Text = String.Empty;
            btDelOpisan.Visible = false;
            cbOpisan.Focus();
        }

        private void cbCategory_TextChanged(object sender, EventArgs e)
        {
            filter.Category = cbCategory.Text.Trim();
            bsTipe.Filter = filter.getBindingText();
            if (cbCategory.Text != String.Empty)
            {
                btDelCategory.Visible = true;
            }
            else btDelCategory.Visible = false;
        }

        private void cbOpisan_TextChanged(object sender, EventArgs e)
        {
            filter.Opisan = cbOpisan.Text.Trim();
            bsTipe.Filter = filter.getBindingText();
            if (cbOpisan.Text != String.Empty)
            {
                btDelOpisan.Visible = true;
            }
            else btDelOpisan.Visible = false;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            string del = dgvTipe.CurrentRow.Cells[0].ToString();
            
            DataTipe.Delete(del);
            OpenForm();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            AddTipe addorder = new AddTipe();
            addorder.ShowDialog();
        }

        private void btChange_Click(object sender, EventArgs e)
        {
            UpdateTipe updateorder = new UpdateTipe();

            string category = dgvTipe.CurrentRow.Cells[1].ToString();
            string opisan = dgvTipe.CurrentRow.Cells[2].ToString();

            updateorder.Zap(category, opisan);
            updateorder.ShowDialog();
        }
    }
}
