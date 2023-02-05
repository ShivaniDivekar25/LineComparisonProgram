using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProgram
{
    //Created class LineEqualityCheck
    public class LineEqualityCheck
    {
        //Created method Equals
        public static void Equals(double X3, double X4, double Y3, double Y4, double X5, double X6, double Y5, double Y6)
        {
            double temp1 = Math.Pow((X4 - X3), 2);
            double temp2 = Math.Pow((Y4 - Y3), 2);
            double Length1 = Math.Sqrt(temp1 + temp2);

            double temp3 = Math.Pow((X6 - X5), 2);
            double temp4 = Math.Pow((Y6 - Y5), 2);
            double Length2 = Math.Sqrt(temp3 + temp4);
            Console.WriteLine(Length1.Equals(Length2));
        }
    }
}
