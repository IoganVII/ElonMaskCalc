using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM.Calc.Core
{
    public class PiuOperation : IExtOperation
    {

        public int? ArgCount => 2;

        public string Description => "piu";

        public Guid Uid => new Guid("{9306B3A6-6C46-4A0A-A5AC-B5062383AD65}");

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
