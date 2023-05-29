using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //Tüzel
    internal class CoorporateCustomer : Customer    //Inheritance - Miras
    {
        public string CompanyName { get; set; }
        public string CompanyTaxNumber { get; set; }
    }
}
