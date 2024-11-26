using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using SauceDemoAutomation.POM;

namespace SauceDemoAutomation.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private readonly LoginPage _loginPage;
        private readonly IWebDriver _driver;

        public LoginStepDefinitions(IWebDriver driver)
        {
            _driver = driver;
            _loginPage = new LoginPage(_driver);
        }

        [Given("I am on the SauceDemo login page")]
        public void GivenIAmOnTheSauceDemoLoginPage()
        {
            _loginPage.NavigateToLoginPage();
        }

        [When("I enter valid username '(.*)' and password '(.*)'")]
        public void WhenIEnterValidUsernameAndPassword(string username, string password)
        {
            _loginPage.EnterUsername(username);
            _loginPage.EnterPassword(password);
        }

        [When("I enter invalid username '(.*)' and any password")]
        public void WhenIEnterInvalidUsernameAndAnyPassword(string username, string password)
        {
            _loginPage.EnterUsername(username);
            _loginPage.EnterPassword(password);
        }

        [When("I leave the username field empty and enter password '(.*)'")]
        public void WhenILeaveTheUsernameFieldEmptyAndEnterPassword(string password)
        {
            _loginPage.EnterUsername("");
            _loginPage.EnterPassword(password);
        }

        [When("I enter username '(.*)' and leave the password field empty")]
        public void WhenIEnterUsernameAndLeaveThePasswordFieldEmpty(string username)
        {
            _loginPage.EnterUsername(username);
            _loginPage.EnterPassword("");
        }

        [When("I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            _loginPage.ClickLoginButton();
        }

        [Then("I should be redirected to the products page")]
        public void ThenIShouldBeRedirectedToTheProductsPage()
        {
            _loginPage.VerifyRedirectedToProductsPage();
        }

        [Then("I should see an error message about invalid credentials")]
        public void ThenIShouldSeeAnErrorMessageAboutInvalidCredentials()
        {
            _loginPage.VerifyErrorMessageInvalidCredentials();
        }

        [Then("I should see an error message about the necessity to enter a username")]
        public void ThenIShouldSeeAnErrorMessageAboutTheNecessityToEnterAUsername()
        {
            _loginPage.VerifyErrorMessageEmptyUsername();
        }

        [Then("I should see an error message about the necessity to enter a password")]
        public void ThenIShouldSeeAnErrorMessageAboutTheNecessityToEnterAPassword()
        {
            _loginPage.VerifyErrorMessageEmptyPassword();
        }
    }
}