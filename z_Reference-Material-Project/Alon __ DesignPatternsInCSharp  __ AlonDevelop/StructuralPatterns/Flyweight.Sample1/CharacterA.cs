namespace Flyweight.Sample1;

// A 'ConcreteFlyweight' class
class CharacterA : Character
{
	public CharacterA()
	{
		this.symbol = 'A';
		this.height = 100;
		this.width = 120;
		this.ascent = 70;
		this.descent = 0;
	}
}

