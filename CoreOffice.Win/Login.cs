using CoreOfficeERP.Application.Interfaces;
using CoreOfficeERP.Domain;
using CoreOfficeERP.Infrastructure.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreOffice.Win
{
    public partial class Login : Form
    {
        private readonly IAuthService _authService;
        private readonly ITokenProvider _tokenProvider;
        private readonly IMasterService _masterService;
        //  Constructor injection
        public Login(IAuthService authService, IMasterService masterService, ITokenProvider tokenProvider)
        {
            InitializeComponent();
            _authService = authService;
            _masterService = masterService;
            _tokenProvider = tokenProvider;
        }     
        private void btnMinimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                if (ActiveControl == txtUser) ActiveControl = txtPwd;
                else if (ActiveControl == txtPwd) ActiveControl = btnLogin;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        public async void login()
        {
            var request = new LoginRequestDto();
            request.Username = txtUser.Text.Trim();
            request.Password = txtPwd.Text.Trim();
            request.clientType = 0;
            var response = await _authService.LoginAsync(request);

            if (response != null && response.IsLoginFailed)
            {
                MessageBox.Show($"Login Successful! Welcome {request.Username}");

                //  Set token for later use
                _tokenProvider.SetToken(response.Token);
                if (response.RoleName == "SalesMan")
                {
                    var dashboard = new Packingslip.Dashboard(request.Username);
                    dashboard.Show();
                    this.Hide();
                }
                else if (response.RoleName == "Cashier")
                {
                    var dashboard = new Cashier.Dashboard();
                    dashboard.Show();
                    this.Hide();                    
                }
                else if (response.RoleName == "StockIncharge")
                {
                    var dashboard = new Packingslip.Dashboard(request.Username);
                    dashboard.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }
        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please reach out us");
        }
    }
}
