using CoreOffice.Win.Shared.Theme;

namespace CoreOffice.Win.Shared.Controls
{
    public class ERPShortcutBar : UserControl
    {
        private readonly FlowLayoutPanel flow;

        public ERPShortcutBar()
        {
            Dock = DockStyle.Bottom;
            Height = 34;
            BackColor = Color.FromArgb(248, 249, 251);

            flow = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                WrapContents = false,
                AutoScroll = true,
                Padding = new Padding(10, 4, 10, 4),
                BackColor = BackColor
            };

            Controls.Add(flow);

            Paint += ERPShortcutBar_Paint;
        }

        private void ERPShortcutBar_Paint(object? sender, PaintEventArgs e)
        {
            using Pen pen = new(Color.FromArgb(220, 220, 220));

            e.Graphics.DrawLine(
                pen,
                0,
                0,
                Width,
                0);
        }

        public void AddShortcut(string key, string description)
        {
            flow.Controls.Add(new ERPShortcutItem
            {
                Shortcut = key,
                Description = description
            });
        }

        public void Clear()
        {
            flow.Controls.Clear();
        }
    }
}