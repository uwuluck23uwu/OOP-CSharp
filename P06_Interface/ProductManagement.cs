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

        public Product GetProductById(int productId)
        {
            //แบบเต็ม
            //  Products.Where(p => p.Id == productId).FirstOrDefault();
            //แบบหาอันเดี่ยว
            //  Products.FirstOrDefault(p => p.Id == productId);
            //แบบย่อ
            return Products.Find(p => p.Id.Equals(productId));
        }

        public List<Product> GetProductByAny(int number = 0, string keyword = "")
        {
            if (String.IsNullOrEmpty(keyword)) keyword = "XXX";
            var result = Products.Where(p => p.Name.ToLower().Contains(keyword) || 
            p.Id.Equals(number) || 
            p.Price >= number || 
            p.Category.Equals(number)).ToList();
            return result;
        }
    }
}
