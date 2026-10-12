namespace HarvestAdminn.Models
{
    public class LoginResponse
    {
        public bool status { get; set; }

        public string access_token { get; set; } = "";

        public string token_type { get; set; } = "";

        public UserData data { get; set; } = new();
    }

    public class UserData
    {
        public string id { get; set; } = "";

        public string name { get; set; } = "";

        public string email { get; set; } = "";

        public string role { get; set; } = "";
    }
}