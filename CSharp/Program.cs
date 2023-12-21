namespace CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Ders1
                *** Object-Oriented Programing (Nesne Tabanlı Programlama)
                        Nesne tabanlı progralama, bir yazılım geliştirme yaklaşımıdır. 
                    (Yaklaşım, bir işin yapılma mantığı, ilerleyiş biçimi, işin matematiğidir.) Bir çok dil tarafından desteklenir.
                    Bu yaklaşım yazılım geliştirme süreçlerini kısaltan ve sistematik hale getiren bir tekniktir. Gerçek hayatta
                    yapılan bir işi ele aldığımızda, bu işte kullanılan objeleri programlama içine entegre eden bir yaklaşımdır. Genel
                    olarak herşey bir nesne olarak kabul edilir.(Ben,sen,o,çalışan,personel,bardak,ürün,satış,araba,...)
                    Gerçek bir sistem nesne olarak bilinen nesnel parçalara ayrılır. nesneler arasında ilişki kurulur ve nesnelerin
                    gerçek hayattaki birbirleri ile olan etkileşimleri burada kendi aralarındaki haberleşmesi olarak karşımıza gelir.
                
                *** Nesnenin Anatomisi
                        Merkezde nesne(obje/object) vardır. Merkezde bulunan nesnelerin içerisinde veri tutabilecek alanları vardır.
                    Bu alanlara field denir.  Nesnelerin içinde veri tutabilecek alanların yanında bir de operasyonel işleri 
                    yapmamızı fonksiyonlar vardır. Nesnelerin içindeki field'ların değerlerini işleyebilmek için bu fonksiyonlar 
                    bulunur. Fonksiyonlara aynı zamanda method'lar yada property'ler denir.
                        Nesneler programlamada bir sınıf modellemesinin örneğidir. Sınıflara aynı zamanda class'lar denir. 
                    Programlamada bir nesne oluşturabilmek için bir class oluşturman gerekir. Bu oluşturulan class'lardan ise ihtiyaç
                    kadar nesne üretilebilir.

                *** Nesne Modellemesi
                        Nesnelerin oluşturulabilmesi için öncelikle modellenmesi gerekir ve class ile gerçekleştirilir. Modelleme 
                    sonrası oluşturulan class ile istenildiği kadar nesne üretilebilir.

                *** Nesne Türleri
                        Class'lar ve oluşan nesneler referans türlü değerlerdir. Nesneleri tutan değişkenler ise referans türlü 
                    değişkenlerdir. Nesneler ram'de heap alanında tutulur. Nesnelerin referansları ise stack'te tutulur. Biz direk
                    heap'e erişemeyeceğimiz için nesne referanslarını stack'e ekleriz, stack ise heap'e ulaşabileceği için stack'ten
                    heap'teki nesneye ulaşabiliriz. Stack'teki değerler ise Refenrans türlü değerlerdir.

                *** Sıralama
                *CSharp
                *Class
            */
            Console.WriteLine("Notları Tutalım.");
        }
    }
}