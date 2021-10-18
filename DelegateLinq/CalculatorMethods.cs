
namespace DelegateLinq
{
    using System;
    using System.Collections.Generic;

    public class CalculatorMethods
    {
        private List<int> results = new List<int>();
        private int sumCallsCount = 0;

        public delegate int SumDelegate(int value1, int value2);

        public int Sum(int value1, int value2)
        {
            return this.SafeDelegateCall(this.InternalSum, value1, value2);
        }

        private int InternalSum(int value1, int value2)
        {
            return value1 + value2;
        }

        private int SafeDelegateCall(SumDelegate sum, int value1, int value2)
        {
            this.sumCallsCount++;
            try
            {
                int result = sum.Invoke(value1, value2);
                this.results.Add(result);
                return result;
            }
            catch
            {
                throw new ArgumentException();
            }
        }
    }
}
