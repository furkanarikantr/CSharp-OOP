namespace Mathematics
{
    class Program
    {
        static void Main(string[] args)
        { 
            FourTransactions fourTransactions= new FourTransactions();

            Console.WriteLine("***********Addition***********");
            fourTransactions.Addition(3, 2);

            Console.WriteLine("***********Extraction***********");
            fourTransactions.Extraction(3, 2);

            Console.WriteLine("***********Division***********");
            fourTransactions.Division(2,3);
            fourTransactions.Division(3,2);

            Console.WriteLine("***********Multiplication***********");
            fourTransactions.Multiplication(3, 2);
        }
    }
}