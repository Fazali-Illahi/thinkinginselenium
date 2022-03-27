using OpenQA.Selenium.Firefox;

namespace ThinkingInSelenium;

//Do not use in prod.
public class WebDriverFactory
{
    public static IWebDriver Create()
    {
        var driver= new FirefoxDriver(@"C:\WebDrivers\");
        var timeouts=driver.Manage().Timeouts();
        timeouts.PageLoad= TimeSpan.FromSeconds(30);
        timeouts.ImplicitWait= TimeSpan.FromSeconds(60);
        return driver;
    }
}