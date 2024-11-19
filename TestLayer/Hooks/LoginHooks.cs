using TechTalk.SpecFlow;
using PageObject;

[Binding]
public class LoginHooks
{
    private readonly ScenarioContext _scenarioContext;
    private LoginPage _loginPage;

    public LoginHooks(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }

    [BeforeScenario]
    public void BeforeScenario()
    {
        _loginPage = new LoginPage();
        _loginPage.InitializeDriver();
    }

    [AfterScenario]
    public void AfterScenario()
    {
        _loginPage.CloseDriver();
    }
}