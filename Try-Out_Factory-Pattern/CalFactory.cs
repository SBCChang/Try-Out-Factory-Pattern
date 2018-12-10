using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Try_Out_Factory_Pattern.Calculation;

namespace Try_Out_Factory_Pattern
{
    public class CalFactory
    {

        public static IEnumerable<ICal> GetCals()
        {
            var result = new List<ICal>();

            result.Add(new DiffCal());

            return result;
        }

    }
}
