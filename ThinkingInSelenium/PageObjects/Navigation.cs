namespace ThinkingInSelenium.PageObjects;

public class Navigation : PageObjectBase
{
    private IWebElement  Downloads => WrappedDriver.FindElement(By.CssSelector("a[href*='downloads']"));
    
    public Navigation(IWebDriver driver) : base(driver)
    {
    }

    public DownloadsPage OpenDownloads()
    {
        Downloads.Click();
        return new DownloadsPage(WrappedDriver);
    }
}