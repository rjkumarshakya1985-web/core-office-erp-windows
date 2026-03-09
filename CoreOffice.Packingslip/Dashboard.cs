using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreOffice.Packingslip
{
    public partial class Dashboard : Form
    {
        public Dashboard(string User)
        {
            InitializeComponent();
            this.user = User;
        }
        string user = string.Empty;
        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
          lblWelcome.Text = $"Welcome {user}!";
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
