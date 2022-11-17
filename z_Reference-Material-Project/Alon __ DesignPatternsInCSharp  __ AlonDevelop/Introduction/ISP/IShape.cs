namespace ISP
{
    public interface IShape
	{
		void Draw(Canvas canvas);
		ConsoleColor Color { get; set; }

		double Area { get; }
		double Circumference { get; }
	}
}

