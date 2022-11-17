namespace Flyweight.Sample1;

// The 'FlyweightFactory' class
class CharacterFactory
{
	private Dictionary<char, Character> _characters = new Dictionary<char, Character>();

	// Character indexer
	public Character this[char key]
	{
		get
		{
			// Uses "lazy initialization" -- i.e. only create when needed.
			Character? character = null;
			if (_characters.ContainsKey(key))
			{
				character = _characters[key];
			}
			else
			{
				// Instead of a case statement with 26 cases (characters).
				// First, get qualified class name, then dynamically create instance 
				string name = this.GetType().Namespace + "." +
									  "Character" + key.ToString();
				character = (Character?)Activator.CreateInstance
									  (Type.GetType(name)!);
			}

			return character!;
		}
	}
}

