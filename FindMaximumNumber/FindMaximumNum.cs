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
        public double FindMaxFloat(double num1, double num2, double num3)
        {
            double MaxResult = (num1.CompareTo(num2) > 0 ? num1 : (num2.CompareTo(num3) > 0 ? num2 : num3));
            Console.WriteLine($"Maximum Float Number is :- {MaxResult}");
            return MaxResult;
        }
        public string FindMaxString(string str1, string str2, string str3) 
        {
            string MaxResult = (str1.CompareTo(str2) > 0 ? str1 : (str2.CompareTo(str3) > 0 ? str2 : str3));
            Console.WriteLine($"Maximum String Number is :- {MaxResult}");
            return MaxResult;
        }
    }
}
