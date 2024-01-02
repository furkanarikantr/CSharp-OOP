namespace Deconstruct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deconstruct Yapısı");

            /*Deconstruct Nedir ? 
                    Bir class içerisinde deconstruct ismiyle tanımlanan method, compiler tarafından özel olarak algılanmakta ve class'ın object'i
                üzerinden geriye hızlıca tuple bir değer dönmemizi sağlamaktadır.
                    Örnek olarak bir object'e a, b, c, d ve e şeklinde property'lerimiz var ve bizim ise ihtiyaç duyduğumuz property'ler ilk
                etapte a ve d property'si. Bunun için deconstruct yapısı kullnılır. Deconstruct method'u class ismiyle aynı isimde olmaz. 
                Deconstruct method'unun ismi, yine deconstruct olmalıdır.
            */

            /*Deconstruct Metot Nasıl Oluşturulur ?
                    Deconstruct özel bir class elemanıdır, yapı olarak bir method'tur. Fakat bildiğimiz method'lardan biraz farklı tanımlanırlar.
                Deconstruct method'un adı Deconstruct olmalıdır. Void geri dönüş tipindedir. Erişim belirleyicisi public olmalıdır.
            
                    Class ClassName
                    {   
                        prop x;
                        prop y
                        public void Deconstruct(out string a, out string b)
                        {
                            a = x;
                            b = y;
                        }
                    }
            */

            //Orneklendirme
            Person person1 = new Person()
            {
                Name = "Furkan",
                Age = 26,
            };

            var (name, age) = person1;
            Console.WriteLine($"{name} {age}");
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Deconstruct(out string name, out int age)    //out olarak alınan parametreler tuple olarak döndürülür.
        {
            name = Name;
            age = Age;
        }
    }
}