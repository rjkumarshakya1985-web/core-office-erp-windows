using CoreOffice.Win.Shared;
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
           
        }

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
            return base.ProcessCmdKey(ref msg, keyData);
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