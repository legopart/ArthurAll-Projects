namespace Mediator.Sample1;

// The 'AbstractColleague' class
class Participant
{
	// Gets or sets participant name
	public string? Name { get; set; }

	// Gets or sets chatroom
	public Chatroom? Chatroom { get; set; }

	// Send a message to given participant
	public void Send(string to, string message)
	{
		Chatroom?.Send(Name ?? "None", to, message);
	}

	// Receive message from participant
	public virtual void Receive(
		 string from, string message)
	{
		Console.WriteLine("{0} to {1}: '{2}'",
			 from, Name, message);
	}
}

