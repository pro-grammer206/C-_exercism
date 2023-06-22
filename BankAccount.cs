namespace Classes;

public class BankAccount
{
    private static int accountNumberseed = 1234567890;
    public string Number {get;}
    public string Owner {get;set;}
    public decimal Balance
    {
        get
        {
            decimal balance = 0;
            foreach(var item in allTransactions)
            {
                balance+=item.Amount;
            }
            return balance;
        }
    }
    public BankAccount(string name,decimal initialBalance)
    {
        this.Owner =name;
        this.Number = accountNumberseed.ToString();
        accountNumberseed++;
        MakeDeposit(initialBalance,DateTime.Now,"Initial Balance");
    }
    private List<Transaction> allTransactions = new List<Transaction>();
    public void MakeDeposit(decimal amount,DateTime date,string notes)
    {
        if(amount<0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount),"Amount of deposit must be positive");
        }
        var deposit = new Transaction(amount,date,notes);
        allTransactions.Add(deposit);
    }
    public void MakeWithdrawal(decimal amount,DateTime date,string note)
    {
        if(amount<=0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount),"Amount of withdrawal must be positive");
        }
        if(Balance-amount<0)
        {
            throw new InvalidOperationException("Not sufficient funds for the withdrawal");
        }
        var withdrawal = new Transaction(-amount,date,note);
        allTransactions.Add(withdrawal);
    }
    public string GetAccountHistory()
    {
        var report  = new System.Text.StringBuilder();
        decimal balance = 0;
        report.AppendLine("Date\t\tAmount\tBalance\tNote");
        foreach(var item in allTransactions)
        {
            balance+=item.Amount;
            report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
        }
        return report.ToString();
    }

}