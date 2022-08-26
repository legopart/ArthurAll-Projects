package designpatterns.state.classes.tools;

import designpatterns.state.Interfaces.ITool;

public class BrushTool implements ITool {
	  @Override
	  public void mouseDown() {
	    System.out.println("Brush icon");
	  }

	  @Override
	  public void mouseUp() {
	    System.out.println("Draw a line");
	  }
	}
