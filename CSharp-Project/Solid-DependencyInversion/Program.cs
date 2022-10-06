

interface IClassA
{

}


class ClassA : IClassA
{ 

}





class ClassB
{
    //ClassA classA;
    IClassA classA;
    public ClassB() 
    {
        classA = new ClassA();
    }
}


class Program
{
    static void Main()
    {
        Console.WriteLine("Dependency Inversion Principle");
    }
}
