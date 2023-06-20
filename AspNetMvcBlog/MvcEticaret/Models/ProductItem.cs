namespace MvcEticaret.Models
{
    public class ProductItem
    {
        public string title { get; set; }
        public double startCount { get; set; }
        public int oldPrice { get; set; }
        public int price { get; set; }
        public int imageUrl { get; set; }
        public int isSale { get; set; }

        //Buradan emin değilim bu IActionResult altında liste içerisinde de yapabilir değerler verip bunu düşünmek lazım.
    }
}
