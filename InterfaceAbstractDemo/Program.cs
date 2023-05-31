using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerCheckManager customerCheckManager = new CustomerCheckManager();
            BaseCustomerManager neroCustomerManager = new NeroCustomerManager();
            BaseCustomerManager starbucksCustomerManager = new StarbucksCustomerManager(customerCheckManager);

            Customer customer1 = new Customer() { Id = 1, FirstName = "Furkan", LastName = "Arıkan", DateOfBirth = new DateTime(1997, 6, 24), NatinaltyId = "17822017840" };

            neroCustomerManager.Save(customer1);
            Console.WriteLine("***********");
            starbucksCustomerManager.Save(customer1);
        }
    }
}