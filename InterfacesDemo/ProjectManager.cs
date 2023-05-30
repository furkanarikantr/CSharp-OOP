using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    internal class ProjectManager
    {
        public void Add(IPersonManager personManager, Person person) 
        {
            personManager.Add(person);
        }
    }
}
