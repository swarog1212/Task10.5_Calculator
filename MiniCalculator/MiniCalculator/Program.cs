using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniСalculator
{

    class Program
    {
        static void Main(string[] args)
        {
            ICalculate calculate = new Calculator();
            try
            {
                calculate.Calculate();
            }
            catch (FormatException)
            {
                Console.WriteLine("Введены неверные данные!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
