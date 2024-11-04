using Tyuiu.NazarenkoVV.Sprint1.Task7.V26.Lib;

namespace Tyuiu.NazarenkoVV.Sprint1.Task7.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 30;
            double y = 5;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0,848,res);
        }
    }
}


