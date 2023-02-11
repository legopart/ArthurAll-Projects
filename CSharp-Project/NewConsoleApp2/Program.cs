namespace NewConsoleApp2
{

    class Some<T>
    { 
        public static int a = 1;
    }

    public class Program
    {

        private static void Main(string[] args)
        {
            


            Some<int>.a = 5;
            Some<double>.a = 90;


            Console.WriteLine("a is: (" + Some<int>.a + ") "); //5

        }
    }
}
