using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM.Calc.Core
{
    public class NewOperation : IExtOperation
    {
        public int? ArgCount => 2;

        public string Description => "New";

        public Guid Uid => new Guid("{EEA17017-4DCB-4D69-80F8-3E595E3B80B7}");


        public string Name => "new";

        public double[] Operands { get; set; }

        public double? Result { get; private set; }

        public double? Execute()
        {
            Result = double.PositiveInfinity;
            return Result;
        }
    }
}
