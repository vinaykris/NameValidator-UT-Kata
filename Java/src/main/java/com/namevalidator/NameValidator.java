package com.namevalidator;
import java.util.regex.Pattern;
public class NameValidator {

	private static final String regex = "^[a-zA-Z0-9]+$";
	
	public boolean validateUserName(String name) {
        if (name.length() < 6 || name.length() > 12) return false;
        //initializes the regex pattern, gives it the username, and returns true or false if they match
        return Pattern.compile(regex).matcher(name).matches();
    }
}
