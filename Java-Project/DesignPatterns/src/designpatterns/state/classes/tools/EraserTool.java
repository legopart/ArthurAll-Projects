package designpatterns.state.classes.tools;

import designpatterns.state.Interfaces.ITool;

public class EraserTool implements ITool {
	  @Override
	  public void mouseDown() {
	    System.out.println("Eraser icon");
	  }

	  @Override
	  public void mouseUp() {
	    System.out.println("Erase something");
	  }
	}

