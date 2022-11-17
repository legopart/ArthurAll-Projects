namespace Prototype.Sample1
{
	[Serializable]
	class Button : Widget
	{
		public override Widget Clone()
		{
			// make a shallow copy
			return (MemberwiseClone() as Widget)!;
		}

		public override string ToString()
		{
			return string.Format("Button ID={0}, Width={1}, Height={2}", ID, Width, Height);
		}
	}

}
