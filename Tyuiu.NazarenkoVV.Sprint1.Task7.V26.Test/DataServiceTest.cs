using Tyuiu.NazarenkoVV.Sprint1.Task7.V26.Lib;

namespace Tyuiu.NazarenkoVV.Sprint1.Task7.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 4;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1,071,res);
        }
    }
}


