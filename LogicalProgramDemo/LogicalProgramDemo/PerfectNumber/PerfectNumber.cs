using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramDemo.PerfectNumber
{
    public class Perfect
    {
        public void CheckPerfectNumber(int num)
        {
            int sum = 0;
            for (int i = 1; i < num; i++)
            {
                if(num %i ==0)
                {
                    sum = sum +i;
                }
            }
            if(num == sum)
            {
                Console.WriteLine("{0} Perfect number",num);
            }
            else
            {
                Console.WriteLine("{0} Perfect number", num);
            }
        }
        
    }
}
