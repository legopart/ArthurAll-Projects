public class Fizzbuzz
{
    //int number = Int32.Parse(Console.ReadLine());    
    public string Output(int i)
    {
        string output = i % 15 == 0 ? "fizzbuzz"
                : i % 5 == 0 ? "buzz"
                : i % 3 == 0 ? "fizz"
                : i.ToString();

        return output;
    }
}