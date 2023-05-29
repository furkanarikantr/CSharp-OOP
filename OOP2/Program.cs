namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SOLID
            //Gerçek Müşter/IndividualCustomer - Tüzel Müşteri/CoorporateCustomer

            //Furkan ARIKAN
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "12345";
            customer1.FirstName = "Furkan";
            customer1.LastName = "Arıkan";
            customer1.IdentityNumber = "17822017840";

            //FVS Teknoloji
            CoorporateCustomer customer2 = new CoorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "54321";
            customer2.CompanyName = "Fvs Teknoloji";
            customer2.CompanyTaxNumber = "1234567890";

            Customer customer3 = new IndividualCustomer();
            

            Customer customer4 = new CoorporateCustomer();
            
            
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);
        }
    }
}