﻿namespace P06_Interface
{
    public class ProductService
    {
        public ProductManagement ProductManagement { get; set; }
        public ProductService()
        {
            ProductManagement = new ProductManagement();
        }
        public void GenerateProduct(int number = 1)
        {
            Random random = new Random();
            for (int i = 1; i <= number; i++)
            {
                ProductManagement.AddProcuct(new Product
                {
                    Id = i,
                    Name = "Coffe-" + i,
                    Price = random.Next(10, 200),
                    Category = random.Next(1, 6),
                });
            }
        }
        public void DisplayProduct()
        {
            foreach (var item in ProductManagement.GetProducts())
            {
                Console.WriteLine($"{item.Id,5} {item.Name,-10} {item.Price,5}");
            }
        }
        public List<Product> OrderByPrice()
        {
            var sort = ProductManagement.Products.OrderBy(x => x.Price).ToList();
            return sort;
        }
        public List<TempGroup> GroupByPrice()
        {
            var temp = new List<TempGroup>();
            int tempGr = 0;
            foreach (var item in OrderByPrice())
            {
                tempGr = item.Price switch
                {
                    <= 100 => 1,
                    <= 200 => 2,
                    _ => 3,
                };
                temp.Add(new TempGroup { group = tempGr, category = item.Category });
            }
            return temp;
        }
        public void DisplayGroupByPrice()
        {
            var numOfGroup = GroupByPrice().GroupBy(p => p.group);
            foreach (var item in numOfGroup)
            {
                Console.Write($"{NameOfPrice(item.Key),8}");
                for (int i = 1; i <= 5; i++)
                {
                    Console.Write($"| {item.Count(p => p.category.Equals(i)),5}     ");
                }
                Console.WriteLine();
            }
        }
        public string NameOfPrice(int price)
        {
            return price switch
            {
                1 => "10-100",
                2 => "101-200",
                _ => " ",
            };
        }
    }
    public class TempGroup
    {
        public int group { get; set; }
        public int category { get; set; }
    }
}
