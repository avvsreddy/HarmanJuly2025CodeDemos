namespace OODemo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BankAccount acc1 = new BankAccount();

            //acc1.Balance = 1000;
            //acc1.Deposit(1000);
            //acc1.Withdraw(500);
            //Console.WriteLine($"Balance : {acc1.Balance}");
            //Console.WriteLine($"Interest Earned for BankAccount : {acc1.CalculateInterestEarned()}");


            //SavingsBankAccount savings = new SavingsBankAccount();
            //savings.Deposit(1000);
            //Console.WriteLine($"Savings Balance : {savings.Balance}");
            //Console.WriteLine($"Interest Earned for Savings BankAccount : {savings.CalculateInterestEarned()}");

            //SrSavingsBankAccount srSavings = new SrSavingsBankAccount();
            //srSavings.Deposit(1000);
            //Console.WriteLine($"Sr Savings Balance : {srSavings.Balance}");
            //Console.WriteLine($"Interest Earned for Sr. Savings BankAccount : {srSavings.CalculateInterestEarned()}");

            //BankAccount acc1 = new BankAccount();
            //ManageAccount(acc1);

            //SavingsBankAccount acc2 = new SavingsBankAccount();
            //ManageAccount(acc2);

            SrSavingsBankAccount acc3 = new SrSavingsBankAccount();
            ManageAccount(acc3);

        }

        public static void ManageAccount(BankAccount acc)
        {
            acc.Deposit(1000);
            acc.Withdraw(500);
            Console.WriteLine($"Balance : {acc.Balance}");
            Console.WriteLine($"Interest Earned : {acc.CalculateInterestEarned()}");
        }
    }

    class BankAccount
    {
        public string AccNo { get; set; }
        public int Balance { get; private set; }

        public void Deposit(int amount)
        {
            Balance += amount;
        }

        public void Withdraw(int amount)
        {
            Balance -= amount;
        }

        public double CalculateInterestEarned()
        {
            return 0;
        }

    }

    class SavingsBankAccount : BankAccount
    {
        public double CalculateInterestEarned()
        {
            return Balance * 0.4;
        }
    }

    class SrSavingsBankAccount : BankAccount
    {
        public double CalculateInterestEarned()
        {
            return Balance * 0.6;
        }
    }
}
