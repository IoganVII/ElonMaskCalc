using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finans
{
    public class Class1 : EM.Calc.Core.IOperation
    {
        public string Name => "fin";

        public double[] Operands { get; set; }

        public double? Result { get; private set; }

        public double? Execute()
        {
            Result = Operands.Sum();
            return Result;
        }
    }
}
