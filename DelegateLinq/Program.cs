
namespace DelegateLinq
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var source = new List<User>
            {
                new User { Id = 1, FirstName = "Oksana", LastName = "Barinova", Age = 37, BirdthDate = DateTime.UtcNow.AddYears(-10) },
                new User { Id = 2, FirstName = "Irina", LastName = "Barrrova", Age = 22, BirdthDate = DateTime.UtcNow.AddYears(-11) },
                new User { Id = 6, FirstName = "Svetlana", LastName = "", Age = 37, BirdthDate = DateTime.UtcNow.AddYears(-12) },
                new User { Id = 6, FirstName = "Olga", LastName = "Barinova", Age = 15, BirdthDate = DateTime.UtcNow.AddYears(-13) },
                new User { Id = 7, FirstName = "Olesja", LastName = "Bannnova", Age = 37, BirdthDate = DateTime.UtcNow.AddYears(-14) },
            };

            var barinova = source.FirstOrDefault(x
                => x.LastName == "Barinova");
            var notBarinova = source.FirstOrDefault(x => x.LastName != "Barinova");
            var isNull = source?.Any();
            var useConditionId =
                from item in source
                where item.Id == 6
                select item;

            var useConditionName =
                from item in source
                where item.FirstName != "Oksana"
                select item;

            var queryFirstNames =
                from item in source
                group item by item.FirstName into newSource
                orderby newSource.Key
                select newSource;
            var itemAt =
                source.ElementAtOrDefault(2);


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
