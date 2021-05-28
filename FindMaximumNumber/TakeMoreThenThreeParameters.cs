using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class TakeMoreThenThreeParameters<T> where T : IComparable 
    {
        T[] array;
        public TakeMoreThenThreeParameters(T[] array) 
        {
            this.array = array;
        }
        public T MaxUsingSort() 
        {
            Array.Sort(array); 
            var maximum = this.array[this.array.Length - 1]; 
            printMax(maximum); 
            return maximum;
        }
        static void printMax(T maximum) 
        {
            Console.WriteLine($"Maximum Number is:- {maximum}");
        }

    }
}
