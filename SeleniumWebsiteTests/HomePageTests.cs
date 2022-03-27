namespace SeleniumWebsiteTests;

[TestFixture(TestName = "HomePage")]
public class Tests : WebPageTestOf<SeleniumHomePage>
{
    //test intended for demonstrate POM. 
    [Test]
    public void OpenHomePageTests()
    {
        var page=Page?
            .Open()
            .OpenDownloadsPage()!;
        Assert.That(page.IsOpen,Is.True);
    }
}