using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLinq
{
    public class CalculatorMethods
    {
        public delegate int SumDelegate(int value1, int value2);

        private int SumCallsCount = 0;
        private List<int> results = new List<int>();

        public int Sum(int value1, int value2)
        {
            return SafeDelegateCall(InternalSum, value1, value2);
        }

        private int InternalSum(int value1, int value2)
        {
            return value1 + value2;
        }

        private int SafeDelegateCall(SumDelegate sum, int value1, int value2)
        {
            SumCallsCount++;
            try
            {
                int result = sum.Invoke(value1, value2);
                results.Add(result);
                return result;
            }
            catch
            {
                throw new ArgumentException();
            }
        }
    }
}
