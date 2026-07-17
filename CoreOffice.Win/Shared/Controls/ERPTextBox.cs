using System.ComponentModel;
using CoreOffice.Win.Shared.Theme;

namespace CoreOffice.Win.Shared.Controls
{
    [DefaultEvent("TextChanged")]
    public class ERPTextBox : UserControl
    {
        private readonly ERPLabel lblCaption;
        private readonly ERPBorderPanel pnlBorder;
        private readonly ERPIcon picIcon;
        private readonly TextBox txtValue;
        public event KeyEventHandler? EnterKeyPressed;
        public ERPTextBox()
        {
            SuspendLayout();

            BackColor = Color.Transparent;
            Size = new Size(280, 56);

            lblCaption = new ERPLabel
            {
                Dock = DockStyle.Top,
                Height = 18,
                Text = "Caption",
                LabelType = ERPLabelType.Normal
            };

            pnlBorder = new ERPBorderPanel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(8, 6, 8, 6)
            };

            picIcon = new ERPIcon
            {
                Dock = DockStyle.Left,
                Width = 26,
                IconType = ERPIconType.None
            };

            txtValue = new TextBox
            {
                BorderStyle = BorderStyle.None,
                Dock = DockStyle.Fill,
                Font = ERPFonts.TextBox,
                BackColor = Color.White
            };

            pnlBorder.Controls.Add(txtValue);
            pnlBorder.Controls.Add(picIcon);

            Controls.Add(pnlBorder);
            Controls.Add(lblCaption);

            txtValue.Enter += TxtValue_Enter;
            txtValue.Leave += TxtValue_Leave;
            txtValue.TextChanged += TxtValue_TextChanged;
            txtValue.KeyDown += TxtValue_KeyDown;
            ResumeLayout(false);
        }

        #region Events
        [Category("ERP")]
        [DefaultValue(false)]
        public bool InterceptEnterKey { get; set; }
        public TextBox GetTextBox()
        {
            return txtValue;
        }
        public bool ValidateControl()
        {
            if (!Required)
            {
                HasError = false;
                return true;
            }

            bool isValid = !string.IsNullOrWhiteSpace(Text);

            HasError = !isValid;

            if (!isValid)
                Focus();

            return isValid;
        }
        private void TxtValue_TextChanged(object? sender, EventArgs e)
        {
            OnTextChanged(e);
        }

        private void TxtValue_Enter(object? sender, EventArgs e)
        {
            pnlBorder.IsFocused = true;
            picIcon.ForeColor = ERPColors.Primary;
        }
        private void TxtValue_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EnterKeyPressed?.Invoke(this, e);
            }
        }
        private void TxtValue_Leave(object? sender, EventArgs e)
        {
            pnlBorder.IsFocused = false;

            if (!HasError)
                picIcon.ForeColor = ERPColors.Primary;
        }

        #endregion

        #region Properties

        [Category("ERP")]
        [DefaultValue(false)]
        public string Caption
        {
            get => lblCaption.Text;
            set => lblCaption.Text = value;
        }

        [Category("ERP")]
        [DefaultValue(false)]
        public ERPIconType Icon
        {
            get => picIcon.IconType;
            set => picIcon.IconType = value;
        }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Bindable(true)]
        [Category("Appearance")]
        [Description("Gets or sets the text associated with the control.")]
        public override string Text
        {
            get => txtValue.Text;
            set => txtValue.Text = value;
        }

        [Category("ERP")]
        [DefaultValue(false)]
        public char PasswordChar
        {
            get => txtValue.PasswordChar;
            set => txtValue.PasswordChar = value;
        }

        [Category("ERP")]
        [DefaultValue(false)]
        public bool Multiline
        {
            get => txtValue.Multiline;
            set
            {
                txtValue.Multiline = value;

                if (value)
                {
                    txtValue.Dock = DockStyle.Fill;
                    Height = 100;
                }
            }
        }

        [Category("ERP")]
        [DefaultValue(false)]
        public bool ReadOnly
        {
            get => txtValue.ReadOnly;
            set
            {
                txtValue.ReadOnly = value;
                txtValue.BackColor = value ? ERPColors.ReadOnly : Color.White;
            }
        }

        [Category("ERP")]
        [DefaultValue(false)]
        public bool UseSystemPasswordChar
        {
            get => txtValue.UseSystemPasswordChar;
            set => txtValue.UseSystemPasswordChar = value;
        }

        [Category("ERP")]
        [DefaultValue(false)]
        public HorizontalAlignment TextAlign
        {
            get => txtValue.TextAlign;
            set => txtValue.TextAlign = value;
        }

        [Category("ERP")]
        [DefaultValue(false)]
        public int MaxLength
        {
            get => txtValue.MaxLength;
            set => txtValue.MaxLength = value;
        }

        [Category("ERP")]
        [DefaultValue(false)]
        public bool Required
        {
            get => lblCaption.Required;
            set => lblCaption.Required = value;
        }

        [Browsable(false)]
        public TextBox InnerTextBox => txtValue;

        private bool _hasError;

        [Category("ERP")]
        [DefaultValue(false)]
        public bool HasError
        {
            get => _hasError;
            set
            {
                _hasError = value;

                pnlBorder.HasError = value;

                picIcon.ForeColor = value
                    ? ERPColors.Danger
                    : ERPColors.Primary;
            }
        }
        [Category("ERP")]
        [DefaultValue(false)]
        public string Placeholder
        {
            get => txtValue.PlaceholderText;
            set => txtValue.PlaceholderText = value;
        }
        [Category("ERP")]
        [DefaultValue(false)]
        public CharacterCasing CharacterCasing
        {
            get => txtValue.CharacterCasing;
            set => txtValue.CharacterCasing = value;
        }
        [Category("Appearance")]
        [DefaultValue(false)]
        public override Font Font
        {
            get => txtValue.Font;
            set
            {
                base.Font = value;
                txtValue.Font = value;

                txtValue.Height = TextRenderer.MeasureText("A", value).Height + 4;
            }
        }
        [Category("Appearance")]
        [DefaultValue(false)]
        public Font LabelFont
        {
            get => lblCaption.Font;
            set
            {
                lblCaption.Font = value;

                // Auto adjust label height
                lblCaption.Height = TextRenderer.MeasureText("A", value).Height + 4;
            }
        }
        #endregion

        #region Methods

        public new bool Focus()
        {
            bool result = txtValue.Focus();

            pnlBorder.IsFocused = true;
            picIcon.ForeColor = ERPColors.Primary;

            return result;
        }
        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);

            txtValue.Focus();
        }
        public void SelectAll()
        {
            txtValue.SelectAll();
        }

        public void Clear()
        {
            txtValue.Clear();
        }

        #endregion
    }
}