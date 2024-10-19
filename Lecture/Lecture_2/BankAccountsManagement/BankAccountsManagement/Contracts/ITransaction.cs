namespace BankAccountsManagement.Contracts
{
    public interface ITransaction
    {
        void Deposit (decimal amount);
        void Withdraw (decimal amount);
    }
}