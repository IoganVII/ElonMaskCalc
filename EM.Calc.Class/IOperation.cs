using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM.Calc.Core
{
    public interface IOperation
    {
        /// <summary>
        /// Название
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Операнды
        /// </summary>
        double[] Operands { get; set; }

        /// <summary>
        /// Выполнить операцию
        /// </summary>
        /// <returns>Результат</returns>
        double? Execute();

        /// <summary>
        /// Результат
        /// </summary>
        double? Result { get; }
    }
}
