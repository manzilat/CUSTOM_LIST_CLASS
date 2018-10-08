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
       
        public T[] objects = new T[0];
        public int size { get; private set; }

        public CustomList()
        {
            size = 0;
        }
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
        //public void Add(T value)
        //{
        //    if (objects.Length <= size)
        //    {
        //        T[] tempArray = new T[size + 1];
        //        for (int i = 0; i < size; i++)
        //        {
        //            tempArray[i] = objects[i];
        //        }
        //        tempArray[size] = value;
        //        size++;
        //        objects = tempArray;
        //    }
        //    else
        //    {
        //        try
        //        {
        //            //no try
        //        }
        //        catch (ArgumentOutOfRangeException e)
        //        {
        //            Console.WriteLine(e);
        //        }
        //    }
        //}
        public int Capacity = 4;

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




        }

    }


