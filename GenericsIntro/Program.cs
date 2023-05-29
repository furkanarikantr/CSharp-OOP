namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();

            names.Add("Furkan");

            Console.WriteLine(names.Length);

            names.Add("Osman");

            Console.WriteLine(names.Length);

            foreach (var name in names.Items)
            {
                Console.WriteLine(name);
            }
        }
    }
}