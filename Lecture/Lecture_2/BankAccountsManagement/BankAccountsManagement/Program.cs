using BankAccountsManagement.Business;

SavingsAccount account = new SavingsAccount("123456", 1000);
account.Deposit(500);
account.Withdraw(200);
account.CalculateInterest();
Console.WriteLine(account.Balance);