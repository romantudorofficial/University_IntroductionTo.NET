using BankAccountsManagement.Contracts;

namespace BankAccountsManagement.Business
{
    public class SavingsAccount : BankAccount, ITransaction
    {
        public SavingsAccount (string accountNumber, decimal balance)
            : base (accountNumber, balance)
        {
            if (balance < 0)
            {
                throw new ArgumentException("Balance must be greater than or equal to zero.");
            }

            if (string.IsNullOrEmpty(accountNumber))
            {
                throw new ArgumentException("Account number must be provided.");
            }
        }

        public void Deposit (decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be greater than zero.");
            }

            IncreaseBalance(amount);
        }

        public void Withdraw (decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdraw amount must be greater than zero.");
            }

            if (amount > Balance)
            {
                throw new InvalidOperationException("Insufficient funds.");
            }

            DecreaseBalance(amount);
        }

        public override void CalculateInterest()
        {
            AddInterest(1.05m);
        }
    }
}