namespace DishesApp.Models
{
    public class Product
    {
        public required string ArticleNumber { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string Category { get; set; }
        public required byte[] Photo { get; set; }
        public required string Manufacturer { get; set; }
        public required double Cost { get; set; }
        public required int DiscountAmount { get; set; }
        public required int QuantityInStock { get; set; }
        public required string Status { get; set; }
    }
}
