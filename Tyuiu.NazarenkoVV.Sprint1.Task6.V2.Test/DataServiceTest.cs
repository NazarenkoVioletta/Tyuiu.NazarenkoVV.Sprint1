using Tyuiu.NazarenkoVV.Sprint1.Task6.V2.Lib;

namespace Tyuiu.NazarenkoVV.Sprint1.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        public void ValidString()
        {
            string str = "hello Vita";
            DataService ds = new DataService();
            bool res = ds.CheckHello(str);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}