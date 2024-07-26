namespace MicrosoftDocumentation.Selenium.Implementation.Driver
{
    using MicrosoftDocumentation.Selenium.Implementation.Driver.Abstractions;
    using MicrosoftDocumentation.Core.Framework.Driver;
    using MicrosoftDocumentation.Core.Framework.Elements;
    using OpenQA.Selenium;

    public class SeleniumWebPageScroller : BaseSeleniumWebDriver, IWebPageScroller
    {
        private SeleniumWebPageScroller(IWebDriver driver)
            : base(driver) 
        {
            
        }

        public void ScrollPageToElement(string executableScript, IWebPageElement element)
        {
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)base.Driver;
            jsExecutor.ExecuteScript(executableScript, element);
        }

        public static SeleniumWebPageScroller Create(IWebDriver driver)
        {
            return new SeleniumWebPageScroller(driver);
        }
    }
}
