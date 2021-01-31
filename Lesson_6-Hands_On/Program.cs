using System;
using myNamespace;
using Unique;

/* [ x ] 4. Using the using keyword, make both of the
 *    namespaces from AnotherProgram.cs available 
 *    to the Program.cs file using aliases.
 
 * [ x ] 5. Within the Main method in Program.cs, call each
 *    of the methods from the namespaces in AnotherProgram.cs.
 
 * [ x ] 6. Your final output should look similar to the following: 
 
        Hello World!
        Hello Earth!
        I am text from the textNamespace. 
*/

namespace Lesson_6_Hands_On
{
    class Program
    {
        static void Main(string[] args)
        {
            // WHY TORTURE US WITH NONSTATICS 
            AnotherProgram ap = new AnotherProgram();
            
            // WHY TORTURE US WITH NONSTATICS 
            TheClass tc = new TheClass();

            Console.WriteLine("Hello World!");
            ap.printText();
            tc.theMethod();
        }
    }
}
