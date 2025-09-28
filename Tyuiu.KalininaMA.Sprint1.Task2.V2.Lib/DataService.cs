using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KalininaMA.Sprint1.Task2.V2.Lib
{
    public class DataService : ISprint1Task2V2
    {
        public double ConvertAngleToRad(int value)
        {
            double rad = Math.Round(value*Math.PI / 180, 3);
            return rad;
        }
    }
}

//value * Math.PI / 180;