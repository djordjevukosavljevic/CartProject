namespace RVACart.Models
{
    public class CartItem
    {
        public long ArticleId { get; set; }

        public string ArticleName { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }


        public double Total
        {
            get { return Quantity * Price;}
        }

        public CartItem() { 
        
        }

        public CartItem(Article article)
        {
            ArticleId = article.Id; 
            ArticleName = article.Name;
            Price = article.Price;
            Quantity = 1;

        }

    }
}
