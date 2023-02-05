namespace LineComparisonProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Program");
            //Taking user inputs
            Console.WriteLine("Please enter option given below");
            Console.WriteLine("1:Distance between line UC1\n2:Line equality check\n3:Comparison between line");
            int option = Convert.ToInt32(Console.ReadLine());
            //Uses switch case to call different method
            switch (option)
            {
                case 1:
                    //Taking user input
                    Console.WriteLine("Please enter X1 and Y1 coordinates");
                    var X1 = Convert.ToDouble(Console.ReadLine());
                    var Y1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Please enter X2 and Y2 coordinates");
                    var X2 = Convert.ToDouble(Console.ReadLine());
                    var Y2 = Convert.ToDouble(Console.ReadLine());
                    var finalResult = DistanceBetweenLine.Distance(X1, X2, Y1, Y2);

                    Console.WriteLine("Distance between coordinates {0},{1} and {2},{3} is {4}", X1, Y1, X2, Y2, finalResult);
                    break;
                case 2:
                    {   //Taking user input
                        Console.WriteLine("Please enter X3 and Y3 coordinates");
                        var X3 = Convert.ToDouble(Console.ReadLine());
                        var Y3 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Please enter X4 and Y4 coordinates");
                        var X4 = Convert.ToDouble(Console.ReadLine());
                        var Y4 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Please enter X5 and Y5 coordinates");
                        var X5 = Convert.ToDouble(Console.ReadLine());
                        var Y5 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Please enter X6 and Y6 coordinates");
                        var X6 = Convert.ToDouble(Console.ReadLine());
                        var Y6 = Convert.ToDouble(Console.ReadLine());

                        LineEqualityCheck.Equals(X3, Y3, X4, Y4, X5, Y5, X6, Y6);
                    }
                    break;
                case 3:
                    //Taking user input
                    Console.WriteLine("Please enter X7 and Y7 coordinates");
                    var X7 = Convert.ToDouble(Console.ReadLine());
                    var Y7 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please enter X8 and Y8 coordinates");
                    var X8 = Convert.ToDouble(Console.ReadLine());
                    var Y8 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please enter X9 and Y9 coordinates");
                    var X9 = Convert.ToDouble(Console.ReadLine());
                    var Y9 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please enter X10 and Y10 coordinates");
                    var X10 = Convert.ToDouble(Console.ReadLine());
                    var Y10 = Convert.ToDouble(Console.ReadLine());
                    ComparisonBetweenLine.CompareOfLine(X7, Y7, X8, Y8, X9, Y9, X10, Y10);
                    break;
                default:
                    Console.WriteLine("Please enter right option");
                    break;
            }
        }
    }
}
