
namespace ExceptionHandling
{
    public class PreventingExceptionHandlingAbuse
    {
        public PreventingExceptionHandlingAbuse()
        {
            /*
             * Here we are using exception handling to implement logical flow:
                        try
                        {
                            //Convert.ToInt32() can throw FormatException, if the entered value
                            //cannot be converted to integer. So use int.TryParse() instead
                            Console.WriteLine("Please enter First Number");
                            int FirstNumber = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Please enter Second Number");
                            int SecondNumber = Convert.ToInt32(Console.ReadLine());
                            int Result = FirstNumber / FirstNumber;
                            Console.WriteLine($"Result = {Result}");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Only numbers are allowed!");
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine($"Only numbers between {Int32.MinValue} & {Int32.MaxValue} are allowed");
                        }
                        catch (DivideByZeroException)
                        {
                            Console.WriteLine("Secoond Number cannot be zero");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        Console.ReadLine();
            */
            //Preventing Exception Handling Abuse:
            /*
             Let’s rewrite the same example that doesn’t use exception handling to control the program’s logical flow. 
            In the below example, we are using tryParse for Handling the Input Format,             
            If Else condition to handle the Divide Operations, and Max and Min Length. */

            try
            {
                Console.WriteLine("Please Enter First Number");
                int FirstNumber;
                //int.TryParse() will not throw an exception, instead returns false
                //if the entered value cannot be converted to integer
                bool IsValidFirstNumber = int.TryParse(Console.ReadLine(), out FirstNumber);
                if (IsValidFirstNumber)
                {
                    Console.WriteLine("Please Enter Second Number");
                    int SecondNumber;
                    bool isValidSNO = int.TryParse(Console.ReadLine(), out SecondNumber);
                    if (isValidSNO && SecondNumber != 0)
                    {
                        int Result = FirstNumber / SecondNumber;
                        Console.WriteLine($"Result = {Result}");
                    }
                    else
                    {
                        //Check if the second number is zero, print a friendly error
                        //message instead of allowing DivideByZeroException exception 
                        //to be thrown.
                        if (isValidSNO && SecondNumber == 0)
                        {
                            Console.WriteLine("Second Number cannot be zero");
                        }
                        else
                        {
                            Console.WriteLine($"Only numbers between {Int32.MinValue} && {Int32.MaxValue} are allowed");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Only numbers between {Int32.MinValue} && {Int32.MaxValue} are allowed");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();


        }

    }
}
//https://dotnettutorials.net/lesson/exception-handling-abuse-csharp/