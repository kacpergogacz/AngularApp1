using AngularApp1.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace AngularApp1.Server.Data
{
    public class ContactDbContext : DbContext
    {
        public ContactDbContext(DbContextOptions options): base(options) {  }

        // DbSet który reprezentuje set/liste kontaktow ContactDetails w bazie danych
        public DbSet<ContactDetails> ContactDetails { get; set; }

    }
}
