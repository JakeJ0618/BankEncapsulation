namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var jakesAcct = new BankAccount();

            jakesAcct.GetBalance();

            Console.WriteLine();
            Console.WriteLine("How much do you want to deposit?");
            var depAmount = double.Parse(Console.ReadLine());

            jakesAcct.Deposit(depAmount);

            Console.WriteLine($"Current Balance: {jakesAcct.GetBalance}");
        }
        
    }
}
