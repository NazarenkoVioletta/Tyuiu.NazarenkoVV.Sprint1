using Tyuiu.NazarenkoVV.Sprint1.Task6.V17.Lib;

namespace Tyuiu.NazarenkoVV.Sprint1.Task6.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        public void ValidString()
        {
            string strTest = "1 * 2 * 3";
            DataService ds = new DataService();
            string res = ds.CheckPalindrome(strTest);
            string wait = "3 * 2 * 1";
            Assert.AreEqual(res, wait);
        }
    }
}