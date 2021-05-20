@Test
Feature: ForgotPassword
	In order to restore access to MyAccount
	As a client
	I want to charge password using email

@mytag1
Scenario: It is possible to charge password using Forgot Password function in MyAccount
	Given Client exist with parameters
	| Email                | Password |
	| testfeature@mail.com | 123qwe   |
	And Forgot password open in MyAccount
	And Email template exists with parameters
	| Body email Template           | Subject      | Type            |
	| Привет! Вот твоя линка 'link' | Забыл пароль | Forgot password |
	When I sent request to Forgot Password  with 'testfeature@mail.com' email on Forgot Password page in MyAccount
	And I follow by "link" in email with 'Забыл пароль' subject
	And I change password on Reset Password page in MyAccount
	And I follow by "link" in email with 'Забыл пароль' subject
	And I set new password on Reset Password page in MyAccount
	| New Password | Confirm New Password |
	| qwe123       | qwe123               |
	And I click 'Change' button on Reset Password page in MyAccount
	And I set data on MyAccount login page
	| Email                | Password |
	| testfeature@mail.com | qwe123   |
	And l click 'button' on MyAccount login page
	Then Client was successful authorization with 'qwe123' password in MyAccount

@mytag1
Scenario Outline: Displayed exeption message if using Forgot Password function to charge password in MyAccount if input invalid data
	Given Client exist with parameters
	| Email                | Password |
	| testfeature@mail.com | 123qwe   |
	And Forgot password open in MyAccount
	And Email template exists with parameters
	| Body email Template           | Subject      | Type            |
	| Привет! Вот твоя линка <link> | Забыл пароль | Forgot password |
	When I sent request to Forgot Password  with 'testfeature@mail.com' email on Forgot Password page in MyAccount
	And I follow by "link" in email with 'Забыл пароль' subject
	And I change password on Reset Password page in MyAccount
	And I follow by "link" in email with 'Забыл пароль' subject
	And I set new password on Reset Password page in MyAccount
	| New Password   | Confirm New Password   |
	| <New Password> | <Confirm New Password> |
	And I click 'Change' button on Reset Password page in MyAccount
	Then Displayed exeption message: <message>
Examples:
	| new_password | confirm_new_password | message                                          |
	| 123qwe       | 123qw                | Password missmatch                               |
	| 123qwe       |                      | Field cannot be empty                            |
	|              | 123qwe               | Field cannot be empty                            |
	| 123qwe       | 123qwe               | New password must not be the same as the old one |