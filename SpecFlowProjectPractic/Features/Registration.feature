@registration @ui
Feature: Registration
	In order to have full functional in NewBookModels
	As a client of NewBookModels
	I want to be registrated in NewBookModels

Scenario: It is possible to registration in NewBookModels with valid data
	Given Sign up page is opened
	When I registration user using data
	| First name | Last name | Email                                  | Password    | Confirm password | Mobile  |
	| Vitalik    | Petrenko  | VitalikPetrenko1454888466644@gmail.com | QWE147asd!- | QWE147asd!-      | 7788445 |
	And I click Next button
	Then I successfully logged in NewBookModels as created client

Scenario: Check exception message for first name field if using invalid data
	Given Sign up page is opened
	When I fill empty first name in first name field for Sing Up page	
	And I click Next button
	Then Displayed exception message: Required for first name field for Sing Up page
	

Scenario: Check exception message for last name field if using invalid data
	Given Sign up page is opened
	When I fill empty last name in last name field for Sing Up page	
	And I click Next button
	Then Displayed exception message: Required for last name field for Sing Up page
	

Scenario Outline: Check exception message for email field if using invalid data
	Given Sign up page is opened
	When I fill email <Email> in email field for Sing Up page
	And I click Next button
	Then Displayed exception message <Message> for email field for Sing Up page
Examples:
	| Email   | Message       |
	| fsdfsdf | Invalid Email |
	|         | Required      |
	| email@  | Invalid Email |

Scenario Outline: Check exception message for password field if using invalid data
	Given Sign up page is opened
	When I fill password <Password> in password field for Sing Up page
	And I click Next button
	Then Displayed exception message <Message> for password field for Sing Up page
Examples:
	| Password | Message                 |
	| qwe123   | Invalid password format |
	|          | Invalid password format |
	| qwerty   | Invalid password format |
	| QWE123   | Invalid password format |
	| QWErty   | Invalid password format |

Scenario Outline: Check exception message for mobile field if using invalid data
	Given Sign up page is opened
	When I fill mobile <Mobile> in mobile field for Sing Up page
	And I click Next button
	Then Displayed exception message <Message> for mobile field for Sing Up page
Examples:
	| Mobile | Message              |
	| 456.6  | Invalid phone format |
	|        | Invalid phone format |
	| 123456 | Invalid phone format |