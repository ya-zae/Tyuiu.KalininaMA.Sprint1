using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KalininaMA.Sprint1.Task6.V12.Lib
{
    public class DataService : ISprint1Task6V12
    {
        public bool CheckLastWordRepetiton(string value)
        {
            if (value.IndexOf(value.ToString()[0]) != -1) { return true; }
            return false;
        }
    }
}