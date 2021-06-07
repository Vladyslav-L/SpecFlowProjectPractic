@ChangeGeneralInformation @Api
Feature: Change General Information

Scenario: It is posible to change client first name if send Api request PATCH
	Given Client is created
	When I send the request PATCH to route /client/self/ with valid body and authorization token
	Then Client first name is changed

Scenario: It is posible to change client last name if send Api request PATCH
	Given Client is created
	When  I send the request PATCH to route /client/self/ with valid body and authorization token for change last name
	Then Client last name is changed

Scenario: It is posible to change client company location if send Api request PATCH
	Given Client is created
	When I send the request PATCH to route /client/profile/ with valid body and authorization token
	Then Client company location is changed

Scenario: It is posible to change client industry if send Api request PATCH
	Given Client is created
	When I send the request PATCH to route /client/profile/ with valid body and authorization token for change industry
	Then Client industry is changed