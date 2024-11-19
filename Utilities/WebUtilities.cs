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

        public static IWebDriver InitializeDriver()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        return driver;
    }
}
        public void Navigate(string url)
        {
            _driver.Manage().Window.Maximize();
            _waitHelper.ImplicitWait();
            _driver.Navigate().GoToUrl(url);

        public static IWebDriver InitializeDriver()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        return driver;
    }
}
        public IWebElement GetWebElement(By locator)
        {
            _waitHelper.Explicit(locator, 10);
            return _driver.FindElement(locator);
        public static IWebDriver InitializeDriver()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        return driver;
    }
}
        public void ClearAndSendKeys(By locator, string value)
        {

            GetWebElement(locator).Clear();
            GetWebElement(locator).SendKeys(value);

        public static IWebDriver InitializeDriver()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        return driver;
    }
}
        public void IsClick(By locator)
        {
            _driver.FindElement(locator).Click();
        public static IWebDriver InitializeDriver()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        return driver;
    }
}

    public static IWebDriver InitializeDriver()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        return driver;
    }
}
public static IWebDriver InitializeDriver()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        return driver;
    }
}
