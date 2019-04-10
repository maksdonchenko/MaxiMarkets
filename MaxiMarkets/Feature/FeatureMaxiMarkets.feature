Feature: RegistrationPage
	In order to get personal account
	As a potential user of MyAccount
	I want to register through Registration page

	Background: 
		Given MyAccount page 'registration' is opened

Scenario: Create account with valid data
	When I input 'unique email' in e-mail field
	And I input 'qwerty12345' in password field
	And I input 'qwerty12345' in confirm-password field
	And I click on button Submit
	Then Link 'SignOut' is displayed

Scenario: Check that Contact support link is worked
	When I click on 'contact our support team' link
	Then Native mail client is opened

Scenario Outline: Validation of email and passwords fields
	When I input '<email>' in 'e-mail' field
	And I input '<password>' in 'password' field
	And I input '<confirm password >' in 'confirm-password' field
	And I click on button 'Submit'
	Then Error message '<message>' is displayed near field '<field>'

	Examples:
	| email        | password    | confirm password    | message                 |
	|              | qwerty12345 | qwerty12345         | Email is required       |
	| unique email | qwerty123   |                     | Password is required    |
	|              |             |                     | Password does not match |                     
