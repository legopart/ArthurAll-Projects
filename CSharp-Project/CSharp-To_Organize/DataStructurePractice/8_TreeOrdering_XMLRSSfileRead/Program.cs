namespace ConsoleApp1study
{
    public class Program
    {
        static void Main(string[] args)
        {
            //XML RSS Practice
            //Work with debuger for hebrow reading
            XMLPractice.Run();

            ////Tree Practice
            Tree tree = new Tree();
            tree.Init(100);
            tree.AddItem(50);
            tree.AddItem(200);
            tree.AddItem(30);
            tree.AddItem(20);
            tree.AddItem(5);
            tree.AddItem(9);

            tree.PrintSortedTree();
        }
    }
}
