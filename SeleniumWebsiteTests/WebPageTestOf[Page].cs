namespace SeleniumWebsiteTests;
public abstract class WebPageTestOf<T> where T: UrlNavigablePage<T>
{
    protected T? Page { get; private set; }
    
    [SetUp]
    public void Setup()
    {
        //Don't use in prod. use dependency injection 
        Page = (T) Activator.CreateInstance(typeof(T), WebDriverFactory.Create())!?? throw new NullReferenceException($"Cannot initialize {typeof(T).Name}");
    }
    
    [TearDown]
    public void Cleanup()
    {
        Page?.Dispose();
    }
}