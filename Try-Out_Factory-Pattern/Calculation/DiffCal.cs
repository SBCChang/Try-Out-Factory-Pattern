namespace Try_Out_Factory_Pattern.Calculation
{
    public class DiffCal : ICal
    {

        public DiffCal()
        {

        }

        public bool TryGetResult(out CalculationResult data)
        {
            var result = false;
            data = default(CalculationResult);

            return result;
        }

    }
}
