namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int numberOne, int numberTwo)
        {
            return numberOne + numberTwo;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine(Add(3, 6));
        }
    }
}
