using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    internal class EmployeeManager : IPersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine("Employee Added!" + " Employee Name : " + person.FirstName);
        }

        public void Update()
        {
            Console.WriteLine("Employee Update!");
        }
    }
}
