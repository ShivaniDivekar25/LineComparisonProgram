using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProgram
{
    //Created class ComparisonBetweenLine
    public class ComparisonBetweenLine
    {
        //Created method CompareOfLine
        public static void CompareOfLine(double X7, double X8, double Y7, double Y8, double X9, double X10, double Y9, double Y10)
        {
            double temp1 = Math.Pow((X8 - X7), 2);
            double temp2 = Math.Pow((Y8 - Y7), 2);
            double LengthOfFirstLine = Math.Sqrt(temp1 + temp2);

            double temp3 = Math.Pow((X10 - X9), 2);
            double temp4 = Math.Pow((Y10 - Y9), 2);
            double LengthOfSecondLine = Math.Sqrt(temp3 + temp4);

            double Result = LengthOfFirstLine.CompareTo(LengthOfSecondLine);
            if (Result == 0)
            {
                Console.WriteLine("Lenght of two lines are equal");
            }
            else if (Result > 0)
            {
                Console.WriteLine("Lenght of line1 is greater than length of line2");
            }
            else
            {
                Console.WriteLine("Length of line1 is smaller than length of line2");
            }
        }
    }
}
