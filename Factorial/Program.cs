using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_1_Exercise_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Запуск метода асинхронно.");
            Console.WriteLine("Введите значение для которого необходимо рассчитать факториал.");
            int numForFactorial = Convert.ToInt32(Console.ReadLine());

            int fact = CalcFactorialAsync(numForFactorial).Result;

            Console.WriteLine(fact);
            Console.ReadKey();
        }

        static async Task<int> CalcFactorialAsync(int num)
        {
            Console.WriteLine("Начинаем выполнять метод с async.");
            int result = await Task.Run(() => CalcFactorial(num));
            Console.WriteLine("Вычисления с await закончил.");
            return result;
        }

        static int CalcFactorial(int num)
        {
            int factorial = 1;

            for (int i = 2; i < num + 1; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}