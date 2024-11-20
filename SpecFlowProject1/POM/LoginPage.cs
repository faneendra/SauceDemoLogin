using OpenQA.Selenium;

namespace SpecFlowProject1.POM
{
    public class LoginPage
    {
        private IWebDriver _driver;

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void NavigateToLoginPage()
        {
            _driver.Navigate().GoToUrl("https://www.saucedemo.com");
        }

        public void EnterUsernameAndPassword(string username, string password)
        {
            _driver.FindElement(By.Id("user-name")).SendKeys(username);
            _driver.FindElement(By.Id("password")).SendKeys(password);
        }

        public void ClickLoginButton()
        {
            _driver.FindElement(By.Id("login-button")).Click();
        }

        public void VerifySuccessfulLogin()
        {
            // This method should check if the user is redirected to the products page
            // For simplicity, you might check for the presence of a specific element that exists only on the products page
        }
    }
}