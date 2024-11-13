using System.Text;
using System.Threading.Tasks;



using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.NazarenkoVV.Sprint1.Task6.V2.Lib
{
    public class DataService : ISprint1Task6V2
    {
        public bool CheckHello(string value)
        {
            string res = "Hello";
            string[] world = value.Split(',');
            foreach (string line in world)
            {
                res += line;
            }
            return true;
        }
    }
}


