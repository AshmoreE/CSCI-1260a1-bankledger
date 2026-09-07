namespace Lab1;

public class Account
{
    //Properties
    public string Owner { get; private set; }
    public double Balance { get; private set; }

    //Constructor
    public Account(string owner, double startingBalance)
    {
        Owner = owner;
        Balance = startingBalance;
    }

    //Methods
    public bool Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            return true;
        }
        else
        {
            return false;
        } 
    }

    public bool Withdraw(double amount)
    {
        if (amount <= 0 || amount > Balance)
        {
            return false;
        }
        else 
        {
            Balance -= amount;
            return true;
        }
    }

    public override string ToString()
    {
        return string.Format("{0}, ${1:N2}", Owner, Balance);
    }
}