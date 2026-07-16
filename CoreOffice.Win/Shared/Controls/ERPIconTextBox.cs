using FontAwesome.Sharp;
using System.ComponentModel;

namespace CoreOffice.Win.Shared.Controls;

public class ERPIconTextBox : UserControl
{
    private readonly IconPictureBox picIcon;
    private readonly TextBox txtValue;

    public ERPIconTextBox()
    {
        Height = 38;
        BackColor = Color.White;

        BorderStyle = BorderStyle.FixedSingle;

        picIcon = new IconPictureBox()
        {
            Dock = DockStyle.Left,
            Width = 36,
            IconChar = IconChar.User,
            IconColor = Color.Gray,
            IconSize = 18,
            BackColor = Color.White,
            SizeMode = PictureBoxSizeMode.CenterImage
        };

        txtValue = new TextBox()
        {
            BorderStyle = BorderStyle.None,
            Dock = DockStyle.Fill,
            Margin = new Padding(0),
            Font = new Font("Segoe UI", 10),
            Location = new Point(0, 9)
        };

        Controls.Add(txtValue);
        Controls.Add(picIcon);

        txtValue.KeyDown += TxtValue_KeyDown;
        txtValue.Enter += TxtValue_Enter;
        txtValue.Leave += TxtValue_Leave;
    }
    private void TxtValue_Enter(object? sender, EventArgs e)
    {
        BackColor = Color.White;

        // Optional: blue border when focused
        Invalidate();

        if (txtValue.IsHandleCreated)
        {
            BeginInvoke(new MethodInvoker(() => txtValue.SelectAll()));
        }
    }
    private void TxtValue_Leave(object? sender, EventArgs e)
    {
        Invalidate();
    }
    private void TxtValue_KeyDown(object? sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            e.SuppressKeyPress = true;

            Parent?.SelectNextControl(this, true, true, true, true);
        }
    }

}