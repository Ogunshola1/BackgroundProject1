Feature: Background
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers
Background: 
Given I navigate to "https://angularjs.realworld.io/#/register"
	When I enter username text "Oyindamola"
	And I enter email text "folake.richardson"
	And I enter password text "PasswordSecured"
	And I click on sign up button

@mytag
Scenario: Creating New Article
	When I click on New Article
	And I write my Article Title "Testing"
	And I write what my article is all about "New Query"
	And I write my Article "Registration"
	And I enter tags "Demo"
	And I click on publish Article
	Then my article should be created successfully


	@mytag
Scenario: Global Feed
When I click on Global Feed
Then I should be able to see all global feed