using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NazarenkoVV.Sprint1.Task4.V23.Lib;

namespace Tyuiu.NazarenkoVV.Sprint1.Task4.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 60;
            double y = 30;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.166, res);
        }
    }
}