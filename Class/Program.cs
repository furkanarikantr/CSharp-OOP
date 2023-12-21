namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Ders2
                *** Class Nedir ? Neden Class Yapısı Kullanılır ?
                        Object'leri oluşturmak için kullandığımız modeli oluşturabilmek için Class yapısı kullanılır. Class yapısı, kendi içerisinde
                    object'in field'lerini, property'lerini, indexer'ını ve method'larını tutmamızı sağlar.

                *** Class ile Object Arasındaki İlişki Nedir ?
                        Class'lardan belleğindeki olan alan kadar object oluşturulabilir. Class'larda object'lere ait ortak member(eleman) tanımları
                    yapılır.(Ad(Field) - YasHesapla(Method) -> Bütün object'lerde artık Ad(Field) - YasHesapla(Method) bulunur fakat her object'te
                    değerleri farklıdır.)

                *** Class Nasıl ve Nerede Oluşturulur ?
                        Class oluşturulması =>  class classIsmi 
                                                {
                                                    field...
                                                    property...
                                                    indexer...
                                                    method...        
                                                }
                        Class üç farklı yerde oluşturuldur. namespace içerisinde, namespace dışarısında ve class içerisinde(nested type).
                    Bir class tanımlamasında tanımlanan yerde(namespace içi/dışı - class) aynı isimde birden fazla class tanımlanamaz. 

                *** Class ile Object Modeli Tasarlama
                        OrnekModel class'ı ile gösterilmiştir.

                *** Class Modelinden Referans Noktası Oluşturma
                        
                
            */
            Console.WriteLine("Class Yapısı.");
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