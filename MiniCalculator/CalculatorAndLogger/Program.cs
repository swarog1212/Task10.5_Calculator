using System;

namespace CalculatorAndLogger
{
    class Program
    {
        static ILogger Logger { get; set; }
        static void Main(string[] args)
        {
            Logger = new Logger();
            ICalculator calculator = new Calculator(Logger);
            try
            {
                calculator.Calculate();
            }
            catch (FormatException)
            {
                Logger.Error("Введены символы вместо чисел!");
            }
            catch(Exception ex)
            {
                Logger.Error(ex.Message);
            }
        }
    }
}
