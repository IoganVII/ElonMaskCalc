using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM.Calc.Core
{
    public class PowOperation : IExtOperation
    {

        public int? ArgCount => 2;

        public string Description => "pow";

        public Guid Uid => new Guid("{7E153ADB-0346-462E-AEE7-C4271CB3E06D}");

        public string Name => "pow";

        public double[] Operands { get; set; }

        public double? Result { get; private set; }

        public double? Execute()
        {
            Result = Operands.Aggregate((lhs, rhs) => Math.Pow(lhs, rhs));
            return Result;
        }
    }
}
