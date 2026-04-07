using CoreOffice.Win.Modules.PackingSlip;
using CoreOffice.Win.Session;
using CoreOffice.Win.Shared;
using CoreOfficeERP.Application.Interfaces;
using CoreOfficeERP.Common.Enums;
using CoreOfficeERP.Domain.Responses.PackingSlip;
using System.Threading.Tasks;

namespace CoreOffice.Win.Modules.Shared
{
    public partial class PendingPackingSlipForm : Form
    {
        private readonly IPackingSlipService _packingSlipService;
        public FrmPackingSlip _frmPackingSlip;
        private List<PackingSlipResponse> list;
        public PendingPackingSlipForm(IPackingSlipService packingSlipService)
        {
            InitializeComponent();
            _packingSlipService = packingSlipService;


        }

        private async Task LoadPackingSlips()
        {
            try
            {
                dataGrid.Rows.Clear();
                var financeYearId = UserSession.FinanceYearId == 0
                    ? (int?)null
                    : UserSession.FinanceYearId;

                AppLoader.Show();
                var pendingPackingSlips = await _packingSlipService
                    .GetPendingPackingSlipForBilling(financeYearId);

                dataGrid.Rows.Clear();

                if (pendingPackingSlips == null || !pendingPackingSlips.Any())
                    return;


                list = pendingPackingSlips.ToList(); // store in class-level variable for later use
                foreach (var item in pendingPackingSlips)
                {
                    dataGrid.Rows.Add(
                        item.Id,
                        item.Date.ToString("dd-MM-yyyy hh:mm tt"),
                        item.Visitor?.Name ?? "",
                        item.SlipNumber,
                        item.TotalQuantity,
                        item.TotalAmount.ToString("N2")
                    );
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading packing slips: {ex.Message}");
            }
            finally
            {
                AppLoader.Hide();
            }
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private int? GetSelectedPackingSlipId()
        {
            if (dataGrid.CurrentRow == null)
            {
                MessageBox.Show("Please select a row");
                return null;
            }

            return Convert.ToInt32(dataGrid.CurrentRow.Cells["Id"].Value); // 👈 Id column index
        }

        private DataGridViewRow? GetRowByPackingSlipId(int id)
        {
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                if (row.Cells["Id"].Value != null &&
                    Convert.ToInt32(row.Cells["Id"].Value) == id)
                {
                    return row;
                }
            }

            return null;
        }

        private async void PendingPackingSlipForm_Load(object sender, EventArgs e)
        {

            dataGrid.Columns["Date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            if (UserSession.RoleEnum == RoleEnum.Cashier)
            {
                btnDelete.Visible = false;
                btnEdit.Visible = false;
                this.WindowState = FormWindowState.Maximized;
            }
            await LoadPackingSlips();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var id = GetSelectedPackingSlipId();
            if (id == null) return;

            MessageBox.Show($"Print Packing Slip: {id}");

        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var id = GetSelectedPackingSlipId();
            if (id == null) return;

            var confirm = MessageBox.Show(
                "Are you sure you want to delete this packing slip?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            try
            {
                AppLoader.Show();

                var status = await _packingSlipService.DeleteAsync(id.Value);

                if (!status)
                {
                    MessageBox.Show("Failed to delete packing slip");
                    return;
                }

                //  Row find
                var row = GetRowByPackingSlipId(id.Value);
                if (row == null)
                {
                    // fallback (rare case)
                    await LoadPackingSlips();
                    return;
                }

                int index = row.Index;

                // Remove row
                dataGrid.Rows.RemoveAt(index);

                // Select next row safely
                if (dataGrid.Rows.Count > 0)
                {
                    int newIndex = Math.Min(index, dataGrid.Rows.Count - 1);

                    dataGrid.ClearSelection();
                    dataGrid.Rows[newIndex].Selected = true;
                    dataGrid.CurrentCell = dataGrid.Rows[newIndex].Cells[0];
                }

                MessageBox.Show("Packing slip deleted successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                AppLoader.Hide();
            }
        }

        private async Task LoadPackingSlipAsync(int id)
        {
            try
            {
                AppLoader.Show();

                var packingSlip = await _packingSlipService.GetByIdAsync(id);

                if (packingSlip == null)
                {
                    MessageBox.Show(
                        "Packing slip not found.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    _frmPackingSlip?.Clear();
                    return;
                }

                _frmPackingSlip.LoadPackingSlip(packingSlip);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                _frmPackingSlip?.Clear();
            }
            finally
            {
                AppLoader.Hide();
            }
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            var id = GetSelectedPackingSlipId();
            if (id == null || _frmPackingSlip == null) return;

            await LoadPackingSlipAsync(id.Value);
        }

        private async void btnShow_Click(object sender, EventArgs e)
        {
            var id = GetSelectedPackingSlipId();
            if (id == null || _frmPackingSlip == null) return;

            if (UserSession.RoleEnum == RoleEnum.PackingSlipOperator)
            {
                await LoadPackingSlipAsync(id.Value); //  Edit mode
                return;
            }

            //  View mode (future)
            MessageBox.Show($"View Packing Slip: {id}");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
