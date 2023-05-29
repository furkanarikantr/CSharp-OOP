namespace ConstructorsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Constructor (Yapıcı)

                Bir sınıfı new'lediğimizde çalışan blocktur. Bir class ilk kez oluştuğu zaman constructor bir kere çalışır ve bir daha çalışmaz.
            */

            Customer customer1 = new Customer { Id = 1, FirstName ="Furkan", LastName="Ankara", City="Ankara"};
            Console.WriteLine(customer1.FirstName);

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Serkan";
            customer2.LastName = "Arıkan";
            customer2.City = "Ankara";
            Console.WriteLine(customer2.FirstName);

            Customer customer3 = new Customer(3, "Duygu", "Arıkan", "Ankara");
            Console.WriteLine(customer3.FirstName);
        }
    }

    class Customer
    {
        //Default constructor
        public Customer()
        {
            Console.WriteLine("Default Constructor Started!");
        }

        public Customer(int id, string firstName, string lastName, string city)
        {
            Console.WriteLine("Constructor Started!");
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}