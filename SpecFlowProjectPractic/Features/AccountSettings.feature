@AccountSettings @ui
Feature: Account Settings
	In order to change account settings in NewBookModels
	As a client of NewBookModels
	I want to be changed account settings in NewBookModels

Scenario: Check successful change general information in Account Settings page
	Given Client is created
	And Client is logged
	When Account Settings page is opened
	And I click edit button for general information
	And I fill first name Vitalik in first name field for Account Settings page
	And I fill last name Petrenko in last name field for Account Settings page
	And I fill industry industry in industry field for Account Settings page
	And I fill company location 1454 South County Trail, East Greenwich in company location field for Account Settings page
	And I click company location button for Account Settings page
	And I click Save Changes button for general information in Account Settings page
	Then Account settings is changed

Scenario: Check successful change password in Account Settings page
	Given Client is created
	And Client is logged
	When Account Settings page is opened
	And I click edit button for password
	And I fill old password in old password field for Account Settings page
	And I fill new password in new password field for Account Settings page
	And I fill confirm password in confirm password field for Account Settings page
	And I click Save Changes button for password in Account Settings page
	Then Password is changed

Scenario:  Check successful change email in Account Settings page
	Given Client is created
	And Client is logged
	When Account Settings page is opened
	And I click edit button for email
	And I fill password in password field for Account Settings page
	And I fill new email in new email field for Account Settings page
	And I click Save Changes button for email in Account Settings page
	Then Email is changed

Scenario: Check successful change phone number in Account Settings page
	Given Client is created
	And Client is logged
	When Account Settings page is opened
	And I click edit button for phone number
	And I fill current password in password field for Account Settings page
	And I fill phone number in new phone number field for Account Settings page
	And I click Save Changes button for email in Account Settings page
	Then Phone number is changed