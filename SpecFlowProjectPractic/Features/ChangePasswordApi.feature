@ChangePassword @Api
Feature: ChangePasswordApi	

Scenario: It is posible to change client password if send Api request POST 
	Given Client is created		
	When  I send the request POST to route /password/change/ with valid body and authorization token
	Then Client password is changed