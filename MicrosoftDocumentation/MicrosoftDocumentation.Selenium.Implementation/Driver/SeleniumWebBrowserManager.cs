namespace MicrosoftDocumentation.Selenium.Implementation.Driver
{
    using MicrosoftDocumentation.Core.Framework.Driver;
    using OpenQA.Selenium;

    public class SeleniumWebBrowserManager : IWebBrowserManager
    {
        private readonly IWebDriver driver;

        public SeleniumWebBrowserManager(IWebDriver driver)
        {
            this.driver = driver ?? throw new ArgumentNullException(nameof(driver));     
        }

        public void ExpandToFullScreen()
        {
            this.driver.Manage().Window.Maximize();
        }
        public void QuitBrowser()
        {
            this.driver.Quit();
            this.driver.Dispose();
        }
    }
}
