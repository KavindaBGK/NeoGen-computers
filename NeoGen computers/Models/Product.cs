namespace NeoGen_computers.Models
{
    public class Product
    {

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Price { get; set; }
        public string Discount { get; set; }
        public string ComputerModel { get; set; }
        public string Processor { get; set; }
        public string GraphicMemory { get; set; }
        public string RamSize { get; set; }
        public string Storage { get; set; }
        public string Display { get; set; }
        public string Warranty { get; set; }

        public int SupplierId { get; set; } // Foreign key
        public Supplier Supplier { get; set; } // Navigation property

        public ICollection<Clientbilling> Clientbillings { get; set; } // Navigation property
        public int SellerId { get; set; } // Foreign key
        public SellersDetails SellersDetails { get; set; } // Navigation property

        public int Supplier_Id { get; set; } // Foreign key
        public Supplier Suppliers { get; set; } // Navigation property
    }
}
