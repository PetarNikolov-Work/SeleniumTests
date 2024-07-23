namespace MicrosoftDocumentation.Selenium.Implementation.Driver
{
    using MicrosoftDocumentation.Core.Framework.Driver;
    using MicrosoftDocumentation.Core.Framework.Elements;
    using OpenQA.Selenium;

    public class SeleniumWebPageScroller : IWebPageScroller
    {
        private readonly IWebDriver driver;

        public SeleniumWebPageScroller(IWebDriver driver)
        {
            this.driver = driver ?? throw new ArgumentNullException(nameof(driver));
        }

        public void ScrollPageToElement(string executableScript, IWebPageElement element)
        {
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)this.driver;
            jsExecutor.ExecuteScript(executableScript, element);
        }
    }
}
