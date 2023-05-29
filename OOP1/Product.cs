using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Product  //Entity (Varlık)
    {
        //primary key
        public int Id { get; set; }

        //foreign key
        public int CategoryId { get; set; }

        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitInStock { get; set; }

        //crud -> create - read - update - delete
    }
}
