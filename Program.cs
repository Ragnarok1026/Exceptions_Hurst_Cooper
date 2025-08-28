namespace Exceptions_Hurst_Cooper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float myFloat = 65.4f;
            float myOtherfloat = 0.0f;
            float result = 0f;

            Random rand = new Random();
            int myInt = rand.Next(2, 30);

            try
            {
                result = Divide(myFloat, myOtherfloat);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please Enter a Number other than Zero.");
                myOtherfloat = (float)Convert.ToDouble(Console.ReadLine());

                try
                {
                    result = Divide(myFloat, myOtherfloat);
                }
                catch(Exception e2)
                {
                    Console.WriteLine(e2.Message);
                    Console.WriteLine("You really should have listened the first time.");
                }
            }
            finally
            {
                Console.WriteLine($"The result is: {result}");
            }

            try
            {
                CheckAge(myInt);
            }
            catch
            {
                Console.WriteLine($"You Are {myInt}, That Means You Are Not Old Enough! GET OUT!!!");

            }
        }

       static float Divide(float x, float y)
        {
            if(y == 0)
            {
                throw new DivideByZeroException();
            }
            else
            {
                return x / y;
            }
        }

        static void CheckAge(int age)
        {
            if(age >= 17)
            {
                Console.WriteLine($"You are {age}, you can play this game");
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
