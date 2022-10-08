
public enum ToolType
{
    SELECTION,
    BRUSH,
    ERASER
}
public interface ITool
{
    void MouseDown();
    void MouseUp();
}

public class BrushTool : ITool
{
      public void MouseDown() { Console.WriteLine("Brush icon"); }
      public void MouseUp() { Console.WriteLine("Draw a line"); }
}
public class EraserTool : ITool
{
      public void MouseDown() { Console.WriteLine("Eraser icon"); }
      public void MouseUp() { Console.WriteLine("Erase something"); }
}
public class SelectionTool : ITool
{
      public void MouseDown() { Console.WriteLine("Selection icon"); }
      public void MouseUp() { Console.WriteLine("Draw a dashed rectangle"); }
}

public class Canvas : ITool
{
    private ITool currentTool;  //interface
    public void MouseDown() { currentTool.MouseDown(); }
    public void MouseUp() { currentTool.MouseUp(); }
    public ITool GetCurrentTool() { return currentTool; }
    public void SetCurrentTool(ITool currentTool) { this.currentTool = currentTool; } //get interface using class
}

class Program
{
    static void Main()
    {
        Console.WriteLine("State Patterns");

        var canvas = new Canvas();
        canvas.SetCurrentTool(new BrushTool());
        canvas.MouseDown();
        canvas.MouseUp();
        canvas.SetCurrentTool(new EraserTool());
        canvas.MouseDown();
        canvas.MouseUp();
    }
}


public class CanvasFail //wrong
{
    private ToolType currentTool;
    public void MouseDown()
    {
        if (currentTool == ToolType.SELECTION) Console.WriteLine("Selection Icon");
        else if (currentTool == ToolType.BRUSH) Console.WriteLine("Brush Icon");
        else if (currentTool == ToolType.ERASER) Console.WriteLine("Brush Icon");
    }
    public void MouseUp()
    {
        if (currentTool == ToolType.SELECTION) Console.WriteLine("Draw dashed rectangle");
        else if (currentTool == ToolType.BRUSH) Console.WriteLine("Draw a line");
        else if (currentTool == ToolType.ERASER) Console.WriteLine("Erase something");
    }

    public ToolType GetCurrentTool() { return currentTool; }
    public void SetCurrentTool(ToolType currentTool) { this.currentTool = currentTool; }
}