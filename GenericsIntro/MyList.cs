using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    //Generics
    internal class MyList<T> //<T> => Type'dan gelir.
    {
        T[] items;

        //constructor
        public MyList()
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];

            for (int index = 0; index < tempArray.Length; index++)
            {
                items[index] = tempArray[index];
            }

            items[items.Length - 1] = item;
        }

        public int Length
        {
            get { return items.Length; }
        }

        public T[] Items
        {
            get { return items; }
        }
    }
}
