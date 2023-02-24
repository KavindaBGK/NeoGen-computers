using System.ComponentModel.DataAnnotations;

namespace NeoGen_computers.Models
{
    public class Supplier
    {
        [Key]
        public int Supplier_Id { get; set; }
        public string Supplier_Name { get; set; }
        public string ContactName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }

        public ICollection<Product> Products { get; set; } // Navigation property
    }
}

