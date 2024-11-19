using OpenQA.Selenium;

public class Login
{
    private IWebDriver driver;

    public Login(IWebDriver webDriver)
    {
        driver = webDriver;
    }

    public void NavigateToSite()
    {
        driver.Navigate().GoToUrl("https://www.saucedemo.com");
    }

    public void EnterUsername(string username)
    {
        driver.FindElement(By.Id("user-name")).SendKeys(username);
    }

    public void EnterPassword(string password)
    {
        driver.FindElement(By.Id("password")).SendKeys(password);
    }

    public void ClickLoginButton()
    {
        driver.FindElement(By.Id("login-button")).Click();
    }
}