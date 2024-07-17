using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AngularApp1.Server.Models
{
    public class ContactDetails
    {
        [Key]
        public int ContactID { get; set; }

        [Column(TypeName = "nvarchar(40)")]
        public string FirstName { get; set; } = "";

        [Column(TypeName = "nvarchar(40)")]
        public string LastName { get; set; } = "";

        [Column(TypeName = "nvarchar(70)")]
        public string Email { get; set; } = "";

        [Column(TypeName = "nvarchar(32)")]
        public string Password { get; set; } = "";

        [Column(TypeName = "nvarchar(16)")]
        public string Category { get; set; } = "";

        [Column(TypeName = "nvarchar(32)")]
        public string SubCategory { get; set; } = "";

        [Column(TypeName = "nvarchar(9)")]
        public string PhoneNumber { get; set; } = "";

        [Column(TypeName = "date")]
        public DateTime BirthDate { get; set; }
    }
}
