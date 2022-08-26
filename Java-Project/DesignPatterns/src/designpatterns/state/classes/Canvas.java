package designpatterns.state.classes;

import designpatterns.state.Interfaces.ITool;

public class Canvas {
  private ITool currentTool;	//interface

  public void mouseDown() { currentTool.mouseDown(); }
  public void mouseUp() { currentTool.mouseUp(); }

  public ITool getCurrentTool() { return currentTool; }
  public void setCurrentTool(ITool currentTool) { this.currentTool = currentTool; } //get interface using class
}