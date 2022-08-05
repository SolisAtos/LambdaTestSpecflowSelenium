Feature: ChromeBrowser
	Testing chrome browsers

@ToDoApp
Scenario: Add items to the ToDoApp - Chrome
	Given I navigate to LambdaTest App on following environment
		| Browser  | BrowserVersion   | OS   |
		| <Broser> | <BrowserVersion> | <OS> |
	And I select the first item
	And I select the second item
	And I enter the new value in textbox
	When I click the Submit button
	Then I verify whether the item is added to the list

	Examples:
		| Browser | BrowserVersion | OS    |
		| chrome  | 88.0           | WIN10 |