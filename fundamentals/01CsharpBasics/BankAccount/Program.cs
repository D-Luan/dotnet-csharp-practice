using BankAccountExercise;

BankAccount account = new BankAccount("Robert Smith", 32549, 1200);

account.DisplayData();
Console.WriteLine();

account.Deposit(200);
account.Withdraw(100);
account.Withdraw(1000);

try
{
    account.Deposit(-50);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

Console.WriteLine();
account.DisplayData();