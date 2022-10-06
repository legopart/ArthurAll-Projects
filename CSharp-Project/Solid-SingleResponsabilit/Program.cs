

//Facade Pattern Principle



public interface IConnectionManager
{
    void Dial(String phoneNumbe);
    void Disconnect();
}
public interface IDataManager
{
    void Send(String message);
    int Receive();
}

public class ConnectionManager : IConnectionManager
{
    public void Dial(String phoneNumbe) { Console.WriteLine("dial " + phoneNumbe); }
    public void Disconnect() { Console.WriteLine("dicsconnect."); }
	
}

public class DataManager : IDataManager
{
    public void Send(String message) { Console.WriteLine("send  " + message); }
    public int Receive() { Console.WriteLine("receive v"); return 0; }
}




public class Phone : IDataManager, IConnectionManager
{
    private IConnectionManager connection;  //interface!
    private IDataManager dataChannel;  //interface!
    public Phone()
    {
        connection = new ConnectionManager();
        dataChannel = new DataManager(); 
    }
    public void Send(String message) { dataChannel.Send(message); }
    public int Receive()  { return dataChannel.Receive(); }
    public void Dial(String phoneNumbe) { connection.Dial(phoneNumbe); }
    public void Disconnect() { connection.Disconnect(); }
}



class Program
{
    static void Main()
    {
        Console.WriteLine("Solid-SingleResponsability");

        Phone phone = new Phone();
        phone.Dial("12345678");
        phone.Send("hi message");
        phone.Receive();
        phone.Disconnect();
    }
}
