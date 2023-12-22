namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Ders2
                

               

                

                

                
                    
                 
                            

            */
            Console.WriteLine("Class Yapısı.");

            /*Class Nedir ? Neden Class Yapısı Kullanılır ?
                    Object'leri oluşturmak için kullandığımız modeli oluşturabilmek için Class yapısı kullanılır. Class yapısı, kendi içerisinde
                object'in field'lerini, property'lerini, indexer'ını ve method'larını tutmamızı sağlar.
            */

            /*Class ile Object Arasındaki İlişki Nedir ?
                    Class'lardan belleğindeki olan alan kadar object oluşturulabilir. Class'larda object'lere ait ortak member(eleman) tanımları
                yapılır.(Ad(Field) - YasHesapla(Method) -> Bütün object'lerde artık Ad(Field) - YasHesapla(Method) bulunur fakat her object'te
                değerleri farklıdır.) 
            */

            /*Class Nasıl ve Nerede Oluşturulur ?
                    Class oluşturulması =>  class classIsmi 
                                            {
                                                field...
                                                property...
                                                indexer...
                                                method...        
                                            }
                    Class üç farklı yerde oluşturuldur. namespace içerisinde, namespace dışarısında ve class içerisinde(nested type).
                Bir class tanımlamasında tanımlanan yerde(namespace içi/dışı - class) aynı isimde birden fazla class tanımlanamaz.  
            */

            /*Class ile Object Modeli Tasarlama
                    OrnekModel class'ı ile gösterilmiştir. 
            */

            /*Class Modelinden Referans Noktası Oluşturma
                    Referans noktası, heap'te bulunan object'in referans adresini stack'te tutulduğu noktadır. Yani referans, stackt'te tutulan
                ve heap'teki herhangi bir object'i işaretliyebilme özelliği sahip olan noktadır. Bir class tanımlandığında, o class'ın adı 
                artık bir türdür. Bu durumda o türü kullanabilmek için class adını kullanmamız gereklidir. OrnekModel ornekModel; 
            */

            //Referans noktası oluşturuldu. OrnekModel türünde model adında bir referans noktası. Referans noktası alma işlemi. Stackt'te tutulur.
            OrnekModel model;

            /*Class Members (Class Elemanları/Üyeleri) * Field * Property * Method * Indexer 
                    - Field : Object içerisinde veri depoladığımız/tuttuğumuz alanlardır. Class içerisindeki değişkenlerdir. Eğer bir değişken
                class içerisinde bir field olarak tanımlanıyorsa ve değeri developer tarafından eklenmediysede default değeri otomatik olarak 
                atanır.
                    - Property : Object içerisinde özellik sağlar. Property özünde bir methodtur. Yani algoritmik kodlarımızı inşa ettiğimiz bir
                methoddur. Fiziksel olarak bir method'tan farkı ise parametre almamaktadır ve get/set olmak üzere iki adet blok içermektedir.
                Property'nin değeri çağırıldığında get bloğu tetiklenirken, propert'ye bir değer ataması yapıldığında set bloğu tetiklenir. 
                Property'lerin işlevsel olarak method'lardan bir farkı yoktur ama object üzerinde değer okuma ve atama işlemlerinde kullanılır. 
                    Uygulamalarımızda object'lerimizin içerisinde field'lara direkt olarak erişilmesini istemeyiz ve bunun için object'lerdeki 
                verileri kontrollü bir şekilde dışarıya açarız. Bunları ise property'ler ile yaparız. Yani property'ler, object içerisindeki 
                field'lerin dışarıya kontrollü bir şekilde açılmasını veya dışarıdan kontrollü bir şekilde değer almasını sağlayan yapılardır. Ve
                devamında property'lerin yaptığı bu işleme/işleve encapsulation(kapsülleme/sarmalama) denir. Property'ler hangi field'ları 
                temsil ediyorsa o field'ın türünde olmak zorundadır.
                        --Encapsulation => Encapsulation bir objectdeki field'lara ait data'ları dışarıya kontrollü bir şekilde gönderilmesi veya 
                        dışarıdan data'ların kontrollü bir şekilde alınmasıdır.
                    Property yapısı oluşturabilmemizin birkaç farklı yolu vardır. * Full Property * Prop * Auto Property Initializers 
                * Ref Readonly Returns * Computed Properties * Expression-Bodied Property * Read Only Property * Init-Only Properties/Init Accessor
                        --Full Property => En sade ve temel property yapılanmasıdır. İçerisinde get/set blokları tanımlanmalıdır. Eğer set bloğu
                        bloğu tanımlanmazsa sadece okunulabilir, get bloğu tanımlanmazsa sadece yazılabilir olur.
                        [erişim belirleyicisi][geri dönüş değeri][property adı]
                        {
                            get{} -> Property'den data istendiğinden tetiklenir.
                            set{} -> Property'e data gönderildiğinde tetiklenir.Gönderilen data'yı value keyword'ü ile yakalar.
                        }
                        --
            
            */

            /*Field
            MyClass m1 = new MyClass();     //MyClass türünden m1 referansı ile MyClass object'i oluşturuyoruz.
            m1.a = 10;                       //m1 referansı ile MyClass object'ine erişip, o object'in a field'ına ulaşıyoruz.

            MyClass m2 = new MyClass();
            m2.a = 20;                       //m2 referansı ile MyClass object'ine erişip, o object'in a field'ına ulaşıyoruz.
            */

            /*Property*/
            MyClass myClass = new MyClass();
            Console.WriteLine(myClass.Yasi); //Object'teki field data'sını ekrana bastırır. Eğer atanmamışsa default data gelir. 0
            myClass.Yasi = 10;               //Object'deki field datasına göndirelen datayı enjekte eder.  
            Console.WriteLine(myClass.Yasi); //Object'teki field data'sını ekrana bastırır. Eğer atanmamışsa default data gelir. 10

        }
    }

    class MyClass
    {
        //Field
        int yasi; 
        string b;

        //Property
        public int Yasi //FullProperty
        {
            get { return yasi; }
            set { yasi = value; }
        }
    }

    class OrnekModel
    {
        int a;
        int b;

        public void X()
        {
            Console.WriteLine(a + " " + b);
        }

        public int Y()
        {
            return a * b;
        }
    }

    //namespace içi class'ı.
    class insideNamespaceClass
    {
        //class içi class'ı.
        class nestedTypeClass 
        {
            
        }
    }
}

//namespace dışı class'ı.
class outsideNamespaceClass
{

}