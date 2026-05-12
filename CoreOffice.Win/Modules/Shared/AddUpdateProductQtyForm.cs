using CoreOfficeERP.Domain.Responses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreOffice.Win.Modules.Shared
{

    public partial class AddUpdateProductQtyForm : Form
    {
        private readonly CurrentStockResponse? _currentStockResponse;
        private readonly bool _isEditMode;

        // Generic callbacks
        public Action<int>? OnQtyUpdate;
        public Action<CurrentStockResponse?, int>? OnQtyCreate;

        public AddUpdateProductQtyForm(
            CurrentStockResponse? currentStockResponse = null,
            bool isEdit = false)
        {
            InitializeComponent();

            _currentStockResponse = currentStockResponse;
            _isEditMode = isEdit;
        }


        private bool ValidateQuantity(out int qty)
        {
            qty = 0;

            if (!int.TryParse(txtProductQty.Text.Trim(), out qty))
            {
                MessageBox.Show("Please enter valid numeric quantity");
                return false;
            }

            int availableQty = _currentStockResponse?.AvailableQty ?? 0;

            if (qty <= 0)
            {
                MessageBox.Show("Quantity must be greater than 0");
                return false;
            }

            if (qty > availableQty)
            {
                MessageBox.Show($"Only {availableQty} items available in stock");
                return false;
            }

            return true;
        }

        private void txtProductQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            e.Handled = true;
            e.SuppressKeyPress = true;

            if (!ValidateQuantity(out int qty))
                return;

            if (_isEditMode)
            {
                // Generic edit callback
                OnQtyUpdate?.Invoke(qty);
            }
            else
            {
                // Generic create callback
                OnQtyCreate?.Invoke(_currentStockResponse, qty);
            }

            this.Close();
        }

    }
}
