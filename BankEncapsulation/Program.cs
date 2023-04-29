using Stripe.Treasury;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var brocksAccount = new BankAccount();

            Console.WriteLine($"How much are u willing to deposit?");

            var AmountToDeposit = double.Parse( Console.ReadLine() );

            brocksAccount.Deposit(AmountToDeposit);

            Console.WriteLine($"Thank you your balance is now {brocksAccount.GetBalance()}");
        }
    }
}
