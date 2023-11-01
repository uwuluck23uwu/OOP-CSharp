namespace P01_Class
{
    public class Product //แม่แบบ
    {
        //attributes, property คุณสมบัติ
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
        //Default Method get set
        //get อ่านค่า
        //set ใส่ค่า
        
        //=> Lamda, Arrow Function
        public void Display() => Console.WriteLine($"Id => {Id} \nName => {Name} \nPrice => {Price.ToString("#,###.##")} \nAmount => {Amount} \n");
        public List<Product> GenerateProduct(int number = 1)
        {
            var products = new List<Product>();
            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {
                products.Add(new Product
                {
                    Id = i + 1,
                    Name = "Coffee" + (i + 1),
                    Price = r.NextDouble() * 990 + 10,
                    Amount = r.Next(10, 50)
                });
            }
            return products;
        }
    }
}