namespace BankAccountsManagement.Business
{
    public abstract class BankAccount
    {
        public string AccountNumber { get; private set; }
        public decimal Balance { get; private set; }

        public BankAccount (string accountNumber, decimal balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public abstract void CalculateInterest();

        public void IncreaseBalance (decimal amount)
        {
            Balance += amount;
        }

        public void DecreaseBalance(decimal amount)
        {
            Balance -= amount;
        }

        public void AddInterest (decimal percentage)
        {
            Balance *= 1 + percentage / 100;
        }
    }
}