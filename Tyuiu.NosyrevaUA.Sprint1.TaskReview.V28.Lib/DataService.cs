using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.NosyrevaUA.Sprint1.TaskReview.V28.Lib
{
    public class DataService : ISprint1Task7V28
    {
        public double Calculate(double x, double y)
        {
            if (x == 0)
            { return (-1); }

            else
            { return (Math.Pow(Math.Cos(Math.Sin(1 / x)), 2) + Math.Pow(y, x)); }
        }
    }
}
