namespace P04_Polimorphism.Models
{
    internal class ComsAccount : BankAccount
    {
        public decimal Interest { get; set; }
        public void DisplayAccount(char select)
        {
            if (select == 'A')
            {
                //base กลับไปใช้ของแม่
                Console.WriteLine(base.GetBalance());
            }
            else
            {
                Console.WriteLine(GetBalance());
            }
        }
        //Overide method
        public override string GetBalance()
        {
            return $"This account from ComsAccount is {AccountHolder} \n" +
                $"has money {Balance} Baht \n Interest = {Interest}";
        }
        public void CalInterest(double rate = 0.0)
        {
            Interest = Balance * (decimal)rate;
        }
    }
}
