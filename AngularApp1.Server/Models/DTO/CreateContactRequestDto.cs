using System.ComponentModel.DataAnnotations.Schema;

namespace AngularApp1.Server.Models.DTO
{
    public class CreateContactRequestDto
    {
        public string FirstName { get; set; } = "";

        public string LastName { get; set; } = "";

        public string Email { get; set; } = "";

        public string Password { get; set; } = "";

        public string Category { get; set; } = "";

        public string SubCategory { get; set; } = "";

        public string PhoneNumber { get; set; } = "";

        public DateTime BirthDate { get; set; }
    }
}
