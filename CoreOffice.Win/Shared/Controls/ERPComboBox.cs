using CoreOffice.Win.Shared.Theme;
using FontAwesome.Sharp;
using System.ComponentModel;

namespace CoreOffice.Win.Shared.Controls
{
    
    [DefaultEvent(nameof(SelectedIndexChanged))]
    public partial class ERPComboBox : UserControl
    {
        private readonly ERPLabel lblCaption;
        private readonly ERPBorderPanel pnlBorder;
        private readonly ERPIcon picIcon;
        private readonly ComboBox cmbValue;
        public new event EventHandler? SelectedIndexChanged;
        public ERPComboBox()
        {
            lblCaption = new ERPLabel();
            pnlBorder = new ERPBorderPanel();
            picIcon = new ERPIcon
            {
                Dock = DockStyle.Left,
                Width = 26,
                IconType = ERPIconType.None
            };
            cmbValue = new ComboBox();

            InitializeControl();
        }

        private void InitializeControl()
        {
            SuspendLayout();

            // Control
            Size = new Size(280, 70);
            BackColor = Color.Transparent;

            //--------------------------------------
            // Caption
            //--------------------------------------

            lblCaption.Dock = DockStyle.Top;
            lblCaption.Height = 22;
            lblCaption.Text = "Caption";

            //--------------------------------------
            // Border Panel
            //--------------------------------------

            pnlBorder.Dock = DockStyle.Fill;
            pnlBorder.Padding = new Padding(10, 0, 10, 0);

            //--------------------------------------
            // Icon
            //--------------------------------------

            picIcon.IconChar = IconChar.None;
          //  picIcon.IconColor = ERPColors.Placeholder;
           // picIcon.BackColor = Color.Transparent;
            picIcon.IconSize = 26;
            picIcon.Size = new Size(24, 24);
            picIcon.Dock = DockStyle.Left;
            picIcon.SizeMode = PictureBoxSizeMode.CenterImage;

            //--------------------------------------
            // ComboBox
            //--------------------------------------

            cmbValue.Dock = DockStyle.None;
            cmbValue.FlatStyle = FlatStyle.Flat;
            cmbValue.Font = ERPFonts.TextBox;
            cmbValue.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbValue.Location = new Point(34, 4);
            cmbValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbValue.Width = pnlBorder.Width - 40;
            cmbValue.Height = 24;
            cmbValue.BackColor = Color.White;
            cmbValue.Margin = new Padding(0);
            cmbValue.IntegralHeight = false;
            pnlBorder.Resize += (_, __) =>
            {
                cmbValue.Width = pnlBorder.Width - 40;
            };
            //--------------------------------------
            pnlBorder.Controls.Add(picIcon);
            pnlBorder.Controls.Add(cmbValue);
            

            Controls.Add(pnlBorder);
            Controls.Add(lblCaption);
            cmbValue.Enter += CmbValue_Enter;
            cmbValue.Leave += CmbValue_Leave;
            cmbValue.SelectedIndexChanged += CmbValue_SelectedIndexChanged;
            ResumeLayout(false);

        }
        private void CmbValue_Enter(object? sender, EventArgs e)
        {
            pnlBorder.IsFocused = true;
            picIcon.ForeColor = ERPColors.Primary;
        }

        private void CmbValue_Leave(object? sender, EventArgs e)
        {
            pnlBorder.IsFocused = false;

            if (!HasError)
                picIcon.ForeColor = ERPColors.Primary;
        }

        private void CmbValue_SelectedIndexChanged(object? sender, EventArgs e)
        {
            SelectedIndexChanged?.Invoke(this, e);
        }   
        private bool _required;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool Required
        {
            get => _required;
            set
            {
                _required = value;
                UpdateCaption();
            }
        }
        private string _caption = "";

       
        private void UpdateCaption()
        {
            base.Text = Required
                ? _caption + " *"
                : _caption;
        }
        [Category("ERP")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Caption
        {
            get => lblCaption.Text;
            set => lblCaption.Text = value;
        }
        [Category("ERP")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public ERPIconType Icon
        {
            get => picIcon.IconType;
            set => picIcon.IconType = value;
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object? DataSource
        {
            get => cmbValue.DataSource;
            set => cmbValue.DataSource = value;
        }
        [Category("Data")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string DisplayMember
        {
            get => cmbValue.DisplayMember;
            set => cmbValue.DisplayMember = value;
        }
        [Category("ERP")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string ValueMember
        {
            get => cmbValue.ValueMember;
            set => cmbValue.ValueMember = value;
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object? SelectedValue
        {
            get => cmbValue.SelectedValue;
            set => cmbValue.SelectedValue = value;
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object? SelectedItem
        {
            get => cmbValue.SelectedItem;
            set => cmbValue.SelectedItem = value;
        }
        [Category("ERP")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedIndex
        {
            get => cmbValue.SelectedIndex;
            set => cmbValue.SelectedIndex = value;
        }
        [Category("ERP")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public ComboBoxStyle DropDownStyle
        {
            get => cmbValue.DropDownStyle;
            set => cmbValue.DropDownStyle = value;
        }
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get => cmbValue.Text;
            set => cmbValue.Text = value;
        }
        private bool _hasError;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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
        public bool ValidateControl()
        {
            if (!Required)
            {
                HasError = false;
                return true;
            }

            bool valid = cmbValue.SelectedIndex >= 0;

            HasError = !valid;

            if (!valid)
            {
                Focus();
            }

            return valid;
        }
        public new bool Focus()
        {
            return cmbValue.Focus();
        }
        [Browsable(false)]
        public ComboBox InnerComboBox => cmbValue;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public AutoCompleteMode AutoCompleteMode
        {
            get => cmbValue.AutoCompleteMode;
            set => cmbValue.AutoCompleteMode = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public AutoCompleteSource AutoCompleteSource
        {
            get => cmbValue.AutoCompleteSource;
            set => cmbValue.AutoCompleteSource = value;
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new bool Enabled
        {
            get => cmbValue.Enabled;
            set
            {
                cmbValue.Enabled = value;

                pnlBorder.BackColor = value
                    ? Color.White
                    : ERPColors.LightText;
            }
        }
        private bool _readOnly;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool ReadOnly
        {
            get => _readOnly;
            set
            {
                _readOnly = value;

                cmbValue.Enabled = !value;
            }
        }
    }
}