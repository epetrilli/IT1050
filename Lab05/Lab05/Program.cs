using System;

namespace Lab05
{
    class Program
    {
       
        static void Main(string[] args)
        {
            // a. Scope for the method getArea() includes the entire body of the class. No element in the header defines that scope; the method header with access level, return type, parameter, and paramter list collectively constitute a method. C# methods have that scope by definition. This means that non-static methods in the class can use the getArea() method. Additionally, the public access modifier at the start of the method means that other methods in the class and methods in other classes can use this method. The private access modifier could also be used but that would make it so that the getArea() method could not be called from another class.  
            // b. The method getArea() is non-static because the method header does not contain the static keyword before the return type. Methods that are not declared static are considered non-static. Non-static methods need an instance of the class, an object, to perform a task. In this example, the getArea() method would need an object in order to access the task of multiplying the height and width parameters as specified in the method body. 
            // c. Return Type double, declared after the public access modifier and before the getArea Method Name in the method header, specifies the data type for returned values. The double and float data types can represent floating point numbers that contain a decimal point.  Double stores numbers with greater precision (more digits). The return type could also use int for whole numbers or decimal for more precision (typically used for monetary amounts) to perform the calculations in the method body. Because the return type is not void, the return keyword in the method body can return values.
            // d. Method Name (Identifier) is located after the return type and before the parameters.  In this example, that means getArea. The method name could take other values but should be meaningful and descriptive. The method name can be used to call a method of the same class, or to call a non-static method by using a reference to an object, member access operator, and method name. 
            // e. Parameters height and width in the getArea() method are declared in the parenthesis that follow the method name. Both parameters use the double data type and are contained in a comma-separated list. When the method is invoked, the values passed to the arguments in the method call will need to match the number and order of these parameters in the method header. Other parameters could also be used that obey these constraints.
            // f. The Method Body is contained  between the left and right braces that follow the method header. In this example, the expression height * width  is evaluated and returns the double result type to the caller. The methody body could specify other tasks to perform like assign instance variables to  parameter values.
            // The difference between a user-defined method and a method that is provided within a framework is that user-defined methods are written and customized specifically for the application. Framework provided methods are predefined and come from the .NET Framework Class Library or other class libraries. For example, Math class methods come from the System namespace and perform mathematical calculations. When creating a user-defined method, it is important to consider whether framework provided methods can perform the same task and help modularize programs by making them easier to maintain, debug, and reuse software. It is also important that every method only specify a single task when using user-defined methods.
            // The difference between a static and non-static method is that static methods apply to the class without needing to create an object to call the method. Non-static methods depend on the data for a particular object. Static methods can be called from the same file as Main method by specifying the class that it is declared followed by member access operator and the method name. Static methods must be declared via the static keyword before the return type. Methods not declared static are non-static.      

            Dog myDog = new Dog();
            myDog.Name = "Fido";
            myDog.bark();
            myDog.doTrick("Fetch");
            
            



        }
    }
    class Dog
    {

        public string Name { get; set; }

        public void bark()
        {
            Console.WriteLine("{0} is Barking...", Name);
        }

        public void doTrick(string trickName)
        {
            Console.WriteLine("{0} is so smart!  {0} is doing a(n) {1}", Name, trickName);
        }
                
        
    }
    
}
