using Shop2.Doming.Entities.Categories;

namespace Shop2.Doming.Entities.Products
{
    public class Product
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public int price { get; set; }
        public string description { get; set; }
        public string ImagePath { get; set; }
        public string IsDelete { get; set; }
        public long CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
