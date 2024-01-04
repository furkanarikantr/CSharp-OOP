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

            /*Base Class(Parent Class) ve Derived Class(Child Class) Nedir ?
                    Inheritance ilişkisi bulunan iki class arasında, inheritance veren class'a base/parent class, inheritance alan class'a ise 
                derived/child class denir. Bir class'ın sadece tek bir adet Base class'ı olabilir. Base class dediğimiz kavram, direk inheritance
                ettiğimiz class kavramıdır. Bir class'ın ise birden fazla derived class'ı olabilir.
                    
                    class A ...
                    class B : A ...
                    class C : B ...
                    class D : C ...
                    Yukarıdaki kurguda A B'nin, B C'nin, C ise D'nin base class'ıdır. D class'ı A, B ve C class'larının erişilebilir member'larını
                inherit edebilir. Fakat D class'ının bir tane base class'ı vardır, o da C class'ıdır.

                    class A ...
                    class B : A ...
                    class C : A ...
                    class D : A ...
                    Yukarıdaki kurguda B, C ve D class'ları, A class'ının derived class'larıdır.. B, C ve D class'ları A class'ının erişilebilir
                member'larını inheritance edebilir.
                
                    Yani anlıbileceğimiz üzere, bir class yapısal olarak sadece bir class'tan inheritance edilebilir. Aynı anda birden fazla
                class'tan inheritance işlemi yapılamaz.
            */

            /*Inheritance'da Object Üretim Sırası ?
                    Bir class'tan object üretimi yapılırken inheritance aldığı base class varsa, ilk olarak base class'tan object üretilir. Eğer
                base class'ında başka bir base class'ı varsa ve bu böyle gidiyorsa, en baştaki base class'a kadar gidilir ve o base class'tan object
                üretilmeye başlayarak en son ilk istenen object üretilir.
            */

            /*Bir Class'tan Base Class Constructor'ına Ulaşım
                    Bir class'tan object üretimi gerçekleştirilirken öncelikle base class'ından object üretimi gerçekleştirilir, bunun bir diğer
                anlamı öncelikle base class'ın constructor'u çalışır. Bu durumda bizler object üretimi esnasında base class'ta üretilecek olan
                object'in istediğimiz constructor'larını tetikleyebiliriz veya varsa parametre değerleri verebiliriz. Bu durumu gerçekleştirebilmek
                için base keyword'u kullanılır. Eğer ki base class'ın constructor'ı sadece parametre alan bir constructor ise derived class'larda
                o constructor'a bir değer göndermek zorundadır. Base keyword'u ile parametre'de gönderilebilir. Eğer ki base class'ta bos 
                parametreli bir constructor var ise derived class'ta base ile bir bildirimde bulunmak zorunda değiliz. Çünkü varsayılan olarak
                inheritance durumunda base class'taki boş parametreli constructor tetiklenir.
            */

            /*base keyword vs this keyword
                    this keyword'ı bir class'taki constructor'lar arasında geçiş yapmamızı sağlar. base keyword'u ise, class'taki base class'ın
                constructor'larından hangisinin tetikleneceğini belirlememize ve varsa parametre değerlerinin derived class'tan verilmesini sağlar.
                Aynı zamanda this keyword'u, ilgili class'taki o anki object'in member'larına erişebilmemizi sağlarken, aynı şekilde base class'ta
                ki member'lara erişebilmemizide base keyword'u sağlar.
            */

            /*Object'lerdeki ToString/Equals/GetHashCode/GetType Method'ları Nereden Gelmektedir ?
                    Object'lerdeki otomatik gelen bu method'lar inheritance işlem neticesinde gelir. Object'lerin atası, yani en yukarıdaki base
                class'ı Object class'ı/türüdür.
                    C# programlama dilinde tüm class'lar Object class'ından türetilir. Bu inheritance işlemi sonucu bu gelen method'lar Object 
                class'ından gelmektedir.
            */

            /*Name Hiding (İsim Saklama Sorunsalı)
                    Inheritance durumlarında base class'lardaki herhangi bir member ile aynı isimde member'a sahip olan object'ler olabilmektedir.
                Bu durumda üretilen object'in member'larına bakıldığında, buradaki member'ın hangi class'tan geldiği anlaşılamaz. Bu soruna name
                hiding denir. Üretilen object'teki görülen member base class'taki member değil, derived class'taki member'dır, base class'taki 
                member gizlenmiştir. Eskiden bu durumlarda new operatörü kullanılır.
            */

            /*Record'larda Inheritance
                    Record'lar sadece record'lardan inheritance alabilirler. Class'lardan inheritance işlemi alamaz ve veremezler. Inheritance'ın
                tüm temel kuralları record'lar içinde geçerlidir.
            */

            //Orneklendirme
            //Ornek 1
            /*
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
            */

            //Ornek 2
            /*
                    D object'i oluşturulurken önce base class'a gidilir. Eğer bu class'ta da base class varsa, o base class'a gidilir ve en baştaki 
                base class'a kadar devam eder. Bu base class'a geldiğinde, buradan itibaren, istenilen object'e kadar sırayla object'ler üretilmeye
                başlanır. Yani D class'ından bir object üretimi istenildiğinde, en baştaki base class A class'ı olduğu için, A class'ından D 
                class'ına kadar sırayla object'ler üretilir. (A-B-C-D)

                new D();
            */

            //Ornek 3
            /*
            new MyClass2();
            new MyClass2(5);
            */

            //Ornek 4
            /*
            A4 item = new A4();
            item.X();
            */
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

    //****************
    class BuyukBaba             //Baba class'ının base class'ıdır.
    {

    }

    class Baba : BuyukBaba      //BuyukBaba class'ının derived class'ı, Ogul class'ının base class'ıdır.
    {

    }

    class Anne : BuyukBaba      //BuyukBaba class'ının derived class'ıdır.
    {

    }

    class Ogul : Baba           //Baba class'ının derived class'ıdır. 
    {                           //BuyukBaba class'ından da member'ları, Baba class'ının BuyukBabadan inherit etmesiyle alır.

    }

    //****************
    class A
    {
        public A()
        {
            Console.WriteLine($"{nameof(A)} object.");  //nameof keyword'u, içerisine verilen class'ın ismini, metinsel olarak yazdıran bir yapıdır.
        }
    }

    class B : A
    {
        public B()
        {
            Console.WriteLine($"{nameof(B)} object.");
        }
    }

    class C : B
    {
        public C()
        {
            Console.WriteLine($"{nameof(C)} object.");
        }
    }

    class D : C
    {
        public D()
        {
            Console.WriteLine($"{nameof(D)} object.");
        }
    }

    //****************
    class MyClass
    {
        public MyClass()
        {

        }

        public MyClass(int a)
        {

        }

        public MyClass(string a)
        {
            
        }

        public MyClass(int a, string b)
        {
            
        }
    }

    class MyClass2 : MyClass
    {
        public MyClass2()
        {
            
        }

        public MyClass2(int a) : base(a)
        {
            
        }
    }

    //****************
    class X
    {
        int a;
        public int b;

        public int MyProperty { get; set; }
    }

    class Y : X
    {
        int c;
        public void X()
        {
            this.c = 5;
            //base.a = 5; -> erişilemez, erişim belirleyicisi public değil.
            this.b = 5;
            base.b = 5;
            this.MyProperty = 5;
            base.MyProperty = 5;
        }
    }

    //****************
    class MethodsClass
    {
        
    }

    //****************
    class A1
    {
        public int A { get; set; }

        public void X()
        {

        }
    }

    class A2 : A1   //Burada name hiding durumu söz konusudur.
    {
        //public new int A { get; set; }    //Eski kullanımlarda new operatörüyle bildirmemiz gerekiyordu.
        public int A { get; set; }          //Yeni kullanımlarda buna gerek yoktur. Otomatik anlaşılıyor.


    }

    class A3 : A2
    {

    }

    class A4 : A3
    {
        public void X() //name hiding
        {

        }
    }
}