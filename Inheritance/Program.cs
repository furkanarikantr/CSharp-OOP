namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance(Kalıtım) Yapısı");

            /*Inheritance Nedir ?
                    Üretilen object'ler, farklı object'lere özelliklerini aktarabilmekte ve böylece hiyerarşik bir düzenleme yapılabilmektedir. 
                Örnek olarak elimizde olan bir object'in member'larından(field/property/method) belirlediklerimizi başka bir object'e aktarmaya
                inheritance(kalıtım) denir. Aynı aile grubundan gelen object'lerin ya da yatayda eşit seviyede olan tüm object'lerin benzer 
                özelliklerini tekrar tekrar her birine tanımlamaktansa, bir üst class'ta tanımlanmasını ve her bir class'ın bu özellikleri üst 
                class'tan inheritance yaparak almasını sağlamaktadır. Böylece hem kod maliyeti düşmekte, hem de mimarisel tasarım açısından
                avantaj sağlamaktadır. Inheritance işleminde, inheritance veren class'ın erişilebilen tüm member'larına, inheritance alan class'a
                kalıtsal olarak aktarılacaktır. OOP'de kalıtım, özünde object'lerin birbirinden türemesini sağlayan bir özelliktir ve birçok 
                özellik ve stratejik yaılanmalar getirmektedir.(virtual - polymorfizm - interface - abstraction - ...) Inheritance, operasyonel
                olarak gerçekleştirildikten sonra compiler seviyesinde member aktarımı sağlanır.
                                                                        Canlı
                                                        İnsan                          Hayvan
                                                Erkek           Kadın           Kedi            Köpek

                    Her class tabiki de inheritance işlemlerine tabi tutulmak zorunda değildir, tutulmamalıdır. Inheritance işlemleri ihtiyaç
                duyulursa kullanılmalıdır.
            */

            /*C# Programlama Dilinde Hangi Yapılar Inheritance Alabilirler ?
                    C# programlama dilinde inheritance class'lara özel bir niteliktir, yani bir class sadece bir başka class'tan inheritance 
                alabilirler. Record'larda özünden class yapısında olduğu için inheritance alabilirler. Önemli olan ise ya kendi aralarında
                inheritance alabilirler yada sadece object class'ından. Ayrıca ileride göreceğimiz abstract class, interface ve struct gibi 
                yapılarında kendilerine göre inheritance operasyonları mevcuttur.
            */

            /*Inheritance Nasıl Uygulanır ?
                    C#'da iki class arasındaki inheritance ilişkisi kurulması için : operatörü kullanılır.

                    class Car
                    {
                        prop Brand
                        prop Model
                        prop Kilometer
                    }

                    class Opel : Car    => Soldaki sağdakinden inheritance alır, yani Opel class'ı Car class'ının erişilebilir member'larını alır.
                    {
                        
                    }
            */

            Mudur mudur1 = new Mudur();
            mudur1.Adi = "Serkan";
            mudur1.Soyadi = "Arıkan";
            mudur1.MedeniHal = true;

            Yazilimci yazilimci1 = new Yazilimci();
            yazilimci1.Adi = "Furkan";
            yazilimci1.Soyadi = "Arıkan";
            yazilimci1.MedeniHal = true;

            Muhasebeci muhasebeci1 = new Muhasebeci();
            muhasebeci1.Adi = "Selçuk";
            muhasebeci1.Soyadi = "Öztürk";
            muhasebeci1.MedeniHal = false;
            muhasebeci1.Musavir = true;

            Console.WriteLine($"Müdür = Adı: {mudur1.Adi} - Soyadı: {mudur1.Soyadi} - Evlilik Durumu: {mudur1.MedeniHal}");
            Console.WriteLine($"Yazılımcı = Adı: {yazilimci1.Adi} - Soyadı: {yazilimci1.Soyadi} - Evlilik Durumu: {yazilimci1.MedeniHal}");
            Console.WriteLine($"Muhasebeci = Adı: {muhasebeci1.Adi} - Soyadı: {muhasebeci1.Soyadi} - Evlilik Durumu: {muhasebeci1.MedeniHal} - Müşavirlik Durumu: {muhasebeci1.Musavir}");
        }
    }

    class Personel
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public bool MedeniHal { get; set; }
    }

    class Mudur : Personel
    {

    }

    class Yazilimci : Personel
    {

    }

    class Muhasebeci : Personel
    {
        public bool Musavir { get; set; }
    }
}