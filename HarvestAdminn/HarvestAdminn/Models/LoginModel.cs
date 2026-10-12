using Newtonsoft.Json;
using System.Web.Helpers;

namespace HarvestAdminn.Models
{
    public class LoginModel
    {
        public string email { get; set; } = "";

        public string password { get; set; } = "";

    }
}
