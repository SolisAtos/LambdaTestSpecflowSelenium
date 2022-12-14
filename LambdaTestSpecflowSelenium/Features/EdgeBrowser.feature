Feature: EdgeBrowser
	Testing Non chrome browsers

@ToDoApp
Scenario: Add items to the ToDoApp - Edge
	Given I navigate to LambdaTest App on following environment
		| Browser  | BrowserVersion   | OS   |
		| <Browser> | <BrowserVersion> | <OS> |
	And I select the first item
	And I select the second item
	And I enter the new value in textbox
	When I click the Submit button
	Then I verify whether the item is added to the list

	Examples: 
		| Browser       | BrowserVersion | OS         |
		| MicrosoftEdge | 84.0           | Windows 10 |