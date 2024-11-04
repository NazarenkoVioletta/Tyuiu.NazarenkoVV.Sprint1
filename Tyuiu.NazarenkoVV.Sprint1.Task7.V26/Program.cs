using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.NazarenkoVV.Sprint1.Task7.V26.Lib;

namespace Tyuiu.NazarenkoVV.Sprint1.Task7.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Исходные данные                                                              *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("((sin x**2 + y) / ( y +1 )) - (( x * y - 12) / (34 - x**2)) ");


            double x, y;

            Console.WriteLine("Введите значение Х:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение У:");
            y = Convert.ToDouble(Console.ReadLine());




            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Результат:                                                                   *");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine(ds.Calculate(x, y));

            Console.ReadKey();

        }
    }
}
        