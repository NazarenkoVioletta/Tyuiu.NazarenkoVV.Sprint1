using Tyuiu.NazarenkoVV.Sprint1.Task6.V2.Lib;

namespace Tyuiu.NazarenkoVV.Sprint1.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        public void ValidString()
        {
            string str = "�� ���� ����� ����� ������ ���� Hello";
            DataService ds = new DataService();
            string res = ds.CheckHello(str);
            string wait = "true";
            Assert.AreEqual(res, wait);
        }
    }
}