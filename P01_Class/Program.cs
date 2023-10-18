using P01_Class;
Random r = new Random();

//List ไม่จำกัดจำนวน
List<Product> products = new List<Product>();

for (int i = 0; i < 10; i++)
{
    products.Add(new Product 
    {
        Id = i+1, 
        Name = "Coffee"+(i+1), 
        Price = r.NextDouble() * 990 + 10, 
        Amount = r.Next(10,50) 
    });
}

products.ForEach(p => p.Display());