using LambdaTestSpecflowSelenium.Drivers;
using LambdaTestSpecflowSelenium.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow.Assist;

namespace LambdaTestSpecflowSelenium.StepDefinitions
{
    [Binding]
    public sealed class BrowserStepDefinitions
    {
        IWebDriver driver;
        private readonly ScenarioContext _scenarioContext;
        ToDoAppMainPage toDoAppMainPage;
        public BrowserStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I navigate to LambdaTest App on following environment")]
        public void GivenINavigateToLambdaTestAppOnFollowingEnvironment(Table table)
        {
            dynamic data = table.CreateDynamicInstance();

            // For local
            driver = _scenarioContext.Get<SeleniumDriver>("SeleniumDriver").Setup((string)data.Browser);

            driver.Url = "https://lambdatest.github.io/sample-todo-app/";

            toDoAppMainPage = new ToDoAppMainPage(driver);
        }

        [Given(@"I select the first item")]
        public void GivenISelectTheFirstItem()
        {
            // Click on first checkbox
            toDoAppMainPage.ClickFirstCheckBox();
        }

        [Given(@"I select the second item")]
        public void GivenISelectTeSecondItem()
        {
            // Click on second checkbox
            toDoAppMainPage.ClickSecondCheckBox();
        }

        [Given(@"I enter the new value in textbox")]
        public void GivenIEnterTheNewValueInTextbox()
        {
            toDoAppMainPage.WriteToDoTextField("Sample ToDo Text");
        }

        [Given(@"I wait for (.*) seconds")]
        public void GivenIWaitForSeconds(int p0)
        {
            Thread.Sleep(p0*1000);
        }

        [Given(@"I select the third item")]
        public void GivenISelectTheThirdItem()
        {
            // Click on third checkbox
            toDoAppMainPage.ClickThirdCheckBox();
        }


        [When(@"I click the Submit button")]
        public void WhenIClickTheSubmitButton()
        {
            toDoAppMainPage.ClickAddToDoButton();
        }

        [Then(@"I verify whether the item is added to the list")]
        public void ThenIVerifyWhetherTheItemIsAddedToTheList()
        {
            String ActualText = toDoAppMainPage.GetNewElementText();
            Assert.That(ActualText, Is.EqualTo("Sample ToDo Text"));
        }

    }
}