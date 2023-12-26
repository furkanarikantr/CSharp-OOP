namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Encapsulation Yapısı");

            /*Encapsulation Nedir ? Bir Dataya Encapsulation İşlemi Uygularız ?
                    Encapsulation, object'lerimizde ki field'ları kontrollü bir şekilde dışarıya açmaktır. Object'lerimize başkalarının yanlış
                kullanımlarından korumak için kontrolsüz değişime kapatmaktır.
            */

            /*Encapsulation Nasıl Uygulanır ?
                    C#'da iki farklı şekilde uygulanır. 1)Method'lar ile Encapsulation - 2)Property'ler ile Encapsulation
                    
                    - Method'lar ile Encapsulation 
                        Field'larımız için get ve set method'ları tanımlanır ve bu method'lar ile encapsulation yapılır.
                    - Property'ler ile Encapsulation
                        Field'ler yerine property kullanılır ve bu property'ler ile encapsulation yapılır.
            */


            //Örneklendirme

            //Method ile Encapsulation
            MyClass m1 = new MyClass();
            m1.ASet(5);
            Console.WriteLine(m1.AGet());

            //Property ile Encapsulation
            MyClass2 m2 = new MyClass2();
            m2.A = 5;
            Console.WriteLine(m2.A);
        }
    }

    class MyClass
    {
        private int a;  //default bırakılır, erişim belirleyicisi yazılmazsa, private olarak alınır.

        public int AGet()   //private olan a field'ımızı, dışarıdan okunmak/alınmak istendiğinde AGet method'u çalıştırılır.
        {
            return a;
        }

        public void ASet(int a) //private olan a field'ımızı, dışarıdan güncellemek/değiştirmek istendiğinde ASet method'u çalıştırılır.
        {
            this.a = a;
        }
    }

    class MyClass2
    {
        //Eğer encapsulation uygulanıp, herhangi bir işlem uygulanmayacaksa alttaki gibi tek satırlık encapsulation kodu uygulanır.
        //Property Encapsulation
        //public int A { get; set; }

        //Eğer hem encapsulation uygulanıp hemde işlem uygulanacaksa alttaki gibi encapsulation kodu uygulanır.
        //Full Property Encapsulation
        
        int a;
        public int A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            } 
        }
        
    }
}