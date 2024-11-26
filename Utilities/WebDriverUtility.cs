using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SauceDemoAutomation.Utilities
{
    public static class WebDriverUtility
    {
        public static IWebDriver CreateWebDriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--start-maximized");
            return new ChromeDriver(options);
        }
    }
}