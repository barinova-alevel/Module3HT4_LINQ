using System;
using System.Collections.Generic;

namespace DelegateLinq
{
    public class CalcContainer
    {
        private int counter = 1;

        public event CalculatorMethods.SumDelegate CounterIsTooBig;

        public void Multiply(int multiplier)
        {
            this.counter *= multiplier;
            if (this.counter > 200)
            {
                this.CounterIsTooBig?.Invoke(this.counter / 5, this.counter % 7);
            }
        }
    }
}
