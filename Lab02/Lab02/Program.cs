using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Multiplication
{
    public static void Main(string[] args)
    {
        int number1;
        int number2;
        int product;

        Console.Write("Enter first integer: ");
        number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second integer: ");
        number2 = Convert.ToInt32(Console.ReadLine());

        product = number1 * number2;
        Console.WriteLine("Product is {0}", product);

        Console.WriteLine("{0}\n{1}", "Hello World!", "From Ernest Petrilli");

        Console.WriteLine("{0}\t{1}", "Hello World!", "From Ernest Petrilli");
    }
}
 //a. Our C# Console Application executes when the program reaches the Main method.  That means line 9 for this program.  The body of the Main method starts with the left brace on line 10 and ends with the right brace on line 27.
 //b. The difference between an integer type variable and a double / floating-point variable is that integers can only represent whole numbers.  Floating-point numbers, which include float and double data types, can represent real numbers with decimal points. Double variables can store numbers with even more precision. 
 //c. An example of a method from Chapter 4 is the SetName method.  This method is used in Chapter 4 to set the account name for the object. The SetName method includes a method header with void return type,  the string parameter accountName, and the method body that stores the parameter value in the MyAccount object.
 //d. get, set 
 //e. The difference between a class and an object is that a class includes objects to instantiate that class. A class stores methods, but requires an object to call methods from the class.  After building an object for a class, the application can then execute the tasks for the class. We can create many instances of a class.  This improves reusability.
