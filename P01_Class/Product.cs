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
        public void Display() => Console.WriteLine($"Id => {Id} \nName => {Name} \nPrice => {Price.ToString("###.##")} \nAmount => {Amount} \n");
    }
}
