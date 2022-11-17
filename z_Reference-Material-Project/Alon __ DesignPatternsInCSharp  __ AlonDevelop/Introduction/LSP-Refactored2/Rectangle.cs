namespace LSP_Refactored2;

class Rectangle : Shape
{
	public int Width { get; set; }
	public int Height { get; set; }

	public override int Area
	{
		get
		{
			return Width * Height;
		}
	}
}

