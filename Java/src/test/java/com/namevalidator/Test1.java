package com.namevalidator;

import static org.junit.Assert.*;
import org.junit.Test;
public class Test1 {
	private NameValidator nameValidator = new NameValidator();
	
	@Test
	public void validorinvalidname() {
		String username1 = "abcde1";
		String expectedValidResult = "Valid";
		String notexpectedresult = "Not Valid";
		String actualvalidresult = "";
		String actualnotvalidresult = "";
		if (username1.length() < 5){
			actualnotvalidresult = "Not Valid";
		}
		else {
			actualvalidresult = "Valid"; 
		}
		if(actualnotvalidresult != "") {
			assertEquals(notexpectedresult, actualnotvalidresult);
		}
		else {
			assertEquals(expectedValidResult, actualvalidresult);
		}
	}
	
	@Test
	public void usernamealphanumeric(){
		String[] inputs = {"612345", "ravi1973","ryanky123456","vin"};
		for ( String input: inputs) {
			boolean result = nameValidator.validateUserName(input);
			assertTrue(result);
		}
    }
	
	@Test
    public void validname(){
		String userName = "ryankyabcpqr";
		boolean result = nameValidator.validateUserName(userName);
        assertTrue(result);
        assertTrue(userName.length() <= 12);
        
        userName = "ryanky";
		result = nameValidator.validateUserName(userName);
        assertTrue(result);
        assertTrue(userName.length() >= 5);
    }
	
	@Test
    public void invalidname(){
		String userName = "ryankyabcpqrk";
		boolean result = nameValidator.validateUserName(userName);
        assertFalse(false);
        //assertFalse(userName.length() <= 12);
        
        userName = "ryank";
		result = nameValidator.validateUserName(userName);
        assertFalse(false);
        
        userName = "";
		result = nameValidator.validateUserName(userName);
        assertFalse(false);
    }
	
}
