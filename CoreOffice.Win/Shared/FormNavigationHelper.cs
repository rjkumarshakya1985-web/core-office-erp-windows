namespace CoreOffice.Win.Shared
{
    public static class FormNavigationHelper
    {
        public static void Attach(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                // Ignore multiline textbox
                if (control is TextBox txt && txt.Multiline)
                    continue;

                control.KeyDown -= Control_KeyDown;
                control.KeyDown += Control_KeyDown;

                // Recursively attach child controls
                if (control.HasChildren)
                    Attach(control);
            }
        }

        private static void Control_KeyDown(object? sender, KeyEventArgs e)
        {
            if (sender is not Control currentControl)
                return;

            // ENTER -> Next control
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                currentControl.Parent?.SelectNextControl(
                    currentControl,
                    true,
                    true,
                    true,
                    true);
            }

            // SHIFT + ENTER -> Previous control
            if (e.KeyCode == Keys.Enter && e.Shift)
            {
                e.SuppressKeyPress = true;

                currentControl.Parent?.SelectNextControl(
                    currentControl,
                    false,
                    true,
                    true,
                    true);
            }
        }
    }
}