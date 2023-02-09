using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class FindMaxGeneric<T> where T:IComparable
    {
        public static void FindMaxNumber(T first, T second, T third)
        {
            if (first.CompareTo(second)>=0 &&first.CompareTo(third)>=0)
            {
                Console.WriteLine("The largest number is:"+first);
               
            }
            else if (second.CompareTo(first)>=0 &&second.CompareTo(third)>=0)
            {
                Console.WriteLine("The largest number is:"+second);
            }
            else
            {
                Console.WriteLine("The largest number is:"+third);
            }
        }
    }
}
