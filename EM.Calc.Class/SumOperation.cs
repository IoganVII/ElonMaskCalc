using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM.Calc.Core
{
    public class SumOperation : IExtOperation
    {

        public int? ArgCount => 2;

        public string Description => "sum";

        public Guid Uid => new Guid("{1E96A08C-6C8D-42DC-AF12-EC471A0FAEAB}");

        public string Name => "sum";

        public double[] Operands { get; set; }

        public double? Result { get; private set; }

        public double? Execute()
        {
            Result = Operands.Sum();
            return Result;
        }
    }
}
