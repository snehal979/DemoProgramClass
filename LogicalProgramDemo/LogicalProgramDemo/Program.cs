using LogicalProgramDemo.PerfectNumber;
using System.Runtime.InteropServices;

namespace LogicalProgramDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
          //    Perfect perfect = new Perfect();
          //    perfect.CheckPerfectNumber(28);

            int num = 3453;
            int remainder = 0, revese = 0;
            while(num !=0)
            {
                remainder = num%10;
                revese=(revese*10)+remainder;
                num= num /10;
            }
            
            Console.WriteLine(revese);
        }
    }
}