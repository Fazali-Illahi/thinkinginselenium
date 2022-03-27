namespace ThinkingInSelenium.PageObjects;

public class DownloadsPage : UrlNavigablePage<DownloadsPage>
{
    protected override string Url => "https://www.selenium.dev/downloads/";
    public override bool IsOpen => true; //implement property 
    public DownloadsPage(IWebDriver driver) : base(driver)
    {
    }

   
}