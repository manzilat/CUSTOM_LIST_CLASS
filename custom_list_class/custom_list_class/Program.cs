using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace custom_list_class
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> testList = new CustomList<int>();
           
            testList.Add(1);
            testList.Add(2);

            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.Add(6);
            testList.Add(7);
            testList.Add(8);
            testList.Add(11);
            testList.Add(41);
            testList.Add(51);
            testList.Add(61);
            testList.Add(71);
            testList.Add(81);



        }
    }
}
