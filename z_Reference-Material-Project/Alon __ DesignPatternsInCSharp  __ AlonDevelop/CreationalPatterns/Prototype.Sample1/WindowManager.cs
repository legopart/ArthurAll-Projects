namespace Prototype.Sample1
{
    class WindowManager
	{
		public Window CreateUI()
		{
			var win = new Window();
			Button b1 = new Button { ID = "b1", Width = 100, Height = 30 };
			win.Add(b1);
			Button b2 = new Button { ID = "b2", Width = 120, Height = 50 };
			Widget b3;
			win.Add(b3 = b1.Clone());
			Border b4 = new Border(new Button { ID = "b4", Width = 60, Height = 80 })
			{
				Height = 30,
				Width = 300,
				ID = "bor1"
			};
			win.Add(b4);
			win.Add(b4.Clone()!);

			return win;
		}
	}

}
