using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class GnericsArray
    {
        /// <summary>
        /// Generic Method
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="args"></param>
        public static void ToPrint<T>(T[] args)
        {
            foreach (T data in args)
            {
                Console.WriteLine(data+" ");
            }
        }
    }
    public class GenericClass<T>
    {
        T[] array; 
        public GenericClass(T[] array)
        {
            this.array=array;
        }
        public void ToPrint()
        {
            foreach (T data in array)
            {
                Console.WriteLine(data+" ");
            }
        }
    }
}
