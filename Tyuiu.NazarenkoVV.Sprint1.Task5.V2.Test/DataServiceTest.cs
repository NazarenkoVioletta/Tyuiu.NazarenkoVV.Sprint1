using Tyuiu.NazarenkoVV.Sprint1.Task5.V2.Lib;

namespace Tyuiu.NazarenkoVV.Sprint1.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        public void ValidExpression()
        {
            double x = 1;
            DataService ds = new DataService();
            double res = ds.FahrenheitTo—elsius(x);
            int result = Convert.ToInt32(res);
            int wait = 16;
            Assert.AreEqual(result, wait);
        }
    }
}