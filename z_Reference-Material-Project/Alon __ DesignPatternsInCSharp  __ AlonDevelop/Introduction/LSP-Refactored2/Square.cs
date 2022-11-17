namespace LSP_Refactored2;

class Square : Shape
{
	public int Length { get; set; }

	public override int Area
	{
		get
		{
			return Length * Length;
		}
	}
}

