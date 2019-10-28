using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    class Program
    {
        static void Main(string[] args)
        {
            Book myBook = new Book();
            myBook.Title = "Visual C#: How To Program";
            myBook.Author = "Deitel, Paul & Deitel, Harvey";
            myBook.Year = 2017;
            myBook.Display();

            BookTest bt1 = new BookTest();
            bt1.Test();
        }
    }
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public Book()
        {

        }
        public Book(string title, string author, int year)
        {
            this.Title = title;
            this.Author = author;
            this.Year = year;
        }
        public void Display()
        {
            Console.WriteLine($"Title: {Title}\nAuthor: {Author}");
        }
    }
    class BookTest
    {
        public void Test()
        {
            Book myBook2 = new Book("Microsoft Visual C# Step by Step", "Sharp, John", 2018);
            myBook2.Display();
            
        }

    }
    // 3. Every object needs a constructor call. 
    // If we do not add an explicit constructor method for our object then the compiler will create a default constructor without taking arguments. 
    // If not using the private keyword for the constructor, the compiler will make it public so that the class can be instantiated.
    // The default constructor initializes each field to default values.
    // In our example, that would mean null for the string properties and 0 for the int property.

    // 4. Creating two new constructor methods would demonstrate the concept of overloaded constructors.
    // This concept allows objects of a class to be initialized differently.
    // Overloaded constructors are attained by providing constructors with different signatures.
    // When arguments are passed to the overloaded constructors, the number and type of arguments in the constructor call will be matched to the number and type of parameters in the constructor declaration.

    // 5. Exception handling is important to use because it can validate that arguments are not out of range. 
    // For example, we would not want to accept values for minutes greater than the integer 59 when working with time formats.
    // A throw statement can indicate out of range values.
    // After creating an exception object the containing method terminates and the code can execute try…catch statements to handle and recover from the exception. 
    // Exception handling can create fault tolerant programs that continue to execute despite encountering exceptions.

    // 6. The purpose of private vs. public when adding new properties or methods is to control access to the members in a class. 
    // Public methods and properties can access any code in the program. Private methods and properties can only access members in the same class. 
    // This allows for exposure to a class by using an object reference while still hiding the implementation details reflected in private variables, properties, and methods.

    // 7. The concept of composition enables references to objects of other classes.
    // We could use composition in our Book class to reference the myBook2 object that was created in our BookTest class.   
    // This reference could include a new property like Publisher. 
    // We can reference a property from another class by including the name of the class that contains an object of the property we want to reference.
    // This would create a has-a relationship for Book class in reference to the BookTest class.

    // 8. Data abstraction can include classes, methods, and properties. 
    // Abstract classes are useful for when you do not plan to instantiate an object inside the class. 
    // These are base classes for the purposes of inheritance. 
    // Only the derived classes can be used to instantiate objects and provide implementations for every method. 
    // Abstract classes usually include at least one abstract method which does not provide implementations. 
    // Abstract properties use the get and set keywords without implementation and can be overridden in derived classes. 

}
