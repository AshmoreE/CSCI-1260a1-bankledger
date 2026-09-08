using Lab1;

Account account = new Account("Ethan", 1000.00);

Ledger ledger = new Ledger(account);

// Test 1: Deposit
bool result = ledger.Record("Deposit", 500.00);
Console.WriteLine($"Accepted: {result}");
Console.WriteLine($"Transaction Count: {ledger.Count}");

// Test 2: Withdraw
result = ledger.Record("Withdraw", 200.00);
Console.WriteLine($"Accepted: {result}");
Console.WriteLine($"Transaction Count: {ledger.Count}");

// Test 3: Invalid transaction type
result = ledger.Record("Transfer", 100.00);
Console.WriteLine($"Accepted: {result}");
Console.WriteLine($"Transaction Count: {ledger.Count}");

// Test 4: Check totals
Console.WriteLine($"Total Deposits: ${ledger.Total("Deposit"):N2}");
Console.WriteLine($"Total Withdrawals: ${ledger.Total("Withdraw"):N2}");

// Print the complete statement
ledger.PrintStatement();