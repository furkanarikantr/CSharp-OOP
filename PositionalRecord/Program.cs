namespace PositionalRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Positional Record Yapısı");

            /*Positional Record Nedir ?
                    Record'lar, object'lerine object initializer'lar ile ilk dataları üretebilen/atayabilen read-only yapılardır. Positional record
                ise, record'lar içerisinde tanımlamasını yapabildiğimiz constructor ve deconstructor kullanımlarını daha da özelleştirerek 
                kullanılmasını sağlamaktadır.
                    Positional record sayesinde yapılar otomatik olarak eklenir. Farklı olarak constructor yapısı eklemek istediğimizde ise, 
                positional record'dan gelen constructor kullanılmak zorundadır, bu durumda this keyword'u kullanılmalıdır.
            */

            /*Positional Record Nasıl Oluşturulur ?
                    Positional record ile daha hızlı ve kullanışlı bir yapı oluşmuştur. Property'ler, Constructor ve deconstruct otomatik olarak
                oluşturulmaktadır. Property'ler oluşturulurken init şeklinde oluşturulur.
            
                    record MyRecord(string name, string surname)    
                    {
            
                    }
            */

            MyRecord m1 = new MyRecord("Furkan", "Arıkan");
            var (n, s) = m1;
        }

        record MyRecord(string Name, string Surname)    //Positional Record -> Hem constructor, hem deconstruct yapısının karşılığı
        {
            /* Normal Tanımlama
            public MyRecord()
            {

            }

            public void Deconstruct()
            {

            }
            */

            public MyRecord() : this("Default", "Default")
            {
                
            }

            public MyRecord(string name) : this()
            {

            }

            //public string Name => name;
            //public string Surname => surname;   
        }
    }
}