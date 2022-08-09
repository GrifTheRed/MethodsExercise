using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            
            


            //For division, create two integer variables called a and b.

            var a = 17;
            var b = 4;
            var quotient = a / b;
            var remainder = a % b;

            Console.WriteLine($"addition {a + b}");
            Console.WriteLine($"subtraction {a - b}");
            Console.WriteLine($"multiplication {a * b}");
            Console.WriteLine($"division {a / b}");
            Console.WriteLine($"modulus {a % b}");
            
            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");
            Console.WriteLine("Enter radius of circle");
            var radius = double.Parse(Console.ReadLine());

            var circle = AreaOfCircle(radius);

            Console.WriteLine($"The Area of your circle is: {circle}");

            

        }
        // define a method - which performs some functionality, that can be used
        // over and over agin
        public static double AreaOfCircle(double radius)
        {

            var area = Math.PI * Math.Pow(radius, 2);

            return area;

        }

    }
}

