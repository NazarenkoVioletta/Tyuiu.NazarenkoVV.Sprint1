﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.NazarenkoVV.Sprint1.Task4.V23.Lib
{
    public class DataService : ISprint1Task4V23
    {
        public double Calculate(double x, double y)
        {
            var res = Math.Sqrt(Math.Abs(x + y)) / Math.Abs(3 - x);
            Math.Round(0.16643566632465154, 3);
            return res;
        }
    }
}
