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
        private T[] arr = new T[4];
       

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
        public int Capacity = 4;
        //private T[] IncreaseSize()
        //{
        //    T[] temp = new T[ data * 2];
        //    //if the array is not large enough, its size is double
        //    //copy all elements into new array

        //    T[] data = new T[4];
        //    return temp;
        //}
        public void Add(T value)
        {
            T[] temp = new T[Capacity * 2];
            data[count] = value;
            count++;

            //data = temp;
        }

    }

}