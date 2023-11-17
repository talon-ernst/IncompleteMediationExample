class BankAccount
{
    public string AccountHolder { get; private set; }
    public decimal Balance { get; private set; }

    public BankAccount(string accountHolder, decimal initialBalance)
    {
        AccountHolder = accountHolder;
        Balance = initialBalance;
    }

    public void TransferFunds(BankAccount recipient, decimal amount)
    {
        recipient.Balance += amount;
        Balance -= amount;
        Console.WriteLine("Funds transferred successfully.");
    }

    public void WithdrawFunds(BankAccount account, decimal amount)
    {
        account.Balance -= amount;
    }

    public void DepositFunds(BankAccount account, decimal amount)
    {
        account.Balance += amount;
    }
}

class Program
{
    static void Main()
    {
        BankAccount aliceAccount = new BankAccount("Alice", 3000);
        BankAccount bobAccount = new BankAccount("Bob", 500);

        aliceAccount.TransferFunds(bobAccount, 2000);

        Console.WriteLine($"Alice's balance: {aliceAccount.Balance}");
        Console.WriteLine($"Bob's balance: {bobAccount.Balance}");
    }
}