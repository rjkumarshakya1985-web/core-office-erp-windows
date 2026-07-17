using System.ComponentModel;

namespace CoreOffice.Win.Shared.Controls
{
    public class ERPShortcutItem : UserControl
    {
        private readonly ERPShortcutKey key;
        private readonly Label lblText;

        public ERPShortcutItem()
        {
            AutoSize = true;
            Margin = new Padding(6, 4, 14, 4);

            key = new ERPShortcutKey();
            key.Location = new Point(0, 0);

            lblText = new Label
            {
                AutoSize = true,
                Location = new Point(key.Right + 6, 3),
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.FromArgb(70, 70, 70)
            };

            Controls.Add(key);
            Controls.Add(lblText);

            Height = 24;
        }

        [Category("ERP")]
        [DefaultValue(false)]
        public string Shortcut
        {
            get => key.KeyText;
            set
            {
                key.KeyText = value;
                lblText.Left = key.Right + 6;
                Width = lblText.Right;
            }
        }

        [Category("ERP")]
        [DefaultValue(false)]
        public string Description
        {
            get => lblText.Text;
            set
            {
                lblText.Text = value;
                Width = lblText.Right;
            }
        }
    }
}