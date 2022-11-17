namespace ISP;

class GeometricRect : IGeometricShape
{
	public double Width { get; set; }
	public double Height { get; set; }

	#region IShape Members

	public double Area
	{
		get { return Width * Height; }
	}

	public double Circumference
	{
		get { return 2 * (Width + Height); }
	}

	#endregion
}
