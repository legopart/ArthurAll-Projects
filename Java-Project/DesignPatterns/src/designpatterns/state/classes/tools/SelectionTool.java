package designpatterns.state.classes.tools;

import designpatterns.state.Interfaces.ITool;

public class SelectionTool implements ITool {
	  @Override
	  public void mouseDown() {
	    System.out.println("Selection icon");
	  }

	  @Override
	  public void mouseUp() {
	    System.out.println("Draw a dashed rectangle");
	  }
	}
