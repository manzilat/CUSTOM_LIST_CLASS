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
        T[] array1;

        public IEnumerator<T> GetEnuerator()
        {
            for (int i = 0; i < count; i++)

                yield return array1[i];
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

        public CustomList()
        {
            data = new T[1000];
            count = 0;
        }

        static public int Capacity=1000;

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
        public static CustomList<T> operator +(CustomList<T> one, CustomList<T> two)
        {
            CustomList<T> result = new CustomList<T>();
            for (int i = 0; i < one.Count; i++)
            {
                result.Add(one[i]);
            }
            for (int i = 0; i < two.Count; i++)
            {
                result.Add(two[i]);
            }
            return result;
        }
        
        public static CustomList<T> operator -(CustomList<T> one, CustomList<T> two)
        {
            CustomList<T> result = new CustomList<T>();
            for (int i = 0; i < one.Count; i++)
            {
                result.Add(one[i]);
            }
            for (int i = 0; i < two.Count; i++)
            {
                result.Remove(two[i]);
            }
            return result;
        }
        public override string ToString()
        {
            string adjustToString = "";
            for (int i = 0; i < count; i++)
            {
                adjustToString = adjustToString + array1[i] + "";
            }
            return adjustToString;
        }
        public CustomList<T> Zip(CustomList<T> objectA)
        {
            CustomList<T> newList = new CustomList<T>();
            if (objectA.Count > this.Count || objectA.count == this.Count)
            {
                for (int i = 0; i < this.Count; i++)
                {
                    newList.Add(this[i]);
                    newList.Add(objectA[i]);
                }
            }
            else
            {
                for (int i = 0; i < objectA.Count; i++)
                {
                    newList.Add(objectA[i]);
                    newList.Add(this[i]);
                }
            }
            return newList;
        }
        public void Sort()
        {
            T[] result = new T[count];
            result = array1;
            int i, j;
            int N = count;
            for (j = N - 1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    if (Comparer<T>.Default.Compare(result[i], result[i + 1]) > 0)
                    {
                        Swap(result, i, i + 1);
                    }
                }
            }
            array1 = result;
        }

        public void Swap(T[] list, int left, int right)
        {
            T temporary;
            temporary = list[left];
            list[left] = list[right];
            list[right] = temporary;
        }
    }

    
}

