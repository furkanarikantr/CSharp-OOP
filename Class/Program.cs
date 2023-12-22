namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            /*Class İçerisinde Tanımlanan Class, Class Elemanı mıdır ?
                    Class içerisindeki class, üst class'ın bir member'ı değildir. Bir class'ın member'larına class'ın object'i üzerinden 
                erişebiliyoruz fakat class içerisindeki class'a member'ı olmadığı için erişemiyoruz.
            */

            /*Class Elemanlarına Açıklama Satırı Nasıl Eklenir ?
                    /// <summary>
                    /// Bu bir örnek class'tır.
                    /// </summary>
            */

            //Referans noktası oluşturuldu. OrnekModel türünde model adında bir referans noktası. Referans noktası alma işlemi. Stackt'te tutulur.
            //OrnekModel model;

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
                        --Prop => Encapsulation yapılıp hiç bir işleme, duruma tutulmadan sade bir şekilde yapılmasıdır. Prop property'ler compile
                        edildikten sonra arka planda kendi field'larını oluştururlar. Dolayısıyla prop property'si kullanılacaksa field tanımlamaya
                        gerek yoktur.
                        [erişim belirleyicisi][geri dönüş değeri][property adı]
                        {
                            get; -> Property'den data istendiğinden tetiklenir.
                            set; -> Property'e data gönderildiğinde tetiklenir.Gönderilen data'yı value keyword'ü ile yakalar.
                        }
                        --Auto Property Initializers => Bir property'nin ilk datasını object oluşturulur oluşturulmaz verebiliriz.
                        [erişim belirleyicisi][geri dönüş değeri][property adı]{ get; set; } = 15
                        --Ref Readonly Returns => Bir class içerisindeki field'ı referansıyla döndürmemizi sağlayan ve biryandan da bu değişken
                        değerini read only yapan özelliktir.
                        --Computed Properties => İçerisinde işlem, algoritma taşıyan property'lerdir.
                        --Expression-Bodied Properties => Tanımlanan property'de lambda expression kullanmamızı sağlayan söz dizimidir.
                        --Init-Only Properties - Init Accessor => Init-Only Properties onject'in sadece ilk yaratılış anında data atanmasıdır.
                        Böylece iş kuralı gereği run-time'da datası değişmemesi gereken object'ler için önlem alınmaktadır.
                    - Method : Object'deki field data'larında yahut dışarıdan gelen data'larda işlem yapmamızı sağlayan temel programatik 
                parçalardır. Method'lar ile property'ler arasındaki temel fark, property'lerin bir geri dönüş türü olmak zorundayken, method'ların
                geri dönüş türü olmak zorunda değildir. void olabilirler.
                    - Indexer : Object'e indexer özelliği kazandıran, property'ler ile aynı olan elemanlardır.
                    [erişim belirleyicisi][geri dönüş değeri]this[parametreler]{get{} set{}}
            */

            //Field
            /*Field
            MyClass m1 = new MyClass();     //MyClass türünden m1 referansı ile MyClass object'i oluşturuyoruz.
            m1.a = 10;                       //m1 referansı ile MyClass object'ine erişip, o object'in a field'ına ulaşıyoruz.

            MyClass m2 = new MyClass();
            m2.a = 20;                       //m2 referansı ile MyClass object'ine erişip, o object'in a field'ına ulaşıyoruz.
            */

            //Property
            /*FullProperty
            MyClass myClass = new MyClass();
            Console.WriteLine(myClass.Yasi); //Object'teki field data'sını ekrana bastırır. Eğer atanmamışsa default data gelir. 0
            myClass.Yasi = 10;               //Object'deki field datasına göndirelen datayı enjekte eder.  
            Console.WriteLine(myClass.Yasi); //Object'teki field data'sını ekrana bastırır. Eğer atanmamışsa default data gelir. 10
            */

            /*Prop
            MyClass myClass = new MyClass();
            myClass.Yasi = 20;
            Console.WriteLine(myClass.Yasi);
            */

            /*Auto Property Initializers
            MyClass myClass = new MyClass();
            Console.WriteLine(myClass.Yasi);
            */

            //Method
            /*Method
            MyClass myClass = new MyClass();
            Console.WriteLine(myClass.X());
            */

            //Indexer
            /*Indexer
            MyClass myClass = new MyClass();
            myClass[5] = 5;
            */

            /*Class İçerisindeki Class
            MyClass2 myClass2 = new MyClass2();
            MyClass2.MyClass3 myClass3 = new MyClass2.MyClass3(); //Class'taki class class member'ı olmadığı için referansı üzerinden gideriz.
            */


        }
    }

    class MyClass
    {
        //Field
        int yasi;
        string adi = "Furkan ARIKAN";
        int s1 = 5;
        int s2 = 15;

        //Property
        /*FullProperty
        public int Yasi
        {
            get { return yasi; }
            set { yasi = value; }
        }
        */

        /*Prop
        public int Yasi { get; set; }
        */

        /*Auto Property Initializers
        public int Yasi { get; set; } = 15;
        */

        /*Ref Readonly Returns
        public ref readonly string Adi => ref adi;
        */

        /*Computed Properties
        public int Topla
        {
            get
            {
                return s1 + s2;
            }
        }
        */

        /*Expression-Bodied Properties
        public string Cinsiyet { get; set; } = "Erkek";
        */

        /*Method
        public int X()
        {
            return 0;
        }
        */

        /*Indexer
        public int this[int a] { get { return a; } set { } }
        */

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

    /// <summary>
    /// Bu bir örnek class'tır.
    /// </summary>
    class MyClass2
    {
        //Field
        /// <summary>
        /// Bu bir field'dır.
        /// </summary>
        int a;

        //Prop
        /// <summary>
        /// Bu bir property'dir.
        /// </summary>
        public int MyAProperty { get; set; }
        
        //Method
        /// <summary>
        /// Bu bir method'dur.
        /// </summary>
        public void X()
        {

        }

        //Indexer
        /// <summary>
        /// Bu bir indexer'dır.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public int this[int a]
        {
            get { return 0; }
        }

        //Nested Class
        /// <summary>
        /// Bu bir nested class'tır.
        /// </summary>
        public class MyClass3
        {

        }
    }
}

//namespace dışı class'ı.
class outsideNamespaceClass
{

}