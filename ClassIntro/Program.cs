namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.Adi = "Java";
            kurs1.Egitmeni = "Furkan";
            kurs1.OgrenciSayisi = 799;

            Kurs kurs2 = new Kurs();
            kurs2.Adi = "CSharp";
            kurs2.Egitmeni = "Engin";
            kurs2.OgrenciSayisi = 899;

            Kurs kurs3 = new Kurs();
            kurs3.Adi = "Javascript";
            kurs3.Egitmeni = "Beyza";
            kurs3.OgrenciSayisi = 999;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine("Kurs Adı : " + kurs.Adi + " - " + " Kurs Egitmeni : " + kurs.Egitmeni + " - " + " Kurs Öğrenci Sayısı : " + kurs.OgrenciSayisi);
            }
        }
    }

    class Kurs
    {
        public string Adi { get; set; }
        public string Egitmeni { get; set; }
        public int OgrenciSayisi { get; set; }
    }
}