using System;
using System.Collections.Generic;
using System.Linq;
using static DelegateLinq.CalculatorMethods;

namespace DelegateLinq
{
    class Program
    {

        static void Main(string[] args)
        {
            var source = new List<User>
            {
                new User{ Id=1, FirstName="Oksana", LastName = "Barinova", Age=37,BirdthDate = DateTime.UtcNow.AddYears(-10)},
                new User{ Id=1, FirstName="Irina", LastName = "Barinova", Age=37,BirdthDate = DateTime.UtcNow.AddYears(-11)},
                new User{ Id=1, FirstName="Svetlana", LastName = "Barinova", Age=37,BirdthDate = DateTime.UtcNow.AddYears(-12)},
                new User{ Id=1, FirstName="Olga", LastName = "Barinova", Age=37,BirdthDate = DateTime.UtcNow.AddYears(-13)},
                new User{ Id=1, FirstName="Olesja", LastName = "Barinova", Age=37,BirdthDate = DateTime.UtcNow.AddYears(-14)}
            };
            var notBarinova = source.FirstOrDefault(x => x.LastName != "Barinova");
            var isNull = source?.Any();


            CalcContainer calcContainer = new CalcContainer();
            CalculatorMethods calculatorMethods = new CalculatorMethods();

            calcContainer.CounterIsTooBig += calculatorMethods.Sum;
            calcContainer.CounterIsTooBig += calculatorMethods.Sum;

            calcContainer.Multiply(8);
            calcContainer.Multiply(3);
            calcContainer.Multiply(5);
            calcContainer.Multiply(3);
            calcContainer.Multiply(5);
            calcContainer.Multiply(8);
            calcContainer.Multiply(8);
            calcContainer.Multiply(3);
            calcContainer.Multiply(5);
            calcContainer.Multiply(3);
            calcContainer.Multiply(5);
            calcContainer.Multiply(8);

        }
    }
}
