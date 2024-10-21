using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NazarenkoVV.Sprint1.Task3.V9.Lib;

namespace Tyuiu.NazarenkoVV.Sprint1.Task3.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int minutes = 150;
            var res = ds.ConvertMinutesToHours(minutes);
            Assert.AreEqual(2.333, res);
        }
    }
}
