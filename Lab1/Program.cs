using Lab1;

public class Program
{
    public static void Main()
    {
        Account account1 = new Account("Ada Lovelace", 500);
        Ledger ledger1 = new Ledger(account1);

        Console.WriteLine($"Opening account: {account1}\n\nRecording five requests...");

        string[] kinds =
        {
            "Deposit",
            "Withdrawal",
            "Withdrawal",
            "Deposit",
            "Deposit"
        };

        double[] amounts =
        {
            250,
            125.50,
            10000,
            -40,
            75.25
        };

        for (int i = 0; i < kinds.Length; i++)
        {
            bool isAccepted = ledger1.Record(kinds[i], amounts[i]);

            if (!isAccepted)
            {
                Console.WriteLine("  REJECTED: {0} of ${1:N2}", kinds[i], amounts[i]);
            }
        }

        Console.WriteLine($"\nTransactions accepted: {ledger1.Count}\n");

        ledger1.PrintStatement();
    }
}