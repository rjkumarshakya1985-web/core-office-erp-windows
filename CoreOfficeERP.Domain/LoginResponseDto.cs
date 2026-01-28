using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOfficeERP.Domain
{
    public class LoginResponseDto
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }

        public string RoleName { get; set; }

        public string UserName { get; set; }

        public bool IsLoginFailed { get; set; }

        public string Message { get; set; }
    }
}
