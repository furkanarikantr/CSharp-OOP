namespace ReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 20;

            sayi1 = sayi2;

            sayi2 = 100;

            Console.WriteLine("Sayı 1 : " + sayi1 + " " + "Sayı 2 : " + sayi2);

            /*
                Value Types (Değer Tip)           
                int, decimal, float, enum, boolean

                Bir değişken tanımlandığında, bilgisayarın belleğinde işlemler başlar. Bellekte Stack ve Heap adında iki alan bulunur.
                Değerli tipli değişkenler, belleğin Stack kısmında oluşur.
            */

            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };

            sayilar1 = sayilar2;

            sayilar2[0] = 1000;

            Console.WriteLine("sayılar1[0] = " + sayilar1[0]);

            /*
                Reference Types (Referans Tip)           
                array, class, interfaces

                Bir değişken tanımlandığında, bilgisayarın belleğinde işlemler başlar. Bellekte Stack ve Heap adında iki alan bulunur.
                Referans tipli değişkenler, belleğin Heap kısmında oluşur.
            */

            //*******************Class*******************
            Person person1 = new Person();
            Person person2 = new Person();

            person1.FirstName = "Furkan";
            person2 = person1;
            person1.FirstName = "Serkan";
            Console.WriteLine(person2.FirstName);


            Customer customer = new Customer();

            customer.FirstName = "Hatice";
            Person person3 = customer;
            customer.FirstName = "Duygu";
            Console.WriteLine(person3.FirstName);
            customer.CreditCardNumber = "1234567890";
            Console.WriteLine(((Customer)person3).CreditCardNumber);


            Employee employee = new Employee();

            employee.FirstName = "Kadriye";

            PersonManager personManager = new PersonManager();
            personManager.Add(employee);
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}