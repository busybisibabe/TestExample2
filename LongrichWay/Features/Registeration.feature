Feature: Registration

@myfirsttest
Scenario: Valid Registration
	Given I navigate to "https://longrichway.com/"
	When I click on register button
	And I enter First Name "Tester"
	And I enter Last Name "Bleaky"
	And I enter Email Address "allaboutu@email.com"
	And I enter Phone Number "12345678910"
	And I enter Password "Wonderful"
	And I enter Confirm Password "Wonderful"
	And I enter Address "21 Western Avenue"
	And I enter Town "Alekuwodo"
	And I enter State "Osun"
	And I click on Create Account Button
	Then the message "Registration Successful Login to your Account" is displayed on the page