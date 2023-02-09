using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class PrintArray
    {
        public void ToPrint(int[] args)
        {
            foreach (var data in args)
            {
                Console.WriteLine(data+" ");
            }
        }
        public void ToPrint(double[] args)
        {
            foreach (var data in args)
            {
                Console.WriteLine(data+" ");
            }
        }
        public void ToPrint(char[] args)
        {
            foreach (var data in args)
            {
                Console.WriteLine(data+" ");
            }
        }
    }
}
