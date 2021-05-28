using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class FindMaximumNum
    {
        public int FindMaxInteger(int num1, int num2, int num3)
        {
            var MaxResult = (num1.CompareTo(num2) > 0 ? num1 : (num2.CompareTo(num3) > 0 ? num2 : num3));
            Console.WriteLine($"Maximum Number is :- {MaxResult}");
            return MaxResult;
        }
    }
}
