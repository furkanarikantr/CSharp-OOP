namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Constructor Yapısı");

            /*Constructor Nedir ? (Yapıcı Metot)
                    Constructor bir object üretimi sürecinde ilk tetiklenen method'dur. -> new T( ) Buradaki object üretilirken kullanılan parantez,
                constructor method'una eşdeğerdir. Object ayağa kaldırılırken ilk konfigurasyonları/ayarlamaları yapabildiğimiz method'dur. 
                Constructor, bir object oluşturma sürecinde tetiklenmek zorundadır. Constructor, new operatörü ile object yaratma talebi geldikten 
                ve object'in heap'te yeri ayrıldıktan sonra tetiklenir.
                    Constructor'ın erişim belirleyicisini public yapmalıyız çünkü object üretilirken o class'ın constructor'ı default olsada
                tetiklenir. Fakat private yaparsak erişilemeyeceğinden dolayı object üretiminde hata alınır. Çünkü dışarıdan object üretilirken 
                mutlaka constructor method'u tetiklenmelidir.
            */

            /*Constructor Metot Nasıl Oluşturulur ?
                    Constructor özel bir class elemanıdır, yapı olarak bir method'tur. Fakat bildiğimiz method'lardan biraz farklı tanımlanırlar.
                Constructor method'un adı class adıyla aynı olmalıdır. Geri dönüş değerine sahip değildir. Erişim belirleyicisi public olmalıdır.
            
                    MyClass ClassName
                    {
                        public ClassName() -> Constructor Method
                        {
                            
                        }
                    }
            */

            /*Default Constructor
                    Cosntructor'u yazılmamış, boş class'larda bile default constructor vardır. Her class'ın içerisinde tanımlamasak dahi default
                bir constructor mevcuttur.
            */

            /*Parametreli Constructor
                    Cosntructor'lar parametre alabilir. Bir object üretilirken, constructor üzerinden dışarıdan parametre alınır ve bu parametreler
                object'in field'larına atanabilir. Eğer bir constructor'unda parametre alınırsa, o class'tan üretilecek her object'e o parametreler
                eklenmelidir.
            */

            /*Constructor Overload
                    Class'larda constructor tanımlaması yapılırken birden fazla constructor tanımlaması yapılabilir. Bu duruma constructor overload
                denir.
            */

            /*this Keyword'u ile Constructer'lar Arası Geçiş
                    this keyword'u, bulunduğu class'tan object'in field'ını/property'sini işaret ederken aynı zamanda bir class object'inin 
                içerisindeki birden fazla constructor'lar arasında geçiş yapabilmesine imkan sağlar. Bir class içerisinde bir constructor'a 
                this keyword'u verirsek, this keyword'una sahip constructor, diğer constructor'lara erişim hakkı veririz. Bu durumda eğer biz 
                this keyword'una sahip constructor kullanarak bir object üretirsek, orada ki this keyword'u sayesinde default construclar this 
                keyword'lu constructor'tan önce çalışacak ve sonra bizim this keywordlu constroctur'ımız çalışacaktır. Eğer this keyword'una sahip 
                bir constructor parametreli başka bir constructor çağıracaksa, o parametreyi this keyword'unun içine yazmalıdır.
            */

            /*Record'larda Constructor
                    Class'lar ile tamamen aynı şekilde constructor yapısına sahiptir.
            */

            //Orneklendirme

            //Constructor
            //new MyClass();  //()'ler contstructor'ı tetikler.
            //new MyClass();
            //new MyClass();

            //Parametreli Constructor
            new MyClass();
            new MyClass(5);
            new MyClass("Furkan");

            //Constructor'larda this Keyword'u
            new MyClassThis(5,10);
        }
    }

    class MyClass
    {
        //Constructor
        public MyClass()
        {
            Console.WriteLine("MyClass object'i oluşturulmuştur. Parametresiz constructor.");
        }

        //Parametreli Constructor
        public MyClass(int a)
        {
            Console.WriteLine("MyClass object'i oluşturulmuştur. Int parametreli constructor." + a);
        }
        public MyClass(string a)
        {
            Console.WriteLine("MyClass object'i oluşturulmuştur. String parametreli constructor." + a);
        }
    }

    class MyClassThis
    {
        public MyClassThis()
        {
            Console.WriteLine("1. Constroctur");
        }

        public MyClassThis(int a) : this()  //this keyword'u
        {
            Console.WriteLine($"2. Constroctur -> a = {a}");
        }

        public MyClassThis(int a, int b) : this(a)
        {
            Console.WriteLine($"2. Constroctur -> a = {a} | b = {b}");
        }
    }

    record MyRecord
    {
        public int MyProperty { get; init; }

        public MyRecord()
        {
            
        }

        public MyRecord(int a) : this()
        {
            
        }
    }
}