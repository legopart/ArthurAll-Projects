package Classes;
import java.io.Serializable;
import java.util.regex.Pattern;

import Exeption.Illegal_Exception_Message;
import Exeption.Patterns;

public class Test implements Serializable  {
private		String testID;	
private		String testName;
private		String testDate;
private		String testTime;	
	
	public Test(String testID,String testName, String testDate, String testTime) throws Illegal_Exception_Message{
		setTestID(testID);
		setTestName(testName);
		setTestDate(testDate);
		setTestTime(testTime);
	}
	
	public String getTestID() {return testID;}
	public String getTestName() {return testName;}
	public String getTestDate() {return (testDate==null ? null :testDate.replaceAll(" ",""));}
		public String getDateYear(){return getTestDate().substring(6,8);}
		public String getDateMouth(){return getTestDate().substring(3,5);}
		public String getDateDay(){return getTestDate().substring(0,2);}
	public String getTestTime() {return testTime;}

	public void setTestID(String testID) throws Illegal_Exception_Message {
		Patterns.testId(testID);
		this.testID = testID;
	}
	public void setTestName(String testName) throws Illegal_Exception_Message {
		Patterns.testName(testName);
		this.testName = testName;
	}
	public void setTestDate(String testDate) throws Illegal_Exception_Message {
		Patterns.testDate(testDate);
		this.testDate = testDate;
	}
	public void setTestTime(String testTime) throws Illegal_Exception_Message {
		Patterns.testTime(testTime);
		this.testTime = testTime;
	}

	@Override
	public String toString() {return "- "+getTestName()+", "+getTestDate()+", "+getTestTime()+", ";}

}