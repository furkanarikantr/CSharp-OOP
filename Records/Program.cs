namespace Records
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Records Yapısı");

            /*Init-Only Properties - Record için Ön Hazırlık
                    Init-Only properties, Object'e ait property'lerin ilk data'sının verilmesi ve sonraki süreçte değiştirilmemesini sağlayan bir
                yapıdır. Bu özellik sayesinde object'in sadece ilk yaratılış anında property'lerine değer atanmakta ve böylece iş kuralları gereği
                run-time'da değeri değişmemesi gereken object'ler için ideal bir önlem alınmaktadır. Object initializer ile bir object oluştulurken
                bir değer ataması yapılabilir, ama bu durumda da read only propertilere initializer edilemez. Bu durumlar için Init-Only kullanılır.
                    Read-Only yapılarda, ilk değer atamasını ya class yapısı içinde property'e değer atayarak verebiliriz, ya da ileride göreceğimiz
                constructer yapısı ile, object initializer ile değer ataması yapamayız. Bu durumlar için Init-Only kullanılır.
            */

            /*Init-Only Properties Tanımlaması
                    Init-Only properties tanımlanması için init keyword'u kullanılmalıdır. Yapı gereği get olmadan ve set olduğunda kullanılamaz
                        -public string Author{ get; init; }
                    Read only field'larda da Init-Only property yapısı kullanılabilir.
            */

            /*Records Nedir ?
                    Bir object'in bir field/property'si read-only olup oluşturulma anında değer atanması istiyorsa Init-Only kullanabiliriz. Fakat
                object'in bütün field/property'leri read-only olması isteniyor ve sadece object oluşturulma anında bu bütün field/property'lere
                değer atanması isteniyorsa işte o zaman Record yapısını kullanırız.
                    Record, bir object'in tamamen değişmez, read-only olmasını sağlar ve bu durumu güvenceye alır.

                    Not: Object ön plandaysa class, object'in değerleri ön plandaysa record.
                    
                    Bu durumda record'ları içerisinde data barındıran lightweight(hafif) class'lar olarak değerlendirebiliriz. Record'lar özünde
                bir class'tır. Farkı olarak class object'i öne çıkartırken, record object'in değerini öne çıkartır. Örnek olarak biz bir araba 
                class'ı yapalım, bu araba class'ın object'ler yani üretilen arabalar önemli olacağı için egea 1.4 ile egea 1.6 diye 2 araba
                oluşturup farklı değerler atarız, burada önemli olan iki object'imizin olmasıdır. Fakat ben bu araba'yı record's
                olarak oluştursaydım, üreteceğim object'ler yani arabalar, ikiside egea 1.6 olup, değerleri aynı olucaktı.
                    Record aslında bir class fıtratında bir yapılanma olduğu için içerisinde her türlü class member'ları tanımlanabilmektedir. Bu
                durumda property'lerinin hepsi init ile işaretlenmelidir, bu durum record'un amacına eşlik eder.
                    Record'lar, değiştirilemez object'ler oluşturmamız için geliştirilen yapılardır. Class'lar ile'de bu isteğimizi 
                gerçekleştirebilirdik. Bu durum göz önüne alındığında record'ların gelme sebebi daha profesyonel daha okunabilir geliştirme yapmamız
                içindir. Fark olarak bir object'imizi değiştirmek istediğimizde class'ları eşitleme yapamayız, bu durumda prop atamalarını tek tek
                yapıp, değiştirilecek prop'ları kendimiz yeni object'e oluşturulurken belirtebiliriz. Fakat record'lar ile bu durum record'ların
                değerlerinin daha ön planda olduğu için record Expresions'ları vardır. With Expressions özelliği.
            */

            /*Record Tanımlama
                    record recordName
                    {
                        prop Name {get; init;}
                        prop Author {get; init;}
                    }
             
            */

            /*With Expression
                    
            */

            //Örneklendirme
            MyClass m1 = new MyClass()
            {
                //MyProperty Read-only yapıda olduğu object-initializer yapılamaz. Set yapısı çok çünkü.
                MyProperty2 = 2
            };
            //MyProperty2 artık değiştirilemez, çünkü read-only bir yapıda.

            MyClass m2 = new MyClass()
            {
                A = 5
            };

            //Record Örnek
            MyClass2 x1 = new MyClass2()
            {
                MyProperty = 5
            };
            MyClass2 x2 = new MyClass2()
            {
                MyProperty = 5
            };
            Console.WriteLine(x1.Equals(x2));   //Burada sonuç object ön planda olduğu için false dönecektir.

            MyRecord x3 = new MyRecord()
            {
                MyProperty = 5
            }; ;
            MyRecord x4 = new MyRecord()
            {
                MyProperty = 5
            }; ;
            Console.WriteLine(x3.Equals(x4));   //Burada sonuç object'in değerleri ön planda olduğu için true dönecektir.
        }
    }

    class MyClass
    {
        public int MyProperty { get; } //Read Only
        public int MyProperty2 { get; init; } //Read Only

        private readonly int a;

        public int A
        {
            get
            {
                return a;
            }
            init    //set olmaz, çünkü readonly.
            {
                a = value;
            }
        }   
    }

    class MyClass2
    {
        public int MyProperty { get; set;}
    }

    record MyRecord
    {
        public int MyProperty { get; init; }
    }
}