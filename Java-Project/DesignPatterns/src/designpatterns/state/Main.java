package designpatterns.state;

import designpatterns.state.classes.*;
import designpatterns.state.classes.tools.BrushTool;
import designpatterns.state.classes.tools.EraserTool;

public class Main {
	public static void main(String args[]) {
		System.out.println("abv");
		var canvas = new Canvas();
		canvas.setCurrentTool(new BrushTool());
		canvas.mouseDown();
		canvas.mouseUp();
		canvas.setCurrentTool(new EraserTool());
		canvas.mouseDown();
		canvas.mouseUp();
	}
	

}
 