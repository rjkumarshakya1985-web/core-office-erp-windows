using Microsoft.Extensions.DependencyInjection;


namespace CoreOffice.Win.Modules.PackingSlip
{
    public partial class MDIPackingSlip : Form
    {
        private int childFormNumber = 0;

        private readonly IServiceProvider _serviceProvider;

        public MDIPackingSlip(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            var childForm = _serviceProvider.GetRequiredService<FrmPackingSlip>();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

      

        private void MDIPackingSlip_Load(object sender, EventArgs e)
        {

        }

        private void purchaseSynchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Admin.TallySynchPurchase().Show();

        }
    }
}
