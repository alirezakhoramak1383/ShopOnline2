using Shop2.Doming.Entities.Products;

namespace Shop2.Doming.Entities.Categories
{
    public class Category
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string IsDelete { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
