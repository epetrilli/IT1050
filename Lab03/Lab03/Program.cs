using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            // The if single-selection statement and the while repetition statement are similar in some ways but different in other ways. They both make decisions based on evaluationg expressions as either true or false with the bool simple type. If single-selection statements only evaluates one condition. The While statement iteratively performs an action until the statement evaluates to false. Then the program picks up with the next statement after the while statement. This means that the if single-selection statement represents a type of control structure called selection structure and the the while repetition statement represents a type of control structure called iteration structure.
            int speedLimit = 35;
            int speed = 42;
            if (speed >= speedLimit)
            {
                Console.WriteLine("SLOW NOW");

            }
            bool isTrue = false;
            if (isTrue == true)
            {
                Console.WriteLine("It is True!");
            }
            else
            {
                Console.WriteLine("It is False!");
            }

            double fahrenheit;
            double celsius;

            Console.Write("Enter temperature in Fahrenheit: ");
            fahrenheit = Convert.ToDouble(Console.ReadLine());
            celsius = (fahrenheit - 32d) * 5d / 9d;
            Console.WriteLine("Temperature in Celsius is {0}", celsius);

            if (fahrenheit < 40)
            {
                Console.WriteLine("It is cold");
            }
            else if (fahrenheit > 90)
            {
                Console.WriteLine("It is hot");
            }
            int a = 1;
            
            while (a <= 10)
            {
                Console.WriteLine($"{a++}");
            }
            int b = 65;

            while (b >= 25)
            {
                b -= 5;
                Console.WriteLine($"{b}");
            }
            int c = 8;

            while (c <= 18)
            {
                c += 2;
                Console.WriteLine($"{c}");
            }
        }
        
    }
}
