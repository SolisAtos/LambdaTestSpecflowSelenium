using LambdaTestSpecflowSelenium.Drivers;
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
        }

        [Given(@"I select the first item")]
        public void GivenISelectTheFirstItem()
        {
            // Click on first checkbox
            driver.FindElement(By.Name("li1")).Click();
        }

        [Given(@"I select the second item")]
        public void GivenISelectTeSecondItem()
        {
            // Click on second checkbox
            driver.FindElement(By.Name("li2")).Click();
        }

        [Given(@"I enter the new value in textbox")]
        public void GivenIEnterTheNewValueInTextbox()
        {
            driver.FindElement(By.Id("sampletodotext")).SendKeys("Sample ToDo Text");
        }

        [When(@"I click the Submit button")]
        public void WhenIClickTheSubmitButton()
        {
            driver.FindElement(By.Id("addbutton")).Click();
        }

        [Then(@"I verify whether the item is added to the list")]
        public void ThenIVerifyWhetherTheItemIsAddedToTheList()
        {
            Assert.That(driver.FindElement(By.XPath("/html/body/div/div/div/ul/li[6]/span")).Text, Is.EqualTo("Sample ToDo Text"));
        }

    }
}