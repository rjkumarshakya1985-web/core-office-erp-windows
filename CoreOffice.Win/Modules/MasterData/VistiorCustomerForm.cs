namespace CoreOffice.Win.Modules.MasterData
{
    public partial class VistiorCustomerForm : Form
    {
        public int? VisitorId;
      
        public VistiorCustomerForm()
        {
            InitializeComponent();
           
        }

        public void LoadVisitor(int visitorId)
        {
            VisitorId = visitorId;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            // TODO: your logic
        }

        private void VistiorCustomerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
