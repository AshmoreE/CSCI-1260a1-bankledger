using Lab1;

Transaction test = new Transaction(3, "Deposit", 7602);

Console.WriteLine(test.Id);
Console.WriteLine(test.Kind);
Console.WriteLine(test.Amount);
Console.WriteLine(test.IsDeposit());
Console.WriteLine(test.Describe());