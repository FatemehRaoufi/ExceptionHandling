using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExceptionHandling
{
    public class MultipleCatchBlocks
    {
        /// <summary>
        /// We can use try-catch-finally in three different ways. They are as follows:

        //Try and Catch: In this case, the exception will be handled and stop the abnormal termination.
        //Try, Catch, and Finally: In this case, the exception will be handled, and stopping the abnormal termination along with the statements that are placed within the “finally” block gets executed at any cost.
        //Try and Finally: In this case, abnormal will not stop when a runtime error occurs because exceptions are not handled but even if an abnormal termination occurs also finally blocks get executed.
        /// </summary>
        public MultipleCatchBlocks()
        {
            int Number1, Number2, Result;
            try
            {
                Console.WriteLine("Enter First Number");
                Number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Number");
                Number2 = int.Parse(Console.ReadLine());
                Result = Number1 / Number2;
                Console.WriteLine($"Result: {Result}");
            }
            catch (DivideByZeroException DBZE)
            {
                Console.WriteLine("Second Number Should Not Be Zero");
            }
            catch (FormatException FE)
            {
                Console.WriteLine("Enter Only Integer Numbers");
            }
            finally
            {
                Console.WriteLine("Hello this is finally block...");
            }
            Console.ReadKey();
        }
    }
}
//https://dotnettutorials.net/lesson/multiple-catch-blocks-csharp/
//https://dotnettutorials.net/lesson/finally-block-in-csharp/