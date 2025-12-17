namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int numberOne, int numberTwo) // create method to return the sum of two integers
        {
            return numberOne + numberTwo; // return the sum of parameters
        }

        public static decimal Add(decimal numberOne, decimal numberTwo) // create method to return the sum of two decimals
        {
            return numberOne + numberTwo; // return the sum of the parameters
        }

        public static string Add(int numberOne, int numberTwo, bool paid) // create a method to return some if the bool parameter returns true
        {
            var sum = numberOne + numberTwo; // store the sum of two integers inside a variable
            
            if (paid == true && sum > 1) // check conditions for bool, and amount of sum
            {
                return $"{sum} dollars."; // return string for plural case of sum
            } else if (paid == true && sum == 1) // check conditions for bool, and if sum is equal to 1
            {
                return $"{sum} dollar."; // return string for the singular case of sum
            }

            return "You did not get paid!"; // else return string for false bool
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine(Add(3, 6)); // call Add() method using integers
            Console.WriteLine(Add(30.46m, 4.02m)); // call Add() method using decimals
            Console.WriteLine(Add(4, 6, true)); // call method for plural case
            Console.WriteLine(Add(1, 0, true)); // call method for singular case
            Console.WriteLine(Add(4, 6, false)); // call method for false case
        }
    }
}
