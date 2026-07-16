using CoreOffice.Win.Shared;
using CoreOffice.Win.Shared.Controls;
using CoreOffice.Win.Shared.Theme;
using System.ComponentModel;

namespace CoreOffice.Win.Shared
{
    public class BaseForm : Form
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool SkipCloseConfirmation { get; set; }
        public BaseForm()
        {
            KeyPreview = true;
            StartPosition = FormStartPosition.CenterScreen;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
           // ApplyTheme(this);

        }
       // protected virtual void ApplyTheme(Control parent)
       // {
       //     foreach (Control control in parent.Controls)
       //     {
       //         switch (control)
       //         {
       //             case Label lbl:
       //                 lbl.ForeColor = ERPTheme.PrimaryColor;
       //                 lbl.Font = ERPTheme.NormalFont;
       //                 break;

       //             case TextBox txt:
       //                 txt.Font = ERPTheme.TextBoxFont;
       //                 txt.BorderStyle = BorderStyle.FixedSingle;
       //                 break;
       //             case ComboBox cmb:
       //                 cmb.Font = ERPTheme.TextBoxFont;
       //                 cmb.FlatStyle = FlatStyle.Flat;
       //                 break;

       //             case Button btn:
       //                 btn.Font = ERPTheme.ButtonFont;
       //                 break;

       //             case DataGridView dgv:
       //                 ApplyGridTheme(dgv);
       //                 break;
       //         }
       //         if (control.HasChildren)
       //             ApplyTheme(control);
       //     }

       //     BackColor = ERPTheme.FormBackColor;
       //     Font = ERPTheme.NormalFont;
       // }
       //private static void ApplyGridTheme(DataGridView grid)
       // {
       //     grid.EnableHeadersVisualStyles = false;

       //     grid.ColumnHeadersDefaultCellStyle.BackColor = ERPTheme.PrimaryColor;
       //     grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
       //     grid.ColumnHeadersDefaultCellStyle.Font = ERPTheme.GridHeaderFont;

       //     grid.DefaultCellStyle.Font = ERPTheme.GridFont;

       //     grid.AlternatingRowsDefaultCellStyle.BackColor =
       //         ERPTheme.GridAlternateRowBackColor;
       // }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Global Shortcuts

            if (keyData == (Keys.Control | Keys.S))
            {
                _ = SaveAsync();   // Fire and forget from keyboard
                return true;              
            }           

            if (keyData == Keys.F4)
            {
                OpenRecord();
                return true;
            }
            if (keyData == (Keys.Alt | Keys.V))
            {
                OpenVisitor();
                return true;
            }
            if (keyData == (Keys.Alt | Keys.C))
            {
                OpenCustomer();
                return true;
            }
            if (keyData == (Keys.Control | Keys.R))
            {
                ResetForm();
                return true;
            }
            if (keyData == (Keys.Control | Keys.D))
            {
                _ = DeleteAsync();
                return true;
            }
            if (keyData == Keys.Escape)
            {
                CloseForm();
                return true;
            }
            if (keyData == Keys.Enter)
            {
                Control? control = ActiveControl;
                
                // If focus is inside ERPTextBox
                if (control is ERPTextBox erpTextBox)
                {
                    if (erpTextBox.Multiline)
                        return base.ProcessCmdKey(ref msg, keyData);

                    SelectNextControl(erpTextBox, true, true, true, true);
                    return true;
                }
                // Standard TextBox
                if (control is TextBox tb)
                {
                    if (tb.Multiline)
                        return base.ProcessCmdKey(ref msg, keyData);

                    SelectNextControl(tb, true, true, true, true);
                    return true;
                }

                // ComboBox
                if (control is ComboBox cmb)
                {
                    SelectNextControl(cmb, true, true, true, true);
                    return true;
                }
                // ERPButton
                if (control is ERPButton erpButton)
                {
                    erpButton.PerformClick();
                    return true;
                }
                // Standard Button
                if (control is Button btn)
                {
                    btn.PerformClick();
                    return true;
                }
                // Allow Enter in DataGridView
                if (control is DataGridView)
                    return base.ProcessCmdKey(ref msg, keyData);

                // Move to next control
                SelectNextControl(control, true, true, true, true);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
       
        protected bool ValidateControls()
        {
            var controls = GetAllControls(this)
                .OfType<ERPTextBox>()
                .OrderBy(c => c.TabIndex);

            foreach (var txt in controls)
            {
                if (!txt.ValidateControl())
                {
                    txt.Focus();
                    return false;
                }
            }

            return true;
        }

        private IEnumerable<Control> GetAllControls(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                yield return control;

                foreach (Control child in GetAllControls(control))
                    yield return child;
            }
        }
        protected virtual Task SaveAsync()
        {
            // Override in child forms
            return Task.CompletedTask;
        }
        protected virtual Task DeleteAsync()
        {
            return Task.CompletedTask;
        }
        protected virtual void CloseForm()
        {
            Close();
        }
        protected virtual void OpenRecord()
        {
        }
        protected virtual void OpenVisitor()
        {
        }
        protected virtual void OpenCustomer()
        {
        }
        protected virtual void ResetForm()
        {
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (SkipCloseConfirmation)
            {
                base.OnFormClosing(e);
                return;
            }           
            // Ignore if application itself is exiting
            if (e.CloseReason == CloseReason.ApplicationExitCall ||  e.CloseReason == CloseReason.WindowsShutDown)
            {
                base.OnFormClosing(e);
                return;
            }

            var result = MessageBox.Show(
                "Are you sure you want to close this window?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }

            base.OnFormClosing(e);
        }
    }
}