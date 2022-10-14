namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new();
            Console.WriteLine(account.PrintBal());
            account.Deposit(1000);
            Console.WriteLine(account.PrintBal());
            account.Withdraw(100);
            Console.WriteLine(account.PrintBal());

        }
    }
}