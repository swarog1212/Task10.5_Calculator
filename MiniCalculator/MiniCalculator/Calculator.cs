using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniСalculator
{

    public class Calculator : ICalculate
    {
        public void Calculate()
        {
            Console.WriteLine("Введите первое число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Сумма: {num1 + num2}");
        }
    }
}
