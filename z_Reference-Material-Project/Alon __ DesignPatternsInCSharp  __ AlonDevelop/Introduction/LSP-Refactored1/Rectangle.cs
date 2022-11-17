namespace LSP_Refactored1;

class Rectangle
{
	public int Width { get; private set; }
	public int Height { get; private set; }

	public virtual int Area
	{
		get
		{
			return Width * Height;
		}
	}

	public Rectangle(int width, int height)
	{
		Width = width;
		Height = height;
	}
}

