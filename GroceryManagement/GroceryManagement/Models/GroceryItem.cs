namespace GroceryManagement.Models
{
    public class GroceryItem
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public int  Price { get; set; }
        public bool IsAvailable { get; set; }
    }
}
