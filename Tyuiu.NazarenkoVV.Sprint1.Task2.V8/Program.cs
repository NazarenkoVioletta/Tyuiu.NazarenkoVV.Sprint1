using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.NazarenkoVV.Sprint1.Task2.V8.Lib;

namespace Tyuiu.NazarenkoVV.Sprint1.Task2.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнила: Назаренко В. В.| ИСПб-24-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #1                                                                    *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                             *");
            Console.WriteLine("* Задание #2                                                                   *");
            Console.WriteLine("* Вариант #8                                                                   *");
            Console.WriteLine("* Выполнила: Назаренко В. В. | ИСПб-24-1                                       *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                =                    *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,      *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.                  *");
            Console.WriteLine("*                                                                              *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");
            int a;
            int b;
            Console.WriteLine("*Введите значение A: ***********************************************************");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*Введите значение B: ***********************************************************");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Периметр прямоугольника a, b = " + ds.CalculatePerimetr(a, b));
            Console.ReadLine();
        }
    }
}
    
