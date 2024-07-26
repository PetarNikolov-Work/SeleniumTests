namespace MicrosoftDocumentation.Selenium.Implementation.Elements
{
    using MicrosoftDocumentation.Core.Framework.Elements;
    using MicrosoftDocumentation.Core.Framework.Models;
    using MicrosoftDocumentation.Selenium.Implementation.Utilities;
    using OpenQA.Selenium;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    internal class SeleniumWebPageElementFinder : IWebPageElementFinder
    {
        private readonly IWebDriver driver;

        public SeleniumWebPageElementFinder(IWebDriver driver)
        {
            this.driver = driver ?? throw new ArgumentNullException(nameof(driver));
        }

        public IWebPageElement FindElement(Locator locator)
        {
            IWebElement element = this.driver.FindElement(LocatorIdentifier.IdentifyLocator(locator));
            return SeleniumWebPageElement.Create(element);
        }

        public IEnumerable<IWebPageElement> FindElements(Locator locator)
        {
            ReadOnlyCollection<IWebElement> elements = this.driver.FindElements(LocatorIdentifier.IdentifyLocator(locator));
            foreach (IWebElement element in elements)
            {
                yield return SeleniumWebPageElement.Create(element);
            }
        }
    }
}
