using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM.Calc.Core
{
    public class SubOperation : IExtOperation
    {


        public int? ArgCount => 2;

        public string Description => "sub";

        public Guid Uid => new Guid("{E2D9A509-9E38-491F-994A-CB36479E7893}");

        public string Name => "sub";

        public double[] Operands { get; set; }

        public double? Result { get; private set; }

        public double? Execute()
        {
            Result = Operands.Aggregate((a, b) => a - b);
            return Result;
        }
    }
}
