namespace ThinkingInSelenium.PageObjects;

public abstract class UrlNavigablePage<T> : PageObjectBase,IDisposable where T : UrlNavigablePage<T>
{
    protected abstract string Url { get; }
    public abstract bool IsOpen { get; }

    protected UrlNavigablePage(IWebDriver driver) : base(driver)
    {
    }

    public T Open()
    {
        WrappedDriver.Navigate().GoToUrl(Url);
        return (T)this;
    }
    
    public void Dispose()
    {
        WrappedDriver.Close();
        WrappedDriver.Quit();
        WrappedDriver.Dispose();
    }
}