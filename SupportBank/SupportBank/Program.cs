
string[] transactionsFileContent = File.ReadAllLines(@"C:\Users\8184rj\source\repos\Support-Bank-C\SupportBank\SupportBank\Transactions2014.csv");

transactionsFileContent = transactionsFileContent.Skip(1).ToArray();

object[] transactions = new object[transactionsFileContent.Length];

Console.WriteLine(transactions.Length);

//List<string> transactions = new List<string>();

foreach (string transaction in transactionsFileContent)
{
    string[] tsplit = transaction.Split(',');
    Transactions eachTransaction = new Transactions();
    eachTransaction.Date = tsplit[0];
    eachTransaction.From = tsplit[1];
    eachTransaction.To = tsplit[2];
    eachTransaction.Narrative = tsplit[3];
    eachTransaction.Amount = Convert.ToInt32(tsplit[4]);
    //transactions.Add(eachTransaction); // <------
    Console.WriteLine(tsplit[0]);
}


class Account
{
    public int Balance { get; set; }
}

class Transactions
{
    public string Date { get; set; }
    public string From { get; set; }
    public string To { get; set; }
    public string Narrative { get; set; }
    public int Amount { get; set; }
}

//new Transactions(tsplit[0], tsplit[1]), tsplit[2], tsplit[3], tsplit[4]