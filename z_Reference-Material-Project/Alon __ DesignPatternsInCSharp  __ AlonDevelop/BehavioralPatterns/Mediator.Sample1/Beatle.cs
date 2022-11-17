namespace Mediator.Sample1;

// A 'ConcreteColleague' class
class Beatle : Participant
{
	public override void Receive(string from, string message)
	{
		Console.Write("To a Beatle: ");
		base.Receive(from, message);
	}
}

