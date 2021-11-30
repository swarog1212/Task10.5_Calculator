using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CalculatorAndLogger
{
    public class Calculator: ICalculator
    {
        ILogger Logger { get; }
        public Calculator(ILogger logger)
        {
            Logger = logger;
        }
        public void Calculate()
        {
            Console.WriteLine("Введите первое число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Logger.Event("........");
            Thread.Sleep(1000);
            Console.WriteLine($"Сумма: {num1 + num2}");
            Thread.Sleep(1000);
            Logger.Event("Калькулятор отработал успешно!");
        }
    }
}
