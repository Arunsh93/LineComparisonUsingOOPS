using System;

namespace LineComparisonUsingOOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Program Using OOPS");

            //UC1_LengthCalculation obj1 = new UC1_LengthCalculation();
            //obj1.getCartician();

            //UC2_FindLineEqulity obj2 = new UC2_FindLineEqulity();
            //obj2.GetLineEqulity();

            UC3_CheckTwoLineEqualGreaterLesser obj3 = new UC3_CheckTwoLineEqualGreaterLesser();
            obj3.GetLineEqulityGreaterLesser();
        }
    }
}
