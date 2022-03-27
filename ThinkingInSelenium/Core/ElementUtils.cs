namespace ThinkingInSelenium.Core;

internal class ElementUtils
{
    //overloading: DRY
    internal static bool ElementIfVisible(IWebElement element, TimeSpan timeSpan)
    {
        var driver = (element as IWrapsDriver)?.WrappedDriver!;
        var wait = new WebDriverWait(driver, timeSpan);
        return wait.Until(_ => element.Displayed && element.Enabled);
    }

    internal static bool ElementIfVisible(IWebElement element) => ElementIfVisible(element, TimeSpan.FromSeconds(60));

    internal static bool ElementIfVisible(IWebDriver driver,By selector, TimeSpan timeSpan)
    {
        var wait = new WebDriverWait(driver, timeSpan);
        return wait.Until(d =>
        {
            var element = d.FindElement(selector);
            return element.Displayed && element.Enabled;
        });
    }
    
    internal static bool ElementIfVisible(IWebDriver driver, By selector) =>
        ElementIfVisible(driver, selector, TimeSpan.FromSeconds(60));
}