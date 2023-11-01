using P03_Encapsulate;

namespace PO3_Test
{
    //การเรียกใช้ internal ในโปรเจคเดียวกันสามารถทำได้
    public class Test
    {
        //Contructor
        public Test()
        {
            var test = new BankAccount();

            //internal
            test.Rate = 100;
        }
    }
}
