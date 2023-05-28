namespace ClassFunctionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();
            CustomerManager customerManager = new CustomerManager();

            Customer customer1 = new Customer();
            customer1.firstName = "Furkan";
            customer1.lastName = "Arıkan";
            customer1.identifyNumber = 1;

            Customer customer2 = new Customer();
            customer2.firstName = "Duygu";
            customer2.lastName = "Arıkan";
            customer2.identifyNumber = 2;

            Customer customer3 = new Customer();
            customer3.firstName = "Lucky";
            customer3.lastName = "Mia";
            customer3.identifyNumber = 3;

            customerManager.addCustomer(customers, customer1);
            customerManager.addCustomer(customers, customer2);
            customerManager.addCustomer(customers, customer3);

            customerManager.listCustomers(customers);

            customerManager.deleteCustomer(customers, customer3);

            customerManager.listCustomers(customers);

        }
    }
}