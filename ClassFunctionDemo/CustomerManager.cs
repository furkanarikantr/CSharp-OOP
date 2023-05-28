using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFunctionDemo
{
    public class CustomerManager
    {
        public void addCustomer(List<Customer> customers ,Customer customer)
        {
            Console.WriteLine("********** Added Customer **********");
            Console.WriteLine("Customer Added. Customer Name : {0} - Customer Surname : {1} - Customer Identify Number : {2}",customer.firstName, customer.lastName, customer.identifyNumber);
            customers.Add(customer);
        }

        public void listCustomers(List<Customer> customers)
        {
            Console.WriteLine("********** List Customer **********");
            int index = 1;
            foreach (var customer in customers)
            {
                Console.WriteLine("{0}. Customer => Customer Name : {1} - Customer Surname : {2} - Customer Identify Number : {3}", index, customer.firstName, customer.lastName, customer.identifyNumber);
                index++;
            }
        }

        public void deleteCustomer(List<Customer> customers, Customer customer)
        {
            Console.WriteLine("********** Deleted Customer **********");
            Console.WriteLine("Customer Deleted. Customer Name : {0} - Customer Surname : {1} - Customer Identify Number : {2}", customer.firstName, customer.lastName, customer.identifyNumber);
            customers.Remove(customer);
        }
    }
}
