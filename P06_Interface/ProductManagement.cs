namespace P06_Interface
{
    public class ProductManagement : IProductManagement
    {
        public List<Product> Products { get; set; }

        public ProductManagement()
        {
            Products = new List<Product>();
        }

        public void AddProcuct(Product product)
        {
            Products.Add(product);
        }

        public List<Product> GetProducts()
        {
            return Products;
        }
    }
}
