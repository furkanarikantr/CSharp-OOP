namespace StaticConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Static Constructor Yapısı");

            /*Static Constructor Nedir ?
                    Constructor başlığında gördüğümüze nazaran, bir class'tan object üretilirken ilk tetiklenen method, static constructor'dur.
                Fakat, static constructor, constructor'dan davranış olarak farklıdır. Şöyle ki static constructor, ilgili class'tan ilk object
                üretilirken tetiklenir, ikinci veya daha fazla object üretilirken tetiklenmez, constructor ise, her object üretilirken
                tetiklenir.

                    Static yapılanmalar, uygulama bazlı data'larımızı yerleştirdiğimiz alandır. static yapılanmalara object ismi üzerinden 
                erişiriz.

                    Bir class'taki static constructor'ı ayrı olarak tetiklemek istiyorsak, ayrı olarak ilgili class'tan herhangi bir static 
                yapının tetiklenmesi, static constructor'ın tetiklenmesini sağlamaktadır.
            */

            /*Static Constructor Metot Nasıl Oluşturulur ?
                    Static Constructor özel bir class elemanıdır, yapı olarak bir method'tur. Fakat bildiğimiz method'lardan biraz farklı 
                tanımlanırlar. Static Constructor method'un adı class adıyla aynı olmalıdır. Geri dönüş değerine sahip değildir. Erişim 
                belirleyicisine sahip değildir. başında static keyword'u olmalıdır.
            
                    Class ClassName
                    {
                        static ClassName() -> Static Constructor Method
                        {
                            
                        }
                    }
            */

            new MyClass();
            new MyClass();
        }
    }

    class MyClass
    {
        //constructor
        public MyClass()
        {
            Console.WriteLine("normal");
        }

        //static constructor
        static MyClass()
        {
            Console.WriteLine("static");
        }
    }
}