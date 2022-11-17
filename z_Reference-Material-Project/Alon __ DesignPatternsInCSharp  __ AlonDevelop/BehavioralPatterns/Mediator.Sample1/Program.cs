namespace Mediator.Sample1;
class Program
{
	/// <summary>
	/// Entry point into console application.
	/// </summary>
	static void Main()
	{
		// Create chatroom participants
		Participant George = new Beatle { Name = "George" };
		Participant Paul = new Beatle { Name = "Paul" };
		Participant Ringo = new Beatle { Name = "Ringo" };
		Participant John = new Beatle { Name = "John" };
		Participant Yoko = new NonBeatle { Name = "Yoko" };

		// Create chatroom and register participants
		var chatroom = new Chatroom();
		chatroom.Register(George);
		chatroom.Register(Paul);
		chatroom.Register(Ringo);
		chatroom.Register(John);
		chatroom.Register(Yoko);

		// Chatting participants
		Yoko.Send("John", "Hi John!");
		Paul.Send("Ringo", "All you need is love");
		Ringo.Send("George", "My sweet Lord");
		Paul.Send("John", "Can't buy me love");
		John.Send("Yoko", "My sweet love");

	}
}

