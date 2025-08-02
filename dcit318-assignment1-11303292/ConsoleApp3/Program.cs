using System;

class Program
{
    static string Triangle(double sideOne, double sideTwo, double sideThree)
    {
        if (sideOne == sideTwo && sideTwo == sideThree)
        {
            return "Equilateral triangle";
        }
        else if (sideOne == sideThree || sideTwo == sideThree || sideOne == sideTwo)
        {
            return "Isosceles triangle";
        }
        else
        {
            return "Scalene triangle";
        }

    }
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("***********Triangle Type Identifier***********");

            Console.Write("Enter length of side one: ");
            string sideOne = Console.ReadLine();
            double.TryParse(sideOne, out double firstSide);
            Console.Write("Enter length of side two: ");
            string sideTwo = Console.ReadLine();
            double.TryParse(sideTwo, out double secondSide);
            Console.Write("Enter length of side three: ");
            string sideThree = Console.ReadLine();
            double.TryParse(sideThree, out double thirdSide);


            string triangleType = Triangle(firstSide, secondSide, thirdSide);

            Console.WriteLine("Triangle type: " + triangleType);

            Console.WriteLine("Try another triangle? (yes/no)");
            string tryAgain = Console.ReadLine();

            if (tryAgain != "yes")
                break;
        }
        
    }
}