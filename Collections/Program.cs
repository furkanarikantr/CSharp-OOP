namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Koleksiyonlar
            
            List<string> names = new List<string>() {"Furkan", "Osman", "Sami" };
            names.Add("Beyza");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}