namespace Prototype.Sample1
{
	[Serializable]
	abstract class Widget
	{
		public int Height { get; set; }
		public int Width { get; set; }
		public string? ID { get; set; }
		public abstract Widget Clone();
	}

}
