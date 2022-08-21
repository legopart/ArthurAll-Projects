import java.util.regex.Pattern;

public class Test {
private		int testID;	
private		String testName;
private		String testDate;
	
	
	Test(int testID, String testName, String testDate) throws Illegal_Exception_Id, Illegal_Exception_Message{
		setTestID(testID);
		setTestName(testName);
		setTestDate(testDate);
	}
	
	
	public int getTestID() {
		return testID;
	}
	public String getTestName() {
		return testName;
	}
	public String getTestDate() {
		return testDate;
	}





	public void setTestID(int testID) throws Illegal_Exception_Id {
		if(testID<0) {throw new Illegal_Exception_Id("\""+testID + "\" --negative number entered to test id");}
		this.testID = testID;
	}
	public void setTestName(String testName) throws Illegal_Exception_Message {
		
		if(testName.length()<3) {throw new Illegal_Exception_Message("\""+testName + "\" --is too short test name (alowed between 3-19)");}
		if(testName.length()>20) {throw new Illegal_Exception_Message("\""+testName + "\" --is too long test name (alowed between 3-19)");}
		this.testName = testName;
	}
	public void setTestDate(String testDate) throws Illegal_Exception_Message {
		this.testDate = testDate;
	}



	@Override
	public String toString() {
		return
		"- "
		+getTestID()+", "
		+getTestName()+", "
		+getTestDate()+", "
		;
	}
	
	
	
}
