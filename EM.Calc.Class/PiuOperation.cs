using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM.Calc.Core
{
    public class PiuOperation : IOperation
    {
        public string Name => "piu";

        public double[] Operands { get; set; }

        public double? Result { get; private set; }

        public double? Execute()
        {
            Result = Operands.Aggregate((a, b) => a * b);
            return Result;
        }
    }
}
