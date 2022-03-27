namespace ThinkingInSelenium.PageObjects;

public abstract class PageObjectBase : IWrapsDriver, ISearchContext
{
    protected PageObjectBase( IWebDriver driver)
    {
        WrappedDriver = driver;
    }
    public IWebDriver WrappedDriver { get; }

    public IWebElement FindElement(By by)
    {
        return WrappedDriver.FindElement(by);
    }

    public ReadOnlyCollection<IWebElement> FindElements(By by)
    {
        return WrappedDriver.FindElements(by);
    }
}