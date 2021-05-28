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
            FindMax.FindMaxInteger(10, 20, 150);
            FindMax.FindMaxFloat(50.4, 890.2, 159.89);
            FindMax.FindMaxString("Apple", "Peach", "Banana");
            Console.ReadLine();

        }
    }
}
