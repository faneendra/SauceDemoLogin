using OpenQA.Selenium;
using PageObject;

namespace StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        private readonly LoginPage _loginPage;

        public LoginSteps(IWebDriver driver)
        {
            _loginPage = new LoginPage(driver);
        }

        [Given("I am on the Swag Labs login page")]
        public void GivenIAmOnTheSwagLabsLoginPage()
        {
            _loginPage.NavigateToLoginPage();
        }

        [When("I enter a valid username '(.*)'")]
        public void WhenIEnterAValidUsername(string username)
        {
            _loginPage.EnterUsername(username);
        }

        [When("I enter the corresponding password '(.*)'")]
        public void WhenIEnterTheCorrespondingPassword(string password)
        {
            _loginPage.EnterPassword(password);
        }

        [When("I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            _loginPage.ClickLoginButton();
        }

        [Then("I should be redirected to the products page")]
        public void ThenIShouldBeRedirectedToTheProductsPage()
        {
            _loginPage.VerifyRedirectToProductsPage();
        }

        [Then("I should remain on the login page")]
        public void ThenIShouldRemainOnTheLoginPage()
        {
            _loginPage.VerifyStayOnLoginPage();
        }

        [Then("I should see an error message about invalid credentials")]
        public void ThenIShouldSeeAnErrorMessageAboutInvalidCredentials()
        {
            _loginPage.VerifyLoginErrorMessage("invalid credentials");
        }

        [Then("I should see an error message about the necessity to enter a username")]
        public void ThenIShouldSeeAnErrorMessageAboutTheNecessityToEnterAUsername()
        {
            _loginPage.VerifyLoginErrorMessage("enter a username");
        }

        [Then("I should see an error message about the necessity to enter a password")]
        public void ThenIShouldSeeAnErrorMessageAboutTheNecessityToEnterAPassword()
        {
            _loginPage.VerifyLoginErrorMessage("enter a password");
        }
    }
}