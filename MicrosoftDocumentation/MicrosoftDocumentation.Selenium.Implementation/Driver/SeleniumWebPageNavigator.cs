namespace MicrosoftDocumentation.Selenium.Implementation.Driver
{
    using MicrosoftDocumentation.Selenium.Implementation.Driver.Abstractions;
    using MicrosoftDocumentation.Core.Framework.Driver;
    using OpenQA.Selenium;

    public class SeleniumWebPageNavigator : BaseSeleniumWebDriver, IWebPageNavigator
    {
        private SeleniumWebPageNavigator(IWebDriver driver)
            : base(driver)
        {
            
        }

        public string CurrentUrl
        {
            get
            {
                return base.Driver.Url;
            }
        }

        public void NavigateToPage(string pageUrl)
        {
            if (string.IsNullOrEmpty(pageUrl) || string.IsNullOrWhiteSpace(pageUrl))
            {
                throw new ArgumentException($"'{nameof(pageUrl)}' cannot be null, empty or whitespace!", nameof(pageUrl));
            }

            base.Driver.Navigate().GoToUrl(pageUrl);
        }

        public static SeleniumWebPageNavigator Create(IWebDriver driver)
        {
            return new SeleniumWebPageNavigator(driver);
        }
    }
}
