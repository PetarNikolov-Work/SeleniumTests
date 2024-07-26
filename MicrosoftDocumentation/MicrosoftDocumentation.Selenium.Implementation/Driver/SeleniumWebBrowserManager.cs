namespace MicrosoftDocumentation.Selenium.Implementation.Driver
{
    using MicrosoftDocumentation.Selenium.Implementation.Driver.Abstractions;
    using MicrosoftDocumentation.Core.Framework.Driver;
    using OpenQA.Selenium;

    public class SeleniumWebBrowserManager : BaseSeleniumWebDriver, IWebBrowserManager
    {
        private SeleniumWebBrowserManager(IWebDriver driver)
            : base(driver)
        {
            
        }

        public void ExpandToFullScreen()
        {
            base.Driver.Manage().Window.Maximize();
        }
        public void QuitBrowser()
        {
            base.Driver.Quit();
            base.Driver.Dispose();
        }

        public static SeleniumWebBrowserManager Create(IWebDriver driver)
        {
            return new SeleniumWebBrowserManager(driver);
        }
    }
}
