using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreOffice.Win.Modules.Cashier
{
    public partial class DeliveryChallanListForm : Form
    {
        public DeliveryChallanListForm()
        {
            InitializeComponent();
            cmbPageSize.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
