




public interface IPhone
{
    void Dial(String phoneNumbe);
    void Disconnect();
    void Send(String message);
    int Receive();
}

public class Phone : IPhone
{
    public void Dial(String phoneNumbe) { Console.WriteLine("dial " + phoneNumbe); }
    public void Disconnect() { Console.WriteLine("dicsconnect."); }
    public void Send(String message) { Console.WriteLine("send  " + message); }
    public int Receive() { Console.WriteLine("receive v"); return 0; }
}



class Program
{
    static void Main()
    {
        Console.WriteLine("Solid-SingleResponsability-Wronge");

        IPhone phone = new Phone();
        phone.Dial("12345678");
        phone.Send("hi message");
        phone.Receive();
        phone.Disconnect();
    }
}
