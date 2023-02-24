using System.ComponentModel.DataAnnotations;

namespace NeoGen_computers.Models
{
    public class SellersDetails
    {
        [Key]
        public int Seller_Id { get; set; }
        public string Seller_FName { get; set; }
        public string Seller_LName { get; set; }
        public string Email { get; set; }
        public int Mobile_Number { get; set; }
        public string Street { get; set; }
        public string City { get; set; }

        public ICollection<Product> Products { get; set; } // Navigation property
    }
}
