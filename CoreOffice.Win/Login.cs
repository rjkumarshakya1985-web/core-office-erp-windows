using CoreOffice.Win.Modules.PackingSlip;
using CoreOffice.Win.Shared;
using CoreOfficeERP.Application.Interfaces;
using CoreOfficeERP.Common.Enums;
using CoreOfficeERP.Domain;
using CoreOfficeERP.Infrastructure.Auth;

namespace CoreOffice.Win
{
    public partial class Login : Form
    {
        private readonly IAuthService _authService;
        private readonly ITokenProvider _tokenProvider;
        private readonly IMasterService _masterService;
        private readonly IServiceProvider _serviceProvider;

        //  Constructor injection
        public Login(IServiceProvider serviceProvider,IAuthService authService, IMasterService masterService, ITokenProvider tokenProvider)
        {
            InitializeComponent();
            _authService = authService;
            _masterService = masterService;
            _tokenProvider = tokenProvider;
            _serviceProvider = serviceProvider;
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
            try
            {
                AppLoader.Show();

                var request = new LoginRequestDto();
                request.Username = txtUser.Text.Trim();
                request.Password = txtPwd.Text.Trim();
              //  request.Username = "Raj Operator";
              //  request.Password = "RajOperator123";
                request.clientType = (int)ClientType.Web;

                var response = await _authService.LoginAsync(request);

                if (response != null && response.IsLoginFailed)
                {
                    // Set token
                    _tokenProvider.SetToken(response.Token);

                    if (response.RoleName == RoleEnum.PackingSlipOperator.ToString())
                    {
                        var dashboard = new MDIPackingSlip(_serviceProvider);
                        dashboard.Show();
                        this.Hide();
                    }
                    else if (response.RoleName == RoleEnum.Cashier.ToString())
                    {
                        this.Hide();
                    }
                    else if (response.RoleName == RoleEnum.StockIncharge.ToString())
                    {
                        var dashboard = new MDIPackingSlip(_serviceProvider);
                        dashboard.Show();
                        this.Hide();                        
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                AppLoader.Hide();
            }
        }
        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please reach out us");
        }
    }
}
