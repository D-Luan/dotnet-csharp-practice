namespace BankAccountExercise;

public class BankAccount
{
    public string Holder { get; private set; }
    public int AccountNumber { get; private set; }
    public decimal Balance { get; private set; }

    public BankAccount(string holder, int accountNumber, decimal initialBalance)
    {
        if (string.IsNullOrWhiteSpace(holder)) throw new ArgumentException("Invalid account holder name");

        if (accountNumber <= 0) throw new ArgumentException("The account number must be greater than 0");

        if (initialBalance < 0) throw new ArgumentException("The initial balance cannot be negative");

        Holder = holder;
        AccountNumber = accountNumber;
        Balance = initialBalance;
    }

    public void Deposit(decimal value)
    {
        if (value <= 0) throw new ArgumentException("The deposit must be greater than 0");

        Balance += value;
    }

    public void Withdraw(decimal value)
    {
        if (value <= 0) throw new ArgumentException("The withdraw must be greater than 0");

        if (value > Balance) throw new ArgumentException("The withdraw cannot be greater than balance");

        Balance -= value;
    }

    public void DisplayData()
    {
        Console.WriteLine($"Holder: {Holder}");
        Console.WriteLine($"Account: {AccountNumber}");
        Console.WriteLine($"Balance: R$ {Balance:F2}");
    }
}
