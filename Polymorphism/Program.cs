namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Polymorphism(Çok Biçimlilik)");

            /*Polymorphism Nedir ?
                    Bir object'in birden fazla farklı türdeki referans tarafından işaretlenebilmesine polymorphism denir. Canlandırmak gerekirse, elimizde mouse class'ından üretilmiş bir 
                mouse object'imiz olsun. Bu mouse object'i aynı zamanda product class'ından inheritance ediliyorsa, bu mouse bir taraftan product'tur. Mouse'dan üretilen bir object'in
                bir yandan mouse olması bir yandan da product olması demek, bu mouse object'inin hem mouse class'ının refaransını, hem product class'ının referansını referans edebilmesi
                durumu, polymorphism olarak adlandırılır.
                    Polymorphism, bir class'tan üretilen object'in, kendi class'ının inheritance ile parent class'larla kurduğu ilişki sayesinde, parent class'ların referanslarıyla
                işaretlenebilmesi durumudur.
                    Bir object'in birden fazla referans ile işaretlenebilmesi, o object'in birden fazla class'ın özelliklerini kullanabilmesini sağlar.
                    Bir object'in kendi class'ı dışında, başka bir object'in class'ının referansıyla işaretlenebilmesi için, kesinlikle class'lar arasında inheritance ilişkisi olmak
                zorundadır.
                    Bir object'i, kendi class'ının dışındaki bir class referansı ile işaretliyebilmek için kesinlikle ilgili object, o class'tan inheritance almış olmak zorundadır.
           */

            /*Polymorphism Felsefesi
                    Kuş diyince aklımıza gelen kuş türleri vardır, örnek olarak kartal, penguen, papağan gibi. Yani muhabbet kuşuda bir kuştur, deve kuşuda. Yani kartal bir taraftan
                kartal iken, bir yandan da kuştur. İşte buradaki hayvanlar, kendi türlerinin yanında bir yanda da kuş diye nitelendirilmeleri polymorphism örneğidir.
                    Aynı zamanda kuş olmayan hiçbir hayvana kuş demiyoruz. Mesala bir kaplana, maymuna yada köpeklere kuş demeyiz. Buradan şöyle bir sonuç çıkartıyoruz, Parent class'tan
                gelen yani ortak olarak kuş class'ından üretilen tüm object'ler yani kartallar, papağanlar gibi türler, ya kendi class'larından yada parent classlarından yani Kuş'tan 
                referans edilebilirler.
                    Yazılımsal olarak polymorphism'in söz konusu olabilmesi için teknik olarak inheritance işleminin gerçekleşmesi gerekmektedir.
            */

            /*Polymorphism Object Yönetiminde Neye Yarar ?
                    Bir object'in referansı olan class'ın, başka class'lardan inheritance edilip onların referanslarına sahip olması, object'imizin o class'ların member'larını 
                kullanabilmesini sağlar.
            */

            /*Polymorphism Türleri
                    Static Polymorphism(Statik Çok Biçimlilik) ve Dynamic Polymorphism(Dinamik Çok Biçimlilik) olmak üzere iki çeşit polymorphism türü vardır.
      
                    Static polymorphism, compiler time(derleme zamanı)'ta sergilenen bir polymorphism'dir. Hangi işlemin yapılacağına compiler time'da karar verilir. C#'ta static 
                polymorphism denilince aklımıza Method Overloading gelmektedir.
                    Method overloading, aynı isimde birbirinden farklı imzalara sahip olan method'ların tanımlanmasıdır. Bu durumda, bir method'un birden fazla formunun olması bir 
                polymorphism örneğidir. Bunlardan kullanılacak olanın compiler time'da bilinmesi ise, static polymorphism olarak adlandırılmaktadır.

                    Dynamic polymorphism, run time(çalışma zamanı)'da sergilenen bir polymorphism'dir.Hangi işlemin yapılacağına run time'da karar verilir. C#'ta dynamic polymorphism
                denilince aklımıza Method Override(Overriding) gelmektedir.
                    Method override, base class'ta virtual olarak işaretlenmiş method'ların derived class'ta override edilerek ezilmesi işlemidir.Bu durumda, bir method'un birden fazla formunun olması bir 
                polymorphism örneğidir. Bunlardan kullanılacak olanın run time'da bilinmesi ise, dynamic polymorphism olarak adlandırılmaktadır.
            */

            #region Örnek1
            MyClass m1 = new MyClass2();
            MyClass2 m2 = new MyClass2();
            #endregion

            #region Örnek2
            Kus kus2 = new Papagan();
            Kus kus1 = new Kartal();
            Kus kus3 = new KayaKartali();

            Papagan papagan1 = new Papagan();
            Kartal kartal = new Kartal();
            KayaKartali kayaKartali = new KayaKartali();
            #endregion

            #region Örnek3
            Erkek erkek = new Erkek();
            Kadin kadin = new Kadin();

            Insan insanE = new Erkek();
            Insan insanK = new Kadin();
            #endregion

            #region Örnek4
            C c = new C();
            c.X();
            c.Y();
            c.Z();

            B b = new C();
            b.X();
            b.Y();

            A a = new A();
            a.X();
            #endregion
        }
    }

    #region Örnek1
    class MyClass { }
    class MyClass2 : MyClass { }
    #endregion

    #region Örnek2
    class Kus
    {
    }

    class Papagan : Kus
    {
    }

    class Kartal : Kus
    {
    }

    class KayaKartali : Kartal 
    {
    }
    #endregion

    #region Örnek3
    class Insan 
    {
        
    }

    class Erkek : Insan
    {
        
    }
    
    class Kadin : Insan
    {

    }
    #endregion

    #region Örnek4
    class A
    {
        public void X() { }
    }

    class B : A
    {
        public void Y() { }
    }

    class C : B
    {
        public void Z() { }
    }
    #endregion
}
