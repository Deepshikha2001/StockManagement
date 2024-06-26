namespace StockManagement.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public int AvailQuantity { get; set;}
        public Status Status { get; set;}
    }
    
}

namespace StockManagement
{
    public enum Status
    {
        Ok, Defective
    }
}