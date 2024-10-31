using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.NazarenkoVV.Sprint1.Task4.V23.Lib;

namespace Tyuiu.NazarenkoVV.Sprint1.Task4.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Исходные данные                                                              *");
            Console.WriteLine("********************************************************************************");

            int x, y;


            Console.WriteLine("Введите значение Х:");

            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение Y:");

            y = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Результат:                                                                   *");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine(" Math.Sqrt(Math.Abs(x + y) / Math.Abs(3 - x) = " + ds.Calculate(x, y));

            Console.ReadKey();

        }
    }
}