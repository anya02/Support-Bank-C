
string[] transactionsFileContent = File.ReadAllLines(@"C:\Users\8184rj\source\repos\Support-Bank-C\SupportBank\SupportBank\Transactions2014.csv");
transactionsFileContent = transactionsFileContent.Skip(1).ToArray();

object[] transactions = new object[transactionsFileContent.Length];

for (int i = 0; i < transactionsFileContent.Length; i++)
{
    string[] transactionItems = transactionsFileContent[i].Split(',');
    Transactions transaction = new Transactions();
    transaction.Date = transactionItems[0];
    transaction.From = transactionItems[1];
    transaction.To = transactionItems[2];
    transaction.Narrative = transactionItems[3];
    transaction.Amount = transactionItems[4];

    transactions[i] = transaction;
}

foreach (object item in transactions)
{
    Console.WriteLine(item);
}

Console.WriteLine(transactions.Length);
Console.WriteLine(transactionsFileContent[0]);
Console.WriteLine(transactions[0]);


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
    public string Amount { get; set; }
}
