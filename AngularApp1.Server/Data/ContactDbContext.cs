using AngularApp1.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace AngularApp1.Server.Data
{
    public class ContactDbContext : DbContext
    {
        public ContactDbContext(DbContextOptions options): base(options) {  }

        public DbSet<ContactDetails> ContactDetails { get; set; }

    }
}
