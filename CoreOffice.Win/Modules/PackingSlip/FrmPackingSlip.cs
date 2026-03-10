using CoreOfficeERP.Application.Interfaces;
using CoreOfficeERP.Domain.Requests.PackingSlip;
using System.Threading.Tasks;

namespace CoreOffice.Win.Modules.PackingSlip
{
    public partial class FrmPackingSlip : Form
    {
        private readonly IPackingSlipService _packingSlipService;

        public FrmPackingSlip(IPackingSlipService packingSlipService)
        {
            InitializeComponent();
            _packingSlipService = packingSlipService;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var packingSlipItems = new List<PackingSlipItemRequest>()
            {
                new PackingSlipItemRequest()
                {
                    Id = 0,
                    PackingSlipId = 0,
                    StockId =new Guid("923D15E1-31A0-4201-926B-1F3A6E5A4C9A"),
                    SaleRate =6300.00M,
                    Qty = 2

                }
            };
            var packingSlipRequest = new PackingSlipRequest()
            {
                Id = 0,
                Items = packingSlipItems,
            };

            try
            {
                var packingSlipId = await _packingSlipService.CreateAsync(packingSlipRequest);
                MessageBox.Show($"Packing Slip Created: {packingSlipId}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
        }
    }
}
