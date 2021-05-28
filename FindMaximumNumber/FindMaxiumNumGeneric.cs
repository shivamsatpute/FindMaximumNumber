using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class FindMaxiumNumGeneric<R> where R : IComparable 
    {
        public R Take_input1, Take_input2, Take_input3; 
        public FindMaxiumNumGeneric(R Take_input1, R Take_input2, R Take_input3)
        {
            this.Take_input1 = Take_input1;
            this.Take_input2 = Take_input2;
            this.Take_input3 = Take_input3;
        }
        public R getMaximum()
        {
            var MaxResult = this.Take_input1.CompareTo(Take_input2) > 0 ? Take_input1 : (this.Take_input2.CompareTo(Take_input3) > 0 ? Take_input2 : Take_input3); 
            Console.WriteLine("Maximum Number is  :" + MaxResult);
            return MaxResult;
        }
    }
}
