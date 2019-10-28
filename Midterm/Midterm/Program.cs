using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            // The sequence structure, selection structure, and iteration structure are three types of control structures that can be used to order the statements in any program. 
            // The sequence structure executes statements in order unless another contol structure specifies otherwise. 
            // The selection structure includes if (perform an action if a specified condition evaluates to true), if...else (like the if statement except that it specifies an action to perform when condition evaluates to false), and switch (perform actions based on possible values) statements. 
            // Iteration statements enable repeated action while a condition remains true. 
            // The while statement tests the condition before executing a loop and the do...while statement executes the loop before testing the condition. 
            // The for statement provides for a definite number of repetions by adding an initialized variable and increment to the continuation condition, the for each statement iterates through an array, assigns the next value, and executes the specified condition.

            //bool keepLooping = false;
            //while (keepLooping == false)
            //{
            //    Console.WriteLine("keepLooping");
            //}

            int i = 2;
            while (i <= 128)
            {
                Console.WriteLine($"[{i}]");
                i = i + i; 

            }

            for (int j = 49; j >= 1; j--)
            {
                Console.Write(j > 1 ? $"{j}," : $"{j}");
            }
            Console.WriteLine();
            double k = 0;
            while (k <= 21)
            {
                k = k + 1;
                if (k % 2 != 0)
                {
                    Console.Write($"{k} ");
                }
            }
            Console.WriteLine();
            // The output for the following do...while loop is *. 
            // This type of iteration statement executes the loop body (including the output) then evaluates the test condition (i < n) to determine whether or not to keep executing the loop. 
            // Because 10 (the assignment for the variable i) is never less than 8 (the assignment for n), the test condition evaluates to false and never executes again.
            int n = 8;
            int i2 = 10; // initialize
            do
            {
                Console.Write("*");
                i2++;
            }
            while (i2 < n);


            // No output happens for the following while loop because the loop body with the output never executes. 
            // While statements evaluate the test condition before executing the loop body. 
            // Because the test condition never evaluates to true (for the same reason as the do...while loop), the loop body never executes. 

            int n2 = 8;
            int i3 = 10;
            while (i3 < n2)
            {
                Console.Write("*");
                i3++;
            }

            // We can combine multiple Boolean values with logical operators that test more than one condition. 
            // These operarors combine conditions. 
            // The conditional AND (&&) operator) tests whether both conditions are true, the conditional OR (||) operator tests whether either or both conditions are true, the Boolean Logical AND (&) and Boolean Logical OR (|) work like conditional AND Logical OR but always evaluate both conditions, and the Boolen Logical Exclusive OR (^) operator tests whether one condition is true and the other condition is false.   

            bool icyRain = false;
            bool tornadoWarning = false;
            if (icyRain == false && tornadoWarning == false)
            {
                Console.WriteLine("Let's go outside!");
            }
            int[][] jagged = {new int[] { 1, 2, 3, 4, 5, 4, 3, 2, 1},
                            new int[] { 1, 2, 3, 4, 3, 2, 1 },
                            new int[] { 1, 2, 3, 2, 1 },
                            new int[] { 1, 2, 1 },
                            new int[] { 1 }};
            OutputArray(jagged);
            
            void OutputArray(int[][] array )
            {
                int rownum = 5;
                foreach (var row in array)
                {
                        
                        Console.WriteLine();
                    for (int x = 0; x < 5 - rownum; x++)
                    {
                        Console.Write(" ");
                    }
                   
                    foreach (var element in row)
                    {

                        Console.Write($"{element}");
                    }

                    --rownum;
                }
            }
           
        }
    }
 }
