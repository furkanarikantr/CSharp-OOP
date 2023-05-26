namespace CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kursAdi = "Java";
            string kursEgitmeni = "Furkan Arıkan";
            int kursOgrencisi = 76;

            Console.WriteLine("Kurs Adı : " + kursAdi + " Kurs Eğitmeni : " + kursEgitmeni + " Kurs Öğrenci Sayısı : " + kursOgrencisi);

            double dolarDun = 19.89;
            double dolarBugun = 19.99;

            if (dolarBugun > dolarDun) 
            {
                Console.WriteLine("Dolar Arttı.");
            }
            else if (dolarBugun < dolarDun)
            {
                Console.WriteLine("Dolar Azaldı.");
            }else
            {
                Console.WriteLine("Dolar Değişmedi.");
            }
        }
    }
}