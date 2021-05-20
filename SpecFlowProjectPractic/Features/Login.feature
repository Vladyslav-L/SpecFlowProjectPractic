@login @ui
Feature: Login
	In order to login in NewBookModels
	As a client of NewBookModels
	I want to be logged in NewBookModels

Scenario: It is possible to login in NewBookModels with valid data
	Given Client is created
	And Sign in page is opened
	When I input valid data of created client
	And I click Log in button
	Then I successfully logged in NewBookModels as created client

Scenario Outline: Displayed exception message if login in NewBookModels with input invalid email
	Given Sign in page is opened
	When I input email <email> in email field
	And I click Log in button
	Then Displayed exception message for login field in Sing in page: <message>
Examples:
	| email   | message       |
	| email11 | Invalid Email |
	| sdsds@  | Invalid Email |
	|         | Required      |

Scenario Outline: Displayed exception message if login in NewBookModels with input invalid data
	Given Sign in page is opened
	When I input email <email> in email field
	And I input password <password> in password field
	And I click Log in button
	Then Displayed exception message for invalid data in Sing in page: <message>
Examples:
	| email                     | password    | message                                    |
	| test1@gmail.com           | QWE147ASD   | Please enter a correct email and password. |
	| StepanBizumm188@gmail.com | QwE147AsD@- | User account is blocked.                   |

	