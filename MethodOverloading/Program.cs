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
        
        
        static void Main(string[] args)
        {
            Console.WriteLine(Add(3, 6)); // call Add() method using integers
            Console.WriteLine(Add(30.46m, 4.02m)); // call Add() method using decimals
            Console.WritLine(Add());
        }
    }
}
