
Console.WriteLine("Hello, World!");

string[] transactions = File.ReadAllLines(@"C:\Users\8184rj\source\repos\Support-Bank-C\SupportBank\SupportBank\Transactions2014.csv");

foreach (string transaction in transactions)
{
    Console.WriteLine(transaction);
}