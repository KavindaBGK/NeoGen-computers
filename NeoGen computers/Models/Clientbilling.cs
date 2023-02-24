using System.ComponentModel.DataAnnotations;

namespace NeoGen_computers.Models
{
    public class Clientbilling
    {
        [Key]
        public int Billing_Number { get; set; }
        public string customer_Name { get; set; }
        public string Product_Name { get; set; }
        public int Price { get; set; }
        public int Product_Quntity { get; set; }
        public string Oder_date { get; set; }
        public int Ammount { get; set; }

        public int ProductId { get; set; } // Foreign key
        public Product Product { get; set; } // Navigation property


    }
}
