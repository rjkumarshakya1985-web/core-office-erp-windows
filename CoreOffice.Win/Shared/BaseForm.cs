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
                Save();
                return true;
            }

            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        protected virtual void Save()
        {
            // Override in child forms
        }
      
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (SkipCloseConfirmation)
            {
                base.OnFormClosing(e);
                return;
            }
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                base.OnFormClosing(e);
                return;
            }
            // Ignore if application itself is exiting
            if (e.CloseReason == CloseReason.ApplicationExitCall)
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