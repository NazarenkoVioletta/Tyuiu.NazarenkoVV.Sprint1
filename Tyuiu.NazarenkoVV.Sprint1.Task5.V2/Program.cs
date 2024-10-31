using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.NazarenkoVV.Sprint1.Task5.V2.Lib;

namespace Tyuiu.NazarenkoVV.Sprint1.Task5.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Исходные данные                                                              *");
            Console.WriteLine("********************************************************************************");

            int x;


            Console.WriteLine("Введите значение Х:");

            x = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Результат:                                                                   *");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine("Convert.ToInt32(( x - 32) * 5 /9) + FahrenheitToСelsius( double x) ");

            Console.ReadKey();

        }
    }
}
        