namespace Destructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Destructor(Finalizer) Yapısı");

            /*Destructor Nedir ? (Yıkıcı/Finalizer Metot)
                    Bir class'tan üretilmiş olan object imha edilirken otomatik olarak çağırılan method'dur. C# programlama dilinde destructor
                sadece class yapılanmasında kullanılabilir ve bir class sadece bir adet destructor method'una sahip olabilir. Constructor'taki gibi
                overloading işlemleri yapılamaz. Destructor'lar parametre alamaz.
                    Bir object oluşturulduğunda ilk tetiklenen method, constructor method'dur. İlerleyen işleyişte, eğer oluşturulan object'in
                artık kullanılmasına ihtiyaç duymazsak, object imha edilirken son kez tetiklenen method, destructor method'dur.
            */

            /*Bir Object Hangi Şartlarda ve Kim Tarafından İmha Edilir ?
                    Bir object'in imha edilmesi için bir kaç sebep olabilir;
                        - ilgili object herhangi bir referans tarafından işaretlenmemelidir,
                        - yahut object'in oluşturulduğu ve kullanıldığı sope sone ermiş olmalıdır.
                Sonuç olarak ilgili object'e bir daha erişilemez hale gelinirse, o object imha edilmelidir.

                    Bir object'in imha edilme işlemini gerçekleştiren yapıya garbage collector mekanizması denir. Uygulamada artık ihtiyaç 
                duyulmayan object'leri yoplamak/silmek/yok etmek için garbage collector mekanizması devreye girer. Garbage collector kullanımı, 
                esasında C# programlama dilinde bellek optimizasyonunu üstlenen bir yapıdır. Garbage collector, gerekli zamanlarda otomatik
                devreye girerek kendi işlemlerini yerine getirir.
            */

            /*Destructor Metot Nasıl Oluşturulur ?
                    Destructor özel bir class elemanıdır, yapı olarak bir method'tur. Fakat bildiğimiz method'lardan biraz farklı tanımlanırlar.
                Destructor method'un adı class adıyla aynı olmalıdır. ~ işaretiyle tanımlanmalıdır. Geri dönüş değerine sahip değildir.
            
                    Class ClassName
                    {
                        ~ClassName() -> Destructor Method
                        {
                            
                        }
                    }
            */

            // Orneklendirme

            //MyClass m1 = new MyClass();
            //X();
            //GC.Collect();   //Garbage Collector devreye sokulmuştur.
            //Console.ReadLine();

            int sayi = 100;
            while (sayi >= 1) 
            {
                new MyClass2(sayi--);
            }
            Console.WriteLine("************************************");
            GC.Collect();
            Console.ReadLine();
        }

        public static void X()
        {
            MyClass m2 = new MyClass();
        }
    }

    class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("Object üretilmiştir. Constructor method çalıştı.");
        }

        ~MyClass()
        {
            Console.WriteLine("Object imha ediliyor. Destructor method çalıştı.");
        }
    }

    class MyClass2
    {
        int no;

        public MyClass2(int no)
        {
            this.no = no;
            Console.WriteLine($"{no}. nesne oluşturulmuştur."); 
        }

        ~MyClass2()
        {
            Console.WriteLine($"{no}. nesne yok edilmiştir..");
        }
    }
}