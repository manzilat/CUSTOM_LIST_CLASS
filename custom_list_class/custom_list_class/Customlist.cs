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
        int count ;
        public T[] arr = new T[100];

        public T this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
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
            count = 0;
        }

        public void Add(T value)
        {
            data[count] = value;
            count++;

        }

    }

}