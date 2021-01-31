using System;


/* [ x ] 1. Create another file named AnotherProgram.cs.
 * [ x ] 2. Within AnotherProgram.cs, include the following: 

        [ x ] - The necessary using statement for System
                   vvv THIS IS BAD PRACTICE, FIRE WHOEVER WROTE THIS QUESTION vvv
        [ x ] - A namespace named myNamespace. Within this namespace add the following: 
           [ x ] - A class named AnotherProgram
           [ x ] - Add a method within the class named printText that prints "Hello Earth!" to the console.

 * [ x ] 3. Again within the AnotherProgram.cs file, create another namespace. 
        [ x ] - Give this namespace a unique name.
        [ x ] - The namespace should have a class that includes a method. 
            [ x ] - The method should have a unique print statement.

*/


// I'm going to just follow the directions at this point
namespace myNamespace // https://docs.microsoft.com/en-us/previous-versions/dotnet/netframework-1.1/893ke618(v=vs.71)?redirectedfrom=MSDN
{
    public class AnotherProgram     // WHY TORTURE US WITH NONSTATICS
    {
        public void printText()
        {
            Console.WriteLine("Hello Earth!");
        }
    }
}

// Who wrote this question? Tell them to hand in their two week notice.
namespace Unique
{
    public class TheClass           // WHY TORTURE US WITH NONSTATICS 
    {
        public void theMethod()
        {
            Console.WriteLine("Most unique print statement.");
        }
    }
}