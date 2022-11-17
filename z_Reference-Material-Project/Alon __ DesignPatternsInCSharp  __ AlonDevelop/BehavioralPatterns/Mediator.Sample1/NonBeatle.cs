namespace Mediator.Sample1;

// A 'ConcreteColleague' class
class NonBeatle : Participant
{
	public override void Receive(string from, string message)
	{
		Console.Write("To a non-Beatle: ");
		base.Receive(from, message);
	}
}

