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
           */

            /*Polymorphism Felsefesi
                    Kuş diyince aklımıza gelen kuş türleri vardır, örnek olarak kartal, penguen, papağan gibi. Yani muhabbet kuşuda bir kuştur, deve kuşuda. Yani kartal bir taraftan
                kartal iken, bir yandan da kuştur. İşte buradaki hayvanlar, kendi türlerinin yanında bir yanda da kuş diye nitelendirilmeleri polymorphism örneğidir.
                    Aynı zamanda kuş olmayan hiçbir hayvana kuş demiyoruz. Mesala bir kaplana, maymuna yada köpeklere kuş demeyiz. Buradan şöyle bir sonuç çıkartıyoruz, Parent class'tan
                gelen yani ortak olarak kuş class'ından üretilen tüm object'ler yani kartallar, papağanlar gibi türler, ya kendi class'larından yada parent classlarından yani Kuş'tan 
                referans edilebilirler.
                    Yazılımsal olarak polymorphism'in söz konusu olabilmesi için teknik olarak inheritance işleminin gerçekleşmesi gerekmektedir.
            */

            /*Polymorphism - Inheritance İlişkisi
                    Bir object'i, kendi class'ının dışındaki bir class referansı ile işaretliyebilmek için kesinlikle ilgili object, o class'tan inheritance almış olmak zorundadır.
                

            */

            #region Örnek1
            MyClass m1 = new MyClass2();
            MyClass2 m2 = new MyClass2();
            #endregion
        }
    }

    #region Örnek1
    class MyClass { }
    class MyClass2 : MyClass { }
    #endregion
}
