namespace Mediator.Sample1;

// The 'Mediator' interface
interface IChatroom
{
	void Register(Participant participant);
	void Send(string from, string to, string message);
}

