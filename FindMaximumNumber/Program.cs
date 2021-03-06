using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            FindMaximumNum FindMax = new FindMaximumNum();
            //FindMax.FindMaxInteger(10, 20, 150);
            //FindMax.FindMaxFloat(50.4, 890.2, 159.89);
            //FindMax.FindMaxString("Apple", "Peach", "Banana");
            //FindMaxiumNumGeneric<int> intMax = new FindMaxiumNumGeneric<int>(55, 599, 5100);
            // intMax.getMaximum();

            // FindMaxiumNumGeneric<double> doubleMax = new FindMaxiumNumGeneric<double>(3.3, 55.25, 10.5); 
            // doubleMax.getMaximum();

            // FindMaxiumNumGeneric<string> stringMax = new FindMaxiumNumGeneric<string>("Apple", "Banana", "Peach"); 
            // stringMax.getMaximum();

            int[] intArr = { 10, 20, 30, 99 };
            double[] doubleArr = { 10.15, 80.89, 30.69, 87.58 };
            string[] stringArr = { "Apple", "Peach", "Banana", "Omprakash" };
            new TakeMoreThenThreeParameters<int>(intArr).MaxUsingSort(); 
            new TakeMoreThenThreeParameters<double>(doubleArr).MaxUsingSort(); 
            new TakeMoreThenThreeParameters<string>(stringArr).MaxUsingSort(); 

            Console.ReadLine();

        }
    }
}
