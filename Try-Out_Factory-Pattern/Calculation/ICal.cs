using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Out_Factory_Pattern.Calculation
{
    public interface ICal
    {

        bool TryGetResult(out CalculationResult result);

    }
}
