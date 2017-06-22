using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExercices
{
    public interface IOperation
    {
        bool CanCalculate(String operation);
        decimal Calculate(String operation);
    }
}
