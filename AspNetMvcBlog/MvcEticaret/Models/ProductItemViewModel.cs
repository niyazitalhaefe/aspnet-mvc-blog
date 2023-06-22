namespace MvcEticaret.Models
{
    public class ProductItemViewModel
    {
        public string title { get; set; }
        public int starCount { get; set; }
        public double oldPrice { get; set; }
        public double price { get; set; }
        public string imageUrl { get; set; }
        public bool isSale { get; set; }

    }
}
