using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Hooks
{
    [Binding]
    public class Hooks
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver _driver;

        public Hooks(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            _driver = new ChromeDriver();
            _scenarioContext["WebDriver"] = _driver;
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driver.Quit();
        }
    }
}