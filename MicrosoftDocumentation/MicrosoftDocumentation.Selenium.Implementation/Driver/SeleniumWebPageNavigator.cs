namespace MicrosoftDocumentation.Selenium.Implementation.Driver
{
    using MicrosoftDocumentation.Core.Framework.Driver;
    using OpenQA.Selenium;
    using System.Xml.Linq;

    public class SeleniumWebPageNavigator : IWebPageNavigator
    {
        private readonly IWebDriver driver;

        public SeleniumWebPageNavigator(IWebDriver driver)
        {
            this.driver = driver ?? throw new ArgumentNullException(nameof(driver));
        }

        public string CurrentUrl
        {
            get
            {
                return this.driver.Url;
            }
        }

        public void NavigateToPage(string pageUrl)
        {
            if (string.IsNullOrEmpty(pageUrl) || string.IsNullOrWhiteSpace(pageUrl))
            {
                throw new ArgumentException($"'{nameof(pageUrl)}' cannot be null, empty or whitespace!", nameof(pageUrl));
            }

            this.driver.Navigate().GoToUrl(pageUrl);
        }
    }
}
