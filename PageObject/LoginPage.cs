using OpenQA.Selenium;

namespace PageObject
{
    public class LoginPage
    {
        private IWebDriver _driver;
        private By _usernameField = By.Id("user-name");
        private By _passwordField = By.Id("password");
        private By _loginButton = By.Id("login-button");

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

        public void VerifyRedirectToProductsPage()
        {
            // This method should check if the current URL is the products page URL
        }

        public void VerifyStayOnLoginPage()
        {
            // This method should check if the current URL is still the login page URL
        }

        public void VerifyLoginErrorMessage(string message)
        {
            // This method should check if the error message displayed matches the expected message
        }
    }
}