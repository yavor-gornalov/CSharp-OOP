using System.Runtime.Serialization;

namespace MoneyTransactions
{
    public class Program
    {
        private static Dictionary<uint, double> bankAccounts;
        static void Main(string[] args)
        {
            LoadBankAccounts();

            string line;
            while ((line = Console.ReadLine()) != "End")
            {
                var tokens = line.Split().ToArray();
                string command = tokens[0];
                uint account = uint.Parse(tokens[1]);
                double balance = double.Parse(tokens[2]);

                try
                {
                    switch (command)
                    {
                        case "Deposit": { Deposit(account, balance); break; }
                        case "Withdraw": { Withdraw(account, balance); break; }
                        default: throw new InvalidCommandException();
                    }
                    Console.WriteLine($"Account {account} has new balance: {bankAccounts[account]:F2}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("Enter another command");
                }
            }
        }

        private static void Deposit(uint account, double sum)
        {
            if (!bankAccounts.ContainsKey(account))
                throw new InvalidAccountException();
            bankAccounts[account] += sum;
        }

        private static void Withdraw(uint account, double sum)
        {
            if (!bankAccounts.ContainsKey(account))
                throw new InvalidAccountException();
            if (bankAccounts[account] < sum)
                throw new InvalidBalanceException();
            bankAccounts[account] -= sum;
        }

        private static void LoadBankAccounts()
        {
            bankAccounts = new Dictionary<uint, double>();

            char[] delimiters = { ',', '-' };
            var accountInfo = Console.ReadLine()
                .Split(delimiters, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            for (int i = 1; i < accountInfo.Length; i += 2)
            {
                var account = uint.Parse(accountInfo[i - 1]);
                var balance = double.Parse(accountInfo[i]);

                bankAccounts.Add(account, balance);
            }
        }
    }

    internal class InvalidCommandException : Exception
    {
        private const string _message = "Invalid command!";
        public InvalidCommandException() : base(_message)
        {
        }
    }

    internal class InvalidAccountException : Exception
    {
        private const string _message = "Invalid account!";
        public InvalidAccountException() : base(_message)
        {
        }
    }

    internal class InvalidBalanceException : Exception
    {
        private const string _message = "Insufficient balance!";
        public InvalidBalanceException() : base(_message)
        {
        }
    }
}
