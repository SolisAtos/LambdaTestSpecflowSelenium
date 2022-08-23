using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaTestSpecflowSelenium.Pages
{
    public class ToDoAppMainPage
    {
        protected IWebDriver _driver;

        // <input type="checkbox" ng-model="sampletodo.done" name="li1" class="ng-pristine ng-untouched ng-valid">
        private By FirstItemBy = By.Name("li1");

        // <input type="checkbox" ng-model="sampletodo.done" name="li2" class="ng-pristine ng-untouched ng-valid">
        private By SecondItemBy = By.Name("li2");

        // <input type="checkbox" ng-model="sampletodo.done" name="li3" class="ng-pristine ng-untouched ng-valid">
        private By ThirdItemBy = By.Name("li3");

        // <input type="checkbox" ng-model="sampletodo.done" name="li4" class="ng-pristine ng-untouched ng-valid">
        private By FourthItemBy = By.Name("li4");

        // <input type="checkbox" ng-model="sampletodo.done" name="li5" class="ng-pristine ng-untouched ng-valid">
        private By FifthItemBy = By.Name("li5");

        // <input type="text" id="sampletodotext" ng-model="sampleList.sampletodoText" size="30" placeholder="Want to add more" class="ng-pristine ng-untouched ng-valid">
        private By AddMoreTextFieldBy = By.Id("sampletodotext");

        // <input class="btn btn-primary" type="submit" id="addbutton" value="add">
        private By AddToDoButtonBy = By.Id("addbutton");

        public ToDoAppMainPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void ClickFirstCheckBox()
        {
            _driver.FindElement(FirstItemBy).Click();
        }

        public void ClickSecondCheckBox()
        {
            _driver.FindElement(SecondItemBy).Click();
        }

        public void ClickThirdCheckBox()
        {
            _driver.FindElement(ThirdItemBy).Click();
        }

        public void ClickFourthCheckBox()
        {
            _driver.FindElement(FourthItemBy).Click();
        }

        public void ClickFifthCheckBox()
        {
            _driver.FindElement(FifthItemBy).Click();
        }

        public void ClickAddToDoButton()
        {
            _driver.FindElement(AddToDoButtonBy).Click();
        }

        public void WriteToDoTextField(String text)
        {
            _driver.FindElement(AddMoreTextFieldBy).SendKeys(text);
        }

        public string GetNewElementText()
        {
            return _driver.FindElement(By.XPath("/html/body/div/div/div/ul/li[6]/span")).Text;
        }
    }
}
