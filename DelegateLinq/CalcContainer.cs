using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLinq
{
    public class CalcContainer
    {
        public event CalculatorMethods.SumDelegate CounterIsTooBig;

        int counter = 1;
        public void Multiply(int multiplier)
        {
            counter *= multiplier;
            if (counter > 200)
            {
                CounterIsTooBig?.Invoke(counter / 5, counter % 7);
            }
        }

    }
}
