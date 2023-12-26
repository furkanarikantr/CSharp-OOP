namespace Object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Object Yapısı");

            /*Object Nedir ? Object Kullanılır ?
                    İçerisinde bir veya birden fazla data barındırabilen, anlamlı data'ları bir bütün olarak barındıran organizmadır/oluşumdur.
                Object'ler complex datalardır çünkü içerisinde birden farklı türlerde data tutabilirler. Object'leri modellememizi sağlayan 
                class'lar ise complex type'lardır.
                    Yazılımda yapılmış ve yapılacak olan işlemleri, daha hızlı, sistematik, okunabilir, yönetilebilir ve kullanılabilir hale 
                getirmek için object yapıları tercih edilir.
            */

            /*Bir Class'tan Object Oluşumu
                    Bir object oluşturmak için semantic açıdan C# da new operatörü kullanılır. new operatörü, oluşturulacak object'in hangi 
                class'tan olacağını gösterir/belirler. Oluşan object ram'in heap bölgesine atanır. Developer'ların heap'e erişme izni olmadığı için
                heap'teki oluşan object'e stack'teki bir referanslar işaretlemesi lazım. 
                
                Type referanceName  => type - tür | referanceName - heap'teki oluşacak olan object'in adresini tutan data
                new Type();         => new operatöründen sonra ilgili class'ın türünü bildirmemiz gereklidir. - new MyClass()
                Type referanceName = new Type();
            */

            /*Target-Typed New Expresion
                    Object oluşum sürecinde oluşturulacak object direkt bir referansa atanıyorsa, burada hangi object'in oluşturulduğu referans
                sayesinde bilinmektedir. Type referanceName = new Type() diyerek, Type() class'ından bir object oluşturup onun referansını 
                referanceName ile tutuyoruz. Target-Typed sayesinde ise Type referanceName = new() diyerekte referans tutup object oluşturabiliriz.
            */

            /*Referans Nedir ?
                    Ram'in stack bölgesinde tanımlanan ve Heap bölgesindeki nesneleri işaretleyen/referans eden variable'lardır/noktalardır.
                Referans variable'ları sadece object'leri referans etmek zorunda değildir. Bu durumlarda eğer referans variable'ı bir object'i
                referans almıyorsa null değerini alır.

                /Ara Not - Data Types (Veri Tipleri)
                    Variable'lar(değişkenler) ram'de tutulan datalardır. Bir variable kullanılırken aslında o variable'ın bellekte tutulduğu 
                adresindeki data'ya ulaşırız.Bu referans variable'ları class'lar, interface'ler, abstract class'lar ve record'lar ile oluşturulur.

                    -Value Type = Value type'lar, değerleri doğrudan içeren tiplerdir. Basit tipler olarak anlandırılırlar ve ram'de stack'te 
                tutulurlar.
                    -Reference Type = Reference type'ler, değerlerini bellekteki bir konumdan alırlar ve bu konum stack üzerinde saklanan bir
                adres(referans) olur. Karmaşık veri yapılarıdır ve ram'de heap'te tutulurlar.
            */

            /*Stack-Heap İlişkisi
                    MyClass m = new MyClass();

                    Stack   => m, MyClass türünde, stack'te bulunan, MyClass object'ini referans eden bir variable'dır.
                    Heap    => new MyClass() işlemi sayesinde MyClass türünde m adında object oluşturulur, heap'te tutulur.

                    Object'lerin refenrance variable'lar ile referans işaretlenmesinin nedeni, object'lerin heap'te barınması ve developer'ların
                heap'e direk olarak erişememesidir. Developer'ların heap'e dolaylı yoldan erişebilmesi için referance variable'ları kullanarak 
                referanslar üzerinden heap'teki object'lere ulaşabiliriz.
            */

            /*Referanssız Object'ler
                    Her object bir referansla işaretlenmek zorunda değildir. Object heap'te bulunur, fakat object'in referansını tutan object 
                türünde bir variable stackt'te olmaz. Bu durumda bu object'e bir daha erişemeyiz. Eğer bir object referansız olarak oluşturuluyor
                ise, bu object ram'de gereksiz yer kaplayacağından dolayı garbage collector yapısı ile ram'den temizlenecektir. Garbage collector,
                heap'te, referansız olan object'leri temizlemekten sorumludur.
            */

            /*Referanssız Object'in Member'larına Nasıl Erişiriz ?
                    Referansız object'lere object'ler oluşturulduktan sonra bir daha erişilemez. Bu object'lere erişebilmenin tek yolu, object'i
                oluşturma anıdır.
            */

            /*Object Initializer ile Object Oluşturma Esnasında Property'lere İlk Değeri Atama
                    Object initializer, object oluşturulurken object'in data eklenebilen memberlarına(field/prpoerty) data eklememizi sağlar.

                    Type referanceName = new Type()
                    {   ->Object Initializer açılış
                        propertyName = data;
                    }   ->Object Initializer kapanış
            */

            /*Object&Value Kopyalama Nedir?
                    Object kopyalama işlemi özünde iki davranış üzerinden ilerler. Shallow copy ve deep copy.
                    
                    Shallow Copy = Var olan bir object'in referansının kopyalanmasıdır. Neticede eldeki değer coğaltılmaz, sadece birden fazla
                referans ile işaretlenmiş olur.
                    Deep Copy = Var olan bir object'in object miktarı çoğalır. Aynı member ve data'lara sahip olan ram'de farklı bir object
                oluşturulur.

                /Ara Not - Value Type - Reference Type Copy Operations
                    Value Type = Deep Copy(derinlemesine kopyalama) yapar. 
                    Reference Type = Shallow Copy
            */

            //Orneklendirme

            //Oject oluşumu - new operatörü ile MyClass türünde object oluştu, ramde'ki heap bölgesine atandı. Object'e erişmek için, object'in
            //türünde object'in referansını tutan bir myClass variable'ı oluşturuldu.
            MyClass objectReferance1 = new MyClass();   //Klasik kullanım

            MyClass objectReferance2 = new();           //Target-Typed

            MyClass2 m1 = new MyClass2();
            //Referance variable üzerinden .(member access) operatörü ile object'in member'larına erişiriz.
            m1.MyProperty = 10;   //

            /*
                Referans noktası olmayan referance variable. Bu durumda referance variable ile class member'larına erişebiliriz.
            Fakat bu referance variable'ın object'i olmadığı için member'ların tetiklenmesi yapılmaz. Bu member'lar işlenmeye çalıştığında ise
            NullReferance hatası alınır.
            */
            //MyClass2 m2 = null;
            //m2.MyProperty = 20;

            //Referanssız Object
            new MyClass3().MyProperty = 10;

            //Object Initializer - Object oluşturulurken data atanabilen member'larına data ataması yapılır.
            MyClassObjectInitializer myClassObjectInitializer = new MyClassObjectInitializer()
            {
                Age = 10
            };

            //Copy Operations

            //Value Type Variable
            int a = 5;
            int b = a;
            /*Value Type Copy 
                Deey Copy
                Stack ->    (int) a = 5;
                            (int) b = 5;
            */

            //Reference Type Copy
            //Shallow Copy
            MyObjectCopyClass myObjectCopy1 = new MyObjectCopyClass();
            MyObjectCopyClass myObjectCopy2 = myObjectCopy1;
            MyObjectCopyClass myObjectCopy3 = myObjectCopy2;
            MyObjectCopyClass myObjectCopy4 = new MyObjectCopyClass();
            /*Shallow Copy - Explain
                Stack ->                                                Heap ->
                            (MyObjectCopyClass) myObjectCopy1 (111)                 (MyObjectCopyClass) myObjectCopy1 Object - 111
                            (MyObjectCopyClass) myObjectCopy2 (111)                 (MyObjectCopyClass) myObjectCopy4 Object - 112
                            (MyObjectCopyClass) myObjectCopy3 (111)
                            (MyObjectCopyClass) myObjectCopy4 (112)
            */

            //Deep Copy
            MyObjectCopyClass m5 = new MyObjectCopyClass();
            MyObjectCopyClass m6 = m5.Clone();
            /*Deep Copy - Explain
                Stack ->                                                Heap ->
                            (MyObjectCopyClass) m5 (111)                        (MyObjectCopyClass) m5 Object - 111
                            (MyObjectCopyClass) m6 (112)                        (MyObjectCopyClass) m6 Object - 112 (m5'in klonlanmış halidir.)
            */
        }
    }

    class MyClass
    {
        public int a { get; set; }

        public void X()
        {

        }
    }

    class MyClass2
    {
        public int MyProperty { get; set; }
    }

    class MyClass3
    {
        public int MyProperty { get; set; }
    }

    class MyClassObjectInitializer
    {
        public int a;
        public int Age { get; set; }
    }

    class MyObjectCopyClass
    {
        public MyObjectCopyClass Clone()
        {
            //Memberwiseclone, bir class'ın içerisinde o class'tan üretilmiş olan o anki object'i klonlamamızı sağlayan method'dur.
            return (MyObjectCopyClass)this.MemberwiseClone();
        }
    }
}