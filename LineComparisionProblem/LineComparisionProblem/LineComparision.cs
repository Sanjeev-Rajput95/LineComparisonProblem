using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionProblem
{
    internal class LineComparision
    {
        public void lenthOfLine ()
        {
            Console.WriteLine("------- Enter the points of first line ------- ");
            Console.Write(" Enter the value of x1 : ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Enter the value of  x2 : ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Enter the value of  y1 : ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Enter the value of y2 : ");
            int y2 = Convert.ToInt32(Console.ReadLine());

            double length_Of_1stLine = ((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            Console.WriteLine("The length of first line is : " + length_Of_1stLine);
            // Also use this predined Math.Sqrt method for solving equation
            // double length_Of_A_Line = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine("------- Enter the points of second line ------- ");
            Console.Write(" Enter the value of p1 : ");
            int p1 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Enter the value of p2 : ");
            int p2 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Enter the value of q1 : ");
            int q1 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Enter the value of q2 : ");
            int q2 = Convert.ToInt32(Console.ReadLine());

            double length_Of_2ndLine = Math.Sqrt(Math.Pow(p2 - p1,2) + Math.Pow(q2 - q1,2));
            Console.WriteLine("the length of second line is : " + length_Of_2ndLine);

            if (length_Of_2ndLine.CompareTo(length_Of_1stLine) < 0 )
            {
                Console.WriteLine("\n 1st line is greater");
            }
            else
            if (length_Of_1stLine.CompareTo(length_Of_2ndLine) > 0 )
            {
                Console.WriteLine("\n 2nd line is greater");
            }
            else
            {
                Console.WriteLine("\n Both line are equal ");

            }
        }
    }
}
