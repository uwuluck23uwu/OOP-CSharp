using P01_Class;

//Object วัตถุ
Product product = new Product();
Product ton = new Product();
Product sumo = new Product();

product.Id = 1;
product.Name = "Coffee";
product.Price = 10;
product.Amount = 20;

ton.Id = 2;
ton.Name = "Ton";
ton.Price = 10000;
ton.Amount = 1;

sumo.Id = 3;
sumo.Name = "Sumo";
sumo.Price = 10000;
sumo.Amount = 1;

//Reuse ใช้ซ้ำ
Display(product);
Display(ton);
Display(sumo);

void Display(Product p)
{
    Console.WriteLine($"Id => {p.Id} \nName => {p.Name} \nPrice => {p.Price} \nAmount => {p.Amount} \n");
}