using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM.Calc.Core
{
    public class Calc
    {
        public int Sum(int[] args)
        {
            var sum = 0;
            for (int i = 0; i < args.Length; i++)
                sum = sum + args[i];
            return sum;
        }
    }
}
