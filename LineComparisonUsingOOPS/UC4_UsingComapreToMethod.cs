using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparisonUsingOOPS
{
    class UC4_UsingComapreToMethod
    {
        public void UsingCompareToMethod()
        {
            double x1, x2, y1, y2;
            double a1, a2, b1, b2;
            double length1, length2;

            Console.WriteLine("Enter the points of line1");
            Console.WriteLine("Enter points (x1, y1): ");
            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Points (x2, y2): ");
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Points of line2");
            Console.WriteLine("Enter Points (a1, b1): ");
            a1 = double.Parse(Console.ReadLine());
            b1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Points (a2, b2): ");
            a2 = double.Parse(Console.ReadLine());
            b2 = double.Parse(Console.ReadLine());

            length1 = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            length2 = Math.Sqrt(((a2 - a1) * (a2 - a1) + (b2 - b1) * (b2 - b1)));

            Console.WriteLine("The Length between two points are: " + length1 + length2);

            //Using CompareTo Method 

            if (length1.Equals(length2))
            {
                Console.WriteLine("The two lenths are Equal");
            }
            else if (length1.CompareTo(length2) < 0)
            {
                Console.WriteLine("The Length of Line1 is Lesser than Line2");
            }
            else if (length1.CompareTo(length2) > 0)
            {
                Console.WriteLine("The Length of Line1 is Greater than Line2");
            }
        }
    }
}
