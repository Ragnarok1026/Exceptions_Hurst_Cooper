using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

namespace Exceptions_Hurst_Cooper
{
    internal class Program
    {
        // In the Main method, create a try-catch block to handle any exceptions that may occur during division.
        static void Main(string[] args)
        {
            // Create a method that takes two parameters, divides them, and returns the result to the Main method.
            float myFloat = 65.4f;
            float myOtherfloat = 0.0f;
            float result = 0f;
            // In the Main method, create a try-catch block to handle any exceptions that may occur during division.
            Random rand = new Random();
            int myInt = rand.Next(2, 30);
            
            try
            {
                // Call the Divide method within the try block.
                result = Divide(myFloat, myOtherfloat);
            }
            catch(Exception e)
            {
                // Catch the exception and display an appropriate message to the user.
                Console.WriteLine(e.Message);
                Console.WriteLine("Please Enter a Number other than Zero.");
                myOtherfloat = (float)Convert.ToDouble(Console.ReadLine());

                // Nested
                try
                {
                    // Call the Divide method again within the nested try block.
                    result = Divide(myFloat, myOtherfloat);
                }
                catch(Exception e2)
                {
                    // Catch the exception and display an appropriate message to the user.
                    Console.WriteLine(e2.Message);
                    Console.WriteLine("You really should have listened the first time.");
                    Environment.Exit(0);

                }
            }
            finally
            {
                // Display the result of the division to the user.
                Console.WriteLine($"The result is: {result}");
            }
            // Create a method that takes a number as a parameter and throws an exception if the number is less than 17.
            try
            {
                CheckAge(myInt);
            }
            catch
            {
                // Catch the exception and display an appropriate message to the user.
                Console.WriteLine($"You Are {myInt}, That Means You Are Not Old Enough! GET OUT!!!");
                
            }
        }

       static float Divide(float x, float y)
        {
            // Check if the second parameter is zero and throw a DivideByZeroException if it is.
            if (y == 0)
            {
                throw new DivideByZeroException();
            }
            else
            {
                // Return the result of the division.
                return x / y;
            }
        }

        static void CheckAge(int age)
        {
            // Throw an ArgumentException if the number is less than 17.
            if (age >= 17)
            {
                // If the number is 17 or greater, display a message indicating that the user is old enough.
                Console.WriteLine($"You are {age}, you can play this game");
            }
            else
            {
                // If the number is less than 17, throw an ArgumentException.
                throw new ArgumentException();
            }
        }
    }
}
