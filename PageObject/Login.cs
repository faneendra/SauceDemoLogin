namespace PageObject
{
    public class Login
    {
        protected By UserName => By.Name("user-name");
        protected By Password => By.XPath("//input[@name='password' and @id = 'password']");
        protected By SubmitButton => By.Id("login-button");
        protected By ErrorButton => By.CssSelector(".error-button");

        protected By AddToCartSelect => By.Id("add-to-cart-sauce-labs-backpack");
    public void NavigateToLoginPage()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com");
        }

        public void EnterCredentials(string username, string password)
        {
            driver.FindElement(UserName).SendKeys(username);
            driver.FindElement(Password).SendKeys(password);
        }

        public void ClickLoginButton()
        {
            driver.FindElement(SubmitButton).Click();
        }

        public bool IsOnProductsPage()
        {
            return driver.Url.Contains("/inventory.html");
        }
    }
public void NavigateToLoginPage()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com");
        }

        public void EnterCredentials(string username, string password)
        {
            driver.FindElement(UserName).SendKeys(username);
            driver.FindElement(Password).SendKeys(password);
        }

        public void ClickLoginButton()
        {
            driver.FindElement(SubmitButton).Click();
        }

        public bool IsOnProductsPage()
        {
            return driver.Url.Contains("/inventory.html");
        }
    }
