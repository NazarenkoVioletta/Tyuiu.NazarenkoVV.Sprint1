﻿using System;
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
            Console.Title = "Спринт #1| Выполнил:  Назаренко В.В.| ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                              *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: |   Назаренко В. В.                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычисляет, и печатает результат на экране                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
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
        