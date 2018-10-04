using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace custom_list_class
{
    public class CustomList<T>
    {
        T[] data;
        int count;

        public int this[int data ]  // Indexer declaration  
        {
            get
            {
                return data;
            }
        }
        public int Count
        {
            get
            {
                return count;
            }
        }

        public CustomList()
        {
            data = new T[4];
        }

        public void Add(T value)
        {


        }

    }

}