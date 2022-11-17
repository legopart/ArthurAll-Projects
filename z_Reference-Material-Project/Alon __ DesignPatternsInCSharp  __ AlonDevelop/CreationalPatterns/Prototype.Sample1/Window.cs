namespace Prototype.Sample1
{
    class Window
	{
		HashSet<Widget> _widgets = new HashSet<Widget>();

		public void Add(Widget widget)
		{
			_widgets.Add(widget);
		}

		public void Dump()
		{
			foreach (var widget in _widgets)
				Console.WriteLine(widget);
		}

	}

}
