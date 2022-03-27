namespace ThinkingInSelenium.PageObjects;

public class SeleniumHomePage : UrlNavigablePage<SeleniumHomePage>
{
    private Navigation HeaderNav => new(WrappedDriver);
    protected override string Url => "https://selenium.dev";
    public override bool IsOpen { get; }

    public SeleniumHomePage(IWebDriver driver) : base(driver)
    {
    }

    public SeleniumHomePage OpenDownloadsPage()
    {
        HeaderNav.OpenDownloads();
        return this;
    }

    
}