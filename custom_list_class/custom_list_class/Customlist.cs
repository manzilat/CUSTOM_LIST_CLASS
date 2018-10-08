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

        public CustomList()
        {
            data = new T[8];
            count = 0;
        }

        static public int Capacity=8;

        public void Add(T value)
        {
            if (count == Capacity)
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
            public bool Remove(T input)
            {
                bool removed = false;
                T[] result = new T[Capacity];

                for (int i = 0; i < count; i++)
                {
                    if (data[i].Equals(input) && !removed)
                    {
                        removed = true;
                        count--;
                        if (i < count)
                        {
                            result[i] = data[i + 1];
                        }
                    }
                    else if (removed)
                    {
                        result[i] = data[i + 1];
                    }
                    else
                    {
                        result[i] = data[i];
                    }
                }
                data = result;
                return removed;
            }

        }

    }

