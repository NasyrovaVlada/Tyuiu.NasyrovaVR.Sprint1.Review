using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.NasyrovaVR.Sprint1.TaskReview.V15.Lib
{
    public class DataService : ISprint1Task7V15
    {
        public double Calculate(double x)
        {
            double res = Math.Abs(Math.Pow(x, 2) - Math.Pow(x, 3)) - ((Math.Cos(Math.Pow(x, 3)) + 7 * Math.Pow(x, 2)) / (Math.Pow(x, 3) - 15 * x));
            return Math.Round(res, 3);
        }
    }
}
