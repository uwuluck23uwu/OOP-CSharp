namespace P06_Interface
{
    public class ProductManagement : IProductManagement
    {
        public List<Product> Products { get; set; }
        public Product Product { get; set; }

        public ProductManagement()
        {
            Products = new List<Product>();
            Product = new Product();
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
            var result = Products.Where(p => p.Name.ToLower().Contains(keyword.ToLower()) || 
            p.Id.Equals(number) || 
            p.Price >= number || 
            p.Category.Equals(number)).ToList();
            return result;
        }

        public void DeleteById(Product product)
        {
            if (product == null) return;
            Products.Remove(product);
        }

        public void UpdateProduct(Product NewProduct, Product OldProduct)
        {
            var index = Products.IndexOf(OldProduct);
            Products.RemoveAt(index);
            Products.Insert(index, NewProduct);
        }

        public Product InputProduct(Product product)
        {
            Console.WriteLine("Product Id : " + product.Id);

            Console.Write("Input Name : ");
            product.Name = Console.ReadLine();

            Console.Write("Input Price : ");
            product.Price = double.Parse(Console.ReadLine());

            Console.Write("Input Category : ");
            product.Category = int.Parse(Console.ReadLine());

            return product;
        }
    }
}
