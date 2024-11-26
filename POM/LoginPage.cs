using OpenQA.Selenium;

namespace SauceDemoAutomation.POM
{
    public class LoginPage
    {
        private IWebDriver _driver;
        private By _usernameField = By.Id("user-name");
        private By _passwordField = By.Id("password");
        private By _loginButton = By.Id("login-button");
        private By _errorMessage = By.CssSelector(".error-message-container");

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void NavigateToLoginPage()
        {
            _driver.Navigate().GoToUrl("https://www.saucedemo.com");
        }

        public void EnterUsername(string username)
        {
            _driver.FindElement(_usernameField).SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            _driver.FindElement(_passwordField).SendKeys(password);
        }

        public void ClickLoginButton()
        {
            _driver.FindElement(_loginButton).Click();
        }

        public void VerifyRedirectedToProductsPage()
        {
            // This method would typically check the URL or a specific element on the products page to confirm navigation.
        }

        public void VerifyErrorMessageInvalidCredentials()
        {
            // This method would typically check for the presence of an error message element and its text content.
        }

        public void VerifyErrorMessageEmptyUsername()
        {
            // This method would typically check for the presence of an error message element and its text content.
        }

        public void VerifyErrorMessageEmptyPassword()
        {
            // This method would typically check for the presence of an error message element and its text content.
        }
    }
}