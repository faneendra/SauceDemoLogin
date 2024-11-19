using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

public static class WebUtilities
{
    public static IWebDriver InitializeDriver()
    {
        ChromeOptions options = new ChromeOptions();
        options.AddArguments("start-maximized"); // Opens browser in maximized mode
        options.AddArguments("disable-infobars"); // Disables the infobar
        options.AddArguments("--disable-extensions"); // Disables existing extensions
        options.AddArguments("--disable-gpu"); // Applicable to windows os only
        options.AddArguments("--disable-dev-shm-usage"); // Overcome limited resource problems
        options.AddArguments("--no-sandbox"); // Bypass OS security model
        IWebDriver driver = new ChromeDriver(options);
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); // Implicit wait
        return driver;
    }

    public static void CloseDriver(IWebDriver driver)
    {
        driver.Quit();
    }
}