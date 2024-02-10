namespace VirtualStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Virtual Structures(Sanal Yapılar) - Virtual & Override");

            /*Virtual Structures(Sanal Yapılar) Nedir - 1 ?
                    Bir object üzerinden var olan tüm member'ların tamamı compiler time'da(derleme aşaması) belirgindir, yani compiler time'da object üzerinden hangi method'ların 
                çağırılabileceği bilinmektedir.
                    
                        class MyClass
                        {
                            public int MyProperty{get;set;}
                            public void MyMethod()
                            {
                            }
                        }

                        Compiler Time => MyClass class'ından bir object üretildiğinde biliyoruz ki MyProperty ve MyMethod adında iki tane object member var ve çağırılabilirler. 

                    Virtual structures ile compiler time'da kesin bilinen bu bilgiler, run time'da(çalışma aşaması) belirlenmektedir. Yani ilgili object'in hangi member'larının
                kullanılacağını run time'da belirlemek istiyorsak virtual structures kullanırız.
                    Virtual structures, bir class içerisinde bildirilmiş olan ve o class'tan türetilen derived class'larda da tekrar bildirilebilen yapılardır. Virtual structures method
                yada property olabilirler. Bir class'ta bildirilen bir virtual structer member'ı, bu sınıftan türeyen derived class'larda ezilebilmekte ve yeniden oluşturulabilmektedir.
                Virtual structures'da, name hiding'de olduğu gibi isimsel çakışmadan ziyade, parent class'tan gelen bir member'ın işlevini iptal edip, yeniden yapılandırması söz
                konusudur.
                    Bir class'ta tasarlanmış virtuac structure işlevinin iptal edilip edilmeme durumuna göre tanımlandığı class'tan mı yoksa bu parent class'tan inherit edilen derived
                class'lardan mı çağırılacağının belirlenmesi run time'da gerçekleştirilir. 
                    Bir virtual structure member'ın hangi object'e ait olduğunun belirlenmesi run time'da gerçekleştirilir, bu işleme ise late binding(geç bağlama) denir.
            */

            /*Virtual Structures Ne İçin Kullanılır ?
                   Bir parent class'ta üretilen herhangi bir member'ın, derived class'larda name hiding durumuna düşürmeden ezilip/yeniden yapılandırılması için virtual structures 
                kullanılır. Parent class'taki bir virtual structure member'ı derived class'larda illa ezilip yeniden yapılandırılmak zorunda değildir. İhtiyaç doğrultusunda yeniden
                yapılandırılması gerekirse, name hiding'e düşmeden yeniden yapılandırılabilir.
            */

            /*Virtual Structure Nasıl Oluşturulur ? 
                    Bir class'ta virtual yapı oluşturabilmek için, ilgili member'ın imzasını virtual keyword'u ile işaretlemek yeterlidir.
            
                        Normal Tanımlama                                            Virtual Tanımlama

                        class MyClass                                               class MyClass
                        {                                                           {
                            public int MyProperty{get;set;}                             public virtual int MyProperty{get;set;}     => Virtual Property
                            public void MyMethod()                                      public virtual void MyMethod()              => Virtual Method
                            {                                                           {
                            }                                                           }
                        }                                                           }
            */

            /*Virtual Structure Nasıl Ezilir ? 
                    Bir parent class'ta virtual keyword'u ile işaretlenip sanal hale getirilmiş bir member, derived class'ta yeniden yapılandırılmak isteniyorsa imzasına override 
                keyword'u işaretlenmiş şekilde tekrardan oluşturulur.
            
                        Parent Class                                                Derived Class

                        class MyParentClass                                         class MyDerivedClass : MyParentClass
                        {                                                           {
                            public virtual int MyProperty{get;set;}                     public override int MyProperty{get;set;}     
                            public virtual void MyMethod()                              public override void MyMethod()              
                            {                                                           {
                            }                                                           }
                        }                                                           }

                    Parent class'ta virtual keyword'u ile işaretlenip sanallaştırılmış bir member, derived class'larda illa override edilip yeniden yapılandırılmak zorunda değildir.
                Fakat bir derived class, parent class'taki virtual structure member'ını override edicekse o member'ın kesinlikle parent class'ta virtual keyword'u ile işaretlenmesi 
                gerekmektedir. Virtual ile işaretlenmemiş bir member, kesinlikle override edilemez.
                    Override keyword'unu ileride abstract class'ların implementasyonunda da kullanacağız.
            */

            /*İkiden Çok Hiyerarşik Interface Durumların Override İşlemleri
                    Bir parent class'ta virtual keyword'u ile işaretlenmiş bir member, illa ki birinci dereceden derived class'larda override edilmek mecburiyetinde değildir. İhtiyaç
                durumlarına göre alt seviyedeki derived class'larda da override işlemi gerçekleştirilebilir.
                    Fakat bu durumlar kritikdir. Örneğin 3. dereceki derived class'ta override edilen bir member, 4. ve sonraki derecedeki member'larda, override hali ile aktarılacaktır.
            */

            #region Örnek1
            //Terlik terlik1 = new Terlik();
            //terlik1.Bilgi();

            //Kalem kalem1 = new Kalem();
            //kalem1.Bilgi();
            #endregion

            #region Örnek2
            //Maymun m = new Maymun();
            //m.Konus();

            //Inek i = new Inek();
            //i.Konus();
            #endregion

            #region Örnek3
            Ucgen u = new Ucgen(3, 4);
            Console.WriteLine(u.AlanHesapla());

            Dortgen d = new Dortgen(3, 4);
            Console.WriteLine(d.AlanHesapla());
            #endregion
        }
    }

    #region Örnek1
    class Obje
    {
        public virtual void Bilgi()
        {
            Console.WriteLine("Ben bir objeyim.");
        }
    }

    class Terlik : Obje
    {
        public override void Bilgi()
        {
            //base.Bilgi();
            Console.WriteLine("Ben bir terliğim.");
        }
    }

    class Kalem : Obje
    {

    }
    #endregion

    #region Örnek2
    class Memeli
    {
        public virtual void Konus()
        {
            Console.WriteLine("Ben Konuşuyorum.");
        }
    }

    class Maymun : Memeli
    {
        public override void Konus()
        {
            Console.WriteLine("Ben Maymunum.");
        }
    }

    class Inek : Memeli 
    {
        public override void Konus()
        {
            Console.WriteLine("Ben İneğim.");
        }
    }
    #endregion

    #region Örnek3
    class Sekil
    {
        public int _boy;
        public int _en;

        public Sekil(int boy, int en)
        {
            _boy = boy;
            _en = en;
        }

        public virtual int AlanHesapla()
        {
            return 0;
        }
    }

    class Ucgen : Sekil
    {
        public Ucgen(int boy, int en) : base(boy, en)
        {
            
        }

        public override int AlanHesapla()
        {
            //return base.AlanHesapla();
            return _boy * (_en / 2);
        }
    }

    class Dortgen : Sekil
    {
        public Dortgen(int boy, int en) : base(boy, en)
        {
            
        }

        public override int AlanHesapla()
        {
            //return base.AlanHesapla();
            return _boy * _en;
        }
    }

    class Dikdörtgen : Sekil
    {
        public Dikdörtgen(int boy, int en) : base(boy, en)
        {
            
        }

        public override int AlanHesapla()
        {
            //return base.AlanHesapla();
            return _boy * _en;
        }
    }
    #endregion
}