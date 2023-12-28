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
                    
            
            */

            //Orneklendirme
            new MyClass();  //()'ler contstructor'ı tetikler.
            new MyClass();
            new MyClass();
        }
    }

    class MyClass
    {
        //Constructor
        public MyClass()
        {
            Console.WriteLine("MyClass object'i oluşturulmuştur.");
        }
    }
}