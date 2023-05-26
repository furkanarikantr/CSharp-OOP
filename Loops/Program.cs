namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Java";
            string kurs2 = "CSharp";
            string kurs3 = "Javascript";

            //Array

            string[] kurslar = new string[] { "Java", "CSharp", "Javascript" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("**************************");

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("**************************");

            int index = 0;
            while (index < kurslar.Length) {
                Console.WriteLine(kurslar[index]);
                index++;
            }
        }
    }
}