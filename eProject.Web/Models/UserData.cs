using System.Collections.Generic;

namespace eProject.Web.Models
{
    public class UserData
    {
        public string Username { get; set; }

        public List<string> Products { get; set; }

        public string SingleProducts { get; set; }
    }
}