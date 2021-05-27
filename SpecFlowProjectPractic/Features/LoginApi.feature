@Login @Api
Feature: LoginApi	

Scenario: It is posible to login in NewBookModels if send Api request POST 
	Given Client is created	
	When  I send the request POST to route /authorization with valid body	
	Then I successfully logged in NewBookModels as created client