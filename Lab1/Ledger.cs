namespace Lab1;

public class Ledger
{
    //fields
    private Account _account;
    private List<Transaction> _history;
    private int _nextId;

    //Properties

    public int Count
    {
        get
        {
            return _history.Count;
        }
    }

    //Constuctor

    public Ledger(Account account)
    {
        _account = account;
        _history = new List<Transaction>();
        _nextId = 1;
    }

    //Methods

    public bool Record(string kind, double amount)
    {
        bool isAccepted;

        if (kind == "Deposit")
        {
            isAccepted = _account.Deposit(amount);
        }
        else if (kind == "Withdraw")
        {
            isAccepted = _account.Withdraw(amount);
        }
        else
        {
            isAccepted = false;
        }

        if (!isAccepted)
        {
            return false;
        }

        Transaction transaction = new Transaction(_nextId, kind, amount);
        _history.Add(transaction);
        _nextId++;

        return true;
    }

    public double Total(string kind)
    {
        double total = 0;

        foreach (var transaction in _history)
        {
            if (transaction.Kind == kind)
            {
                total += transaction.Amount;
            }
        }

        return total;
    }

    public void PrintStatement()
    {
        Console.WriteLine("========================================");
        Console.WriteLine($"  STATEMENT FOR {_account.Owner.ToUpper()}");
        Console.WriteLine("========================================");
        Console.WriteLine("  ID  TYPE              AMOUNT");
        Console.WriteLine("----------------------------------------");

        foreach (var transaction in _history)
        {
            Console.WriteLine(transaction.Describe());
        }

        Console.WriteLine("----------------------------------------");
        Console.WriteLine("  {0,-17}${1,10:N2}", "Deposits:", Total("Deposit"));
        Console.WriteLine("  {0,-17}${1,10:N2}", "Withdrawals:", Total("Withdrawal"));
        Console.WriteLine("  {0,-17}${1,10:N2}", "Ending balance:", _account.Balance);
        Console.WriteLine("========================================");
    }
}