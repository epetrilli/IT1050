using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class Program
    {
        static void Main(string[] args)
        {
            //The four basic elements of the counter-controlled repetition are the control variable, the initial value for the control variable, the increment that the control variable changes for each iteration of the loop, and the loop continuation condition to evaluate whether the loop should keep executing.
            //The while and for repetition statements can be compared and contrasted. Both statements are control statements that can be used for either counter-controlled iteration (using a counter variable to increment values a known number of times until loop continuation condition no longer remains true) or sentinel-controlled iteration (declaring and initializing variables then prompting the user an indefinite number of times for some input until user enters a value that ends the loop). However, for statements are usually used for counter-controlled iteration and while statements for sentinel controlled iteration because the for statement header optionally includes the initialization, continuation condition, and increment for the loop that can predetermine when to stop executing the loop. The main difference between the two statements arises from whether the programmer knows the number of repitions ahead of time or not.
            //It would be more appropriate to use a do-while statement than a while statement when you want the loop-continuation test evaluated after executing the loop's body. This guarantees that the loop body executes at least once. For example, you could want the user to enter an integer value at least one time.  Depending on the value that the user enters, the condition in the body of the loop can become immediately false and stop the loop from executing again. Using a while statement would mean that the loop never executed in the first place, including the input you wanted from the user.
            for (int i = 1; i <= 100;++i)
            {
                if ((i % 2) == 0)
                {
                    Console.WriteLine($"{i} is even");
                }
                else
                {
                    Console.WriteLine($"{i} is odd");
                }
            }
            Console.Write("Please enter a temperature");
            int temp = int.Parse(Console.ReadLine());
            if (temp < 10)
            {
                Console.WriteLine("Polar Bear");

            }
            if (temp < 20)
            {
                Console.WriteLine("Penguin");

            }
            else if (temp < 40)
            {
                Console.WriteLine("Moose");
            }
            else if (temp < 50)
            { 
                Console.WriteLine("Reindeer");
            }
            else if (temp < 60)
            {
                Console.WriteLine("Deer");
            }
            else if (temp < 70)
            {
                Console.WriteLine("Turtle");
            }
            else if (temp < 80)
            {
                Console.WriteLine("Lion");
            }
            else if (temp < 90)
            {
                Console.WriteLine("Fish");
            }
            else
            {
                Console.WriteLine("Bug");
            }
            //The following code was rewritten to use the variable i2 ("i" was already used in this solution), to use $ for string interpolation to insert the variable values in the formatted string, and to use the variable with a postfix increment ++ to correctly display the values from 10 - 20.
            int i2 = 10;
            while (i2 < 21)
            {
                Console.WriteLine($"{i2++} ");
            }
            //The following code was rewritten to display the numbers from 0-100 separated by a line with asterisks on it by combining the Console.WriteLine statements into a single statement with the n/ escape sequence that separates the lines.  Using two statements before caused the asterisks to only display after the for loop ended. The new code also uses $ for string interpolation to insert the variable i3 (i and i2 were already used in this solution) values in the formatted string.
            for (int i3 = 0; i3 < 101; i3++)
                Console.WriteLine($"{i3}\n********");  
            
        }
     }
}
