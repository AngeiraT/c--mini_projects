using Microsoft.EntityFrameworkCore;
using ContactApp.Models;

namespace ContactApp.Models
{
    public class ContactAppContext : DbContext
    {
        public ContactAppContext(DbContextOptions<ContactAppContext> options) : base(options)
        {
            Contacts = Set<Contact>();
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
