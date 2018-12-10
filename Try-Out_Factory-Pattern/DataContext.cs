using Try_Out_Factory_Pattern.Calculation;

namespace Try_Out_Factory_Pattern
{
    internal class DataContext
    {

        internal static void Start()
        {
            var cals = CalFactory.GetCals();

            foreach (var cal in cals)
            {
                CalculationResult result;
                if (cal.TryGetResult(out result))
                {

                }
            }
        }

    }
}
