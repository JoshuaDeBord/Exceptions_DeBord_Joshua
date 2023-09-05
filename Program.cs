namespace Exceptions_DeBord_Joshua
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            float myFloat = 65.4f; //makes a float called myFloat with a value of 65.4
            float myOtherFloat = 0.0f; //makes a float called myOtherFloat with a value of 0.0
            float result = 0f;//makes a float called result with a value of 0

            Random rand = new();//makes a random number generator called rand
            int myInt = rand.Next(2, 30);//makes an integer called myInt equalling rand.Next with 2 and 30

            try//try statement
            {
                result = Divide(myFloat, myOtherFloat);
            }
            catch (Exception e)//catch statement going off the recent try statement
            {
                Console.WriteLine(e.Message); //tells the user the reason for the error
                Console.WriteLine("Please enter a number other than zero.");//tells the user to input a number other than zero




                try
                {
                    myOtherFloat = (float)Convert.ToDouble(Console.ReadLine());
                    result = Divide(myFloat, myOtherFloat);
                }
                catch (Exception e2)
                {
                    Console.WriteLine(e2.Message); //tells the user the reason for the error
                }
            }
            finally
            {
                Console.WriteLine("Calculations completed with a result of " + result);//tells the user the calculations completed with a result
            }

            try
            {
                CheckAGe(myInt);
            }
            catch (Exception)
            {
                Console.WriteLine("You are not old enough");//tells the user they are not old enough

            }
            static float Divide(float x, float y)
            {
                return y == 0 ? throw new DivideByZeroException() : x / y;
            }

            static void CheckAGe(int Age)
            {
                if (Age >= 17)
                {
                    Console.WriteLine($"you are {Age}, you can play mature games!");//tells the user they are old enough
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
    }
}