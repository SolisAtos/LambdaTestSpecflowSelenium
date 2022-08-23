Feature: ShowcaseGridSessions

Performs a long list of actions so that we can showcase the sessions feature in selenium grid

@ToDoApp
Scenario: Test many options in the To Do App
	Given I navigate to LambdaTest App on following environment
		| Browser  | BrowserVersion   | OS   |
		| <Browser> | <BrowserVersion> | <OS> |
	And I wait for 10 seconds
	And I select the first item
	And I wait for 3 seconds
	And I select the second item
	And I wait for 3 seconds
	And I select the third item
	And I wait for 3 seconds
	And I enter the new value in textbox
	And I wait for 3 seconds
	When I click the Submit button
	Then I verify whether the item is added to the list

	Examples: 
		| Browser       | BrowserVersion | OS         |
		| Chrome        | 84.0           | Windows 10 |
		| Firefox       | 84.0           | Windows 10 |
		| MicrosoftEdge | 84.0           | Windows 10 |
