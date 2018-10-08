using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace custom_list_class
{
    class Customlist1<T>
    {
        public T[] objects = new T[0];
        public int size { get; private set; }

        public Customlist1()
        {
            size = 0;
        }
        public void Add1(T value)
        {
            if (objects.Length <= size)
            {
                T[] tempArray = new T[size + 1];
                for (int i = 0; i < size; i++)
                {
                    tempArray[i] = objects[i];
                }
                tempArray[size] = value;
                size++;
                objects = tempArray;
            }
        }
    }
}
