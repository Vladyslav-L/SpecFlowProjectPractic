@UploadPhoto @Api
Feature: UploadPhotoApi	

Scenario: It is posible to upload client profile photo if send Api request POST 
	Given Client is created		
	When I send the request POST to route /images/upload/ with valid body
	And I send the request PATCH to route /client/self/ with valid body
	Then Client profile photo is uploaded