Feature: Login
	So that I can access Advertising Studio via my Marketing Cloud account
	As a Marketing Cloud user
	I want to to be able to click through to Advertising Studio when I am logged into the Marketing Cloud

Scenario: User logs into Marketing Cloud and selects Advertising Studio from the navigation
	Given I have logged into my Marketing Cloud account
	When I select the Advertising Studio option from the navigation
	Then I should be redirected to Advertising Studio 