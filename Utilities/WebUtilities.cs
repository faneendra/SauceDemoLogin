namespace Utilities
{
    public class WebUtilities
    {
        public readonly IWebDriver _driver;
        private WaitHelper _waitHelper;


       

        public WebUtilities(IWebDriver driver)
        {
            this._driver = driver;

            _waitHelper = new WaitHelper(driver);

        }
        public void Navigate(string url)
        {
            _driver.Manage().Window.Maximize();
            _waitHelper.ImplicitWait();
            _driver.Navigate().GoToUrl(url);

        }
        public IWebElement GetWebElement(By locator)
        {
            _waitHelper.Explicit(locator, 10);
            return _driver.FindElement(locator);
        }
        public void ClearAndSendKeys(By locator, string value)
        {

            GetWebElement(locator).Clear();
            GetWebElement(locator).SendKeys(value);

        }
        public void IsClick(By locator)
        {
            _driver.FindElement(locator).Click();
        }

    }
}
