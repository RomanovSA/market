using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fishmarket
{
    public partial class RequestForm : Form
    {
        public RequestForm()
        {
            InitializeComponent();
        }

        private void btProdPoCl_Click(object sender, EventArgs e)
        {
            ProdPoClForm prodPoClForm = new ProdPoClForm();
            prodPoClForm.OpenForm();
            prodPoClForm.ShowDialog();
        }

        private void btImeTov_Click(object sender, EventArgs e)
        {
            ImeTovForm imeTovForm = new ImeTovForm();
            imeTovForm.OpenForm();
            imeTovForm.ShowDialog();
        }

        private void btTovars_Click(object sender, EventArgs e)
        {
            TovarsForm tovarsForm = new TovarsForm();
            tovarsForm.OpenForm();
            tovarsForm.ShowDialog();
        }

        private void btTovarPoTip_Click(object sender, EventArgs e)
        {
            TovarPoTipForm tovarPoTipForm = new TovarPoTipForm();
            tovarPoTipForm.OpenForm();
            tovarPoTipForm.ShowDialog();
        }
    }
}
