// See https://aka.ms/new-console-template for more information
Calc c=new Calc();
Console.WriteLine(c.Add(1,2));

class DescriptionAttribute: System.Attribute 
{
    public DescriptionAttribute(string  text)
    {

        text = text;
    }
    public string Author { get; set; }
    public string Text { get; }

}
//var att  = typeof(Calc).GetCustomAttributes<DescriptionAttribute>();

[Description ("the best calc")]

class Calc 
{
    public int Add(int a, int b) { return a + b; }
}