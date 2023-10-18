using P01_Class;

//Object วัตถุ
Product product = new Product();
Product ton = new Product();
Product sumo = new Product();

product.Input(new Product { Id = 1, Name = "Coffe", Price = 100, Amount = 10 });
ton.Input(new Product { Id = 2, Name = "Ton", Price = 10000, Amount = 1 });
sumo.Input(new Product { Id = 3, Name = "Sumo", Price = 10000, Amount = 1 });

product.Display();
ton.Display();
sumo.Display();
