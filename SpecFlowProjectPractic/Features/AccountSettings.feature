@AccountSettings @ui
Feature: Login
	In order to change account settings in NewBookModels
	As a client of NewBookModels
	I want to be changed account settings in NewBookModels

Scenario:  Check successful change general information in Account Settings page
	Given Client is created
	And Account Settings page is opened
	When  Client click Edit button
	And I fill first name in first name field for Account Settings page
	And I fill last name in last name field for Account Settings page
	And I fill industry in industry field for Account Settings page
	And I fill company location in company location field for Account Settings page
	And I click company location button for Account Settings page
	And I click Save Changes button for general information in Account Settings page
	Then Account settings is changed

Scenario:  Check successful change password in Account Settings page
	Given Client is created
	And Account Settings page is opened
	When Client click Edit button for password
	And I fill old password in old password field for Account Settings page
	And I fill new password in new password field for Account Settings page
	And I fill confirm password in confirm password field for Account Settings page
	And I click Save Changes button for password in Account Settings page
	Then Password is changed

Scenario:  Check successful change email in Account Settings page
	Given Client is created
	And Account Settings page is opened
	When Client click Edit button for email
	And I fill password in password field for Account Settings page
	And I fill new email in new email field for Account Settings page	
	And I click Save Changes button for email in Account Settings page
	Then Email is changed