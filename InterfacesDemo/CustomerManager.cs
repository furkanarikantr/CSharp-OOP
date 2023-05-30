using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    internal class CustomerManager : IPersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine("Customer Added!" + " Customer Name : " + person.FirstName);
        }

        public void Update()
        {
            Console.WriteLine("Customer Update!");
        }
    }
}
