using CoreOfficeERP.Application.Interfaces;
using CoreOfficeERP.Domain;
using CoreOfficeERP.Infrastructure.Auth;
using System.Threading.Tasks;

namespace CoreOffice.Win
{
    public partial class Form1 : Form
    {

        private readonly IAuthService _authService;
        private readonly ITokenProvider _tokenProvider;
        private readonly IMasterService _masterService;

        //  Constructor injection
        public Form1(IAuthService authService, IMasterService masterService, ITokenProvider tokenProvider)
        {
            InitializeComponent();
            _authService = authService;
            _masterService = masterService;
            _tokenProvider = tokenProvider;
        }



        private async void Form1_Load(object sender, EventArgs e)
        {
            var request = new LoginRequestDto();
            request.Username = "admin";
            request.Password = "admin@123";
            request.clientType = 0;
            var response = await _authService.LoginAsync(request);

            if (response != null && response.IsLoginFailed)
            {
                MessageBox.Show($"Login Successful! Welcome {request.Username}");

                //  Set token for later use
                _tokenProvider.SetToken(response.Token);

                //// Open dashboard or next form
                //var dashboard = new DashboardForm();
                //dashboard.Show();
                //this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
          var department = await  _masterService.GetAllDepartmentsAsync();
        }
    }
}
