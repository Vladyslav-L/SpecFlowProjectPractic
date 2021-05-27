@Registration @Api
Feature: RegistrationApi	

Scenario: It is posible to create client if send Api request POST 
	When I send the request POST to route /registration with valid body	
	Then I successfully logged in NewBookModels as created client