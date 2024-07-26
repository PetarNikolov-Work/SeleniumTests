namespace MicrosoftDocumentation.Selenium.Implementation.Driver
{
    using MicrosoftDocumentation.Core.Framework.Driver;
    using MicrosoftDocumentation.Core.Framework.Elements;
    using MicrosoftDocumentation.Core.Framework.Models;
    using MicrosoftDocumentation.Selenium.Implementation.Driver.Abstractions;
    using MicrosoftDocumentation.Selenium.Implementation.Elements;
    using MicrosoftDocumentation.Selenium.Implementation.Utilities;
    using OpenQA.Selenium;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public class SeleniumWebPageElementFinder : BaseSeleniumWebDriver, IWebPageElementFinder
    {
        private SeleniumWebPageElementFinder(IWebDriver driver)
            : base(driver)
        {
            
        }

        public IWebPageElement FindElement(Locator locator)
        {
            IWebElement element = base.Driver.FindElement(LocatorIdentifier.IdentifyLocator(locator));
            return SeleniumWebPageElement.Create(element);
        }

        public IEnumerable<IWebPageElement> FindElements(Locator locator)
        {
            ReadOnlyCollection<IWebElement> elements = base.Driver.FindElements(LocatorIdentifier.IdentifyLocator(locator));
            foreach (IWebElement element in elements)
            {
                yield return SeleniumWebPageElement.Create(element);
            }
        }

        public static SeleniumWebPageElementFinder Create(IWebDriver driver)
        {
            return new SeleniumWebPageElementFinder(driver);
        }
    }
}
