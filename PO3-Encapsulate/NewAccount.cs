namespace P03_Encapsulate
{
    internal class NewAccount : BankAccount
    {
        Id = 1;
        Name = "Test";
        //Private Password สืบทอดไม่ได้
        Rate = 100;
        //Protected สืบทอดได้ แต่เรียกใช้ทางอ้อม
        Money = 100;
    }
    public void WithDraw(int money)
    {
        if (Money > 0 && money <= Money)
        {
            Money -= money;
            Console.WriteLine(Money);
        }
        else
        {
            Console.WriteLine("Cannot Withdraw");
        }
    }
}
