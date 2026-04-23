using Prac.helper;

namespace Prac.Test;

public class HelperTest
{
    [Fact]
    public void OpenBrowser_ReturnsChrome_WhenChromeExists()
    {
        var chromePath = @"C:\Program Files\Google\Chrome\Application\chrome.exe";

        if (!File.Exists(chromePath))
            return;

        var result = Helper.OpenBrowser();

        Assert.Equal(chromePath, result);
    }

    [Fact]
    public void OpenBrowser_ReturnsFirefox_WhenChromeDoesNotExist()
    {
        var chromePath = @"C:\Program Files\Google\Chrome\Application\chrome.exe";

        if (File.Exists(chromePath))
            return;

        var result = Helper.OpenBrowser();

        Assert.Equal(@"C:\Program Files\Mozilla Firefox\firefox.exe", result);
    }


    [Fact]
    public async Task GoTo_DoesNotThrow_WithValidUrl()
    {
        var instance = new Helper();

        var ex = await Record.ExceptionAsync(() => instance.GoTo("https://google.com"));

        Assert.Null(ex);
    }
}