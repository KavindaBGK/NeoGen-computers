using Microsoft.EntityFrameworkCore;
using NeoGen_computers.Models;

namespace NeoGen_computers.Model

{
    public class Computercontext:DbContext
    {
        public Computercontext(DbContextOptions<Computercontext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Clientbilling> Clientbillings { get; set; }
        public DbSet<SellersDetails> SellersDetails { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
    }
}
