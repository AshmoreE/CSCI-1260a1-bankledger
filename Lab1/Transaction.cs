using System.Security.Cryptography.X509Certificates;

namespace Lab1;

//This class shows money moving from one place to another
public class Transaction
{
    //Properties
    public int Id { get; private set; }
    public string Kind { get; private set; }
    public double Amount { get; private set; }

    //Constructor
    public Transaction(int id, string kind, double amount)
    {
        Id = id;
        Kind = kind;
        Amount = amount;
    }

    //Methods
    public bool IsDeposit()
    {
        return Kind == "Deposit";
    }

    public string Describe()
    {
        return string.Format("{0,4}  {1,-12} ${2,10:N2}", Id, Kind, Amount);
    }
}