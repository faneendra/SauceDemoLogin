using OpenQA.Selenium;
using SpecFlowProject1.POM;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private readonly LoginPage _loginPage;

        public LoginStepDefinitions(LoginPage loginPage)
        {
            _loginPage = loginPage;
        }

        [Given("I am on the login page of Sauce Demo")]
        public void GivenIAmOnTheLoginPageOfSauceDemo()
        {
            _loginPage.NavigateToLoginPage();
        }

        [When("I enter valid username '(.*)' and password '(.*)'")]
        public void WhenIEnterValidUsernameAndPassword(string username, string password)
        {
            _loginPage.EnterUsernameAndPassword(username, password);
        }

        [When("I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            _loginPage.ClickLoginButton();
        }

        [Then("I should be redirected to the products page")]
        public void ThenIShouldBeRedirectedToTheProductsPage()
        {
            _loginPage.VerifySuccessfulLogin();
        }
    }
}