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
    public partial class TovarPoTipForm : Form
    {
        public TovarPoTipForm()
        {
            InitializeComponent();
        }
        public void OpenForm()
        {
            DataTovarPoTip.Load();
            DataTable dt = DataTovarPoTip.DBOperation();
            DataView dv = new DataView(dt);
            bindingSource1.DataSource = dv;
            dataGridView1.DataSource = bindingSource1;
        }
    }
}
