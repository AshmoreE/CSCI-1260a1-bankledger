using Lab1;

Account test = new Account("Ethan", 7283);
Console.WriteLine(test.Owner);
Console.WriteLine(test.Balance);
Console.WriteLine(test.Deposit(0));
Console.WriteLine(test.Deposit(50));
Console.WriteLine(test.Withdraw(10000));
Console.WriteLine(test.Withdraw(50));
Console.WriteLine(test.ToString());