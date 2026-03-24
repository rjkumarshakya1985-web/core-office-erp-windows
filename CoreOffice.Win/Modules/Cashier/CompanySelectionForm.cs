using CoreOffice.Win.Session;
using CoreOffice.Win.Shared;
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
    public partial class CompanySelectionForm : Form
    {

        private readonly MDICashierParent _mDICashierParent;
        public CompanySelectionForm(MDICashierParent mDICashierParent)
        {
            InitializeComponent();
            _mDICashierParent = mDICashierParent;
        }



        private void btnChange_Click(object sender, EventArgs e)
        {
            UserSession.FinanceYearId = (int)cmbFiananceYear.SelectedValue;
            UserSession.FinanceYearName = cmbFiananceYear.Text;
            _mDICashierParent.UpdateFinanceYear();
            Close();
        }

        private void CompanySelectionForm_Load(object sender, EventArgs e)
        {
            if (AppCache.Companies != null && AppCache.Companies.Any())
            {
                cmbFiananceYear.DataSource = AppCache.Companies;
                cmbFiananceYear.DisplayMember = "Name";
                cmbFiananceYear.ValueMember = "Id";
                cmbFiananceYear.SelectedValue = UserSession.FinanceYearId;
            }
            else
            {
                MessageBox.Show("No companies found");
            }
        }
    }
}
