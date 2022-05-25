using System;

namespace Module10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите первое слагаемое");

                    int sum1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите второе слагаемое");

                    int sum2 = int.Parse(Console.ReadLine());

                    ISum sum = new MiniCalculator();

                    int result = sum.Sum(sum1, sum2);

                    Console.WriteLine("Сумма равна: " + result);

                    Console.ForegroundColor = ConsoleColor.White;

                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Неверно введено значение слагаемого.\n Введите целое число.");
                }
            }

        }
    }
}
