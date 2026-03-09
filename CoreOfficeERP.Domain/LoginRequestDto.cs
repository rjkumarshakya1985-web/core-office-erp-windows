namespace CoreOfficeERP.Domain
{
    public class LoginRequestDto
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public int clientType { get; set; }= 0;
    }
}
