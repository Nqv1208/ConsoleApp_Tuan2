using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp_Tuan2
{
    public class MyGenericClass<T>
    {
        public void display(T[] inputArray)
        {
            foreach (T element in inputArray)
                Console.WriteLine(element);
        }

        public T[] sort(T[] inputArray)
        {
            Array.Sort(inputArray);
            return inputArray;
        }
    }
}