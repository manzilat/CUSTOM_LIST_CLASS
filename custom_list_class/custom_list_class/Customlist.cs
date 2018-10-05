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
        
       

        public T this[int i]
        {
            get { return data[i]; }
            set { data[i] = value; }
        }
        public int Count
        {
            get
            {
                return count;
            }
        }
        public int Capacity = 4;
        public CustomList()
        {
            data = new T[Capacity];
            count = 0;
        }

        
         
        public void Add(T value)
        {
            if(count == Capacity)
            {
                T[] temp = new T[Capacity * 2];
                for (int i = 0; i < count; i++)
                {
                    temp[i] = data[i];
                }
                data[count] = value;
                data = temp;
            }
            else
            {
                data[count] = value;
            }
            

            count++;

            
        }

    }

}
