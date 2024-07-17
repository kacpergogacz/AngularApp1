using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace AngularApp1.Server.Models
{
    public class Login
    {
        public string Email { get; set; }

        public string Password { get; set; }
    }
}
