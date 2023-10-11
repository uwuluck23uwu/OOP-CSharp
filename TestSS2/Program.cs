string ID = "11";
string Name = "Coffee";
double Price = 10, Amount = 10, Rate1 = 0.5;
Random r = new Random();

//Input();
//Display();
//Update(ref ID, ref Name, ref Price);
//Display();
Rate1 = Cal(out string id, out string name, out double price, out double amount);
ID = id;
Name = name;
Price = price;
Amount = amount;
Display();

Console.WriteLine($"Summary = {Summary(1, 2, 3, 4, 5)}");

void Display()
{
    Console.WriteLine($"\nID => {ID} " +
        $"\nName => {Name} " +
        $"\nPrice = {Price} " +
        $"\nAmount = {Amount} " +
        $"\nSum = {Price * Amount} " +
        $"\nProcess = {Process(Rate1)}%");
}
void Input()
{
    Console.Write("Input ID : ");
    ID = Console.ReadLine();
    Console.Write("Input Name : ");
    Name = Console.ReadLine();
    Console.Write("Input Discount Rate 0 - 1 : ");
    Rate1 = double.Parse(Console.ReadLine());

    Price = r.Next(10, 100);
    Amount = r.Next(1, 10);
}
double Process(double Rate = 0)
{
    var Sum = Price * Amount;
    var Result = Sum - Sum * Rate;
    return Result;
}
void Update(ref string id, ref string name, ref double price)
{
    id += " => [555]";
    name += " => [555]";
    price += 555;
}
double Cal(out string id, out string name, out double price, out double amount)
{
    id = "777";
    name = "Banana";
    price = 5;
    amount = 5;
    return 0.1;
}
double Summary(params int[] numbers)
{
    foreach (var item in numbers)
    {
        Console.Write(item + " ");
    } 
    return numbers.Sum();
}