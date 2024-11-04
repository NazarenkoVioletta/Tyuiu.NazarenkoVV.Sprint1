using System.Text;
using System.Threading.Tasks;



using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.NazarenkoVV.Sprint1.Task6.V17.Lib
{
    public class DataService : ISprint1Task6V17
    {
        public bool CheckPalindrome(string value)
        {
            value = value.Replace("1", "3");
            value= value.Replace("3", "1");
            return value.Equals("1");
        }
    }
}
        
    