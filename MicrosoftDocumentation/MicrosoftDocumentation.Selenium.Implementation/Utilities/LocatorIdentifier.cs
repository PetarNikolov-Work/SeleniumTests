namespace MicrosoftDocumentation.Selenium.Implementation.Utilities
{
    using MicrosoftDocumentation.Core.Framework.Models;
    using MicrosoftDocumentation.Core.Shared.Enums;
    using OpenQA.Selenium;
    using System;

    internal static class LocatorIdentifier
    {
        internal static By IdentifyLocator(Locator locator)
        {
            switch (locator.LocatorType)
            {
                case LocatorType.Id:
                    return By.Id(locator.Value);

                case LocatorType.Name:
                    return By.Name(locator.Value);

                case LocatorType.ClassName:
                    return By.ClassName(locator.Value);

                case LocatorType.CssSelector:
                    return By.CssSelector(locator.Value);

                case LocatorType.XPath:
                    return By.XPath(locator.Value);

                case LocatorType.TagName:
                    return By.TagName(locator.Value);

                case LocatorType.LinkText:
                    return By.LinkText(locator.Value);

                case LocatorType.PartialLinkText:
                    return By.PartialLinkText(locator.Value);

                default:
                    throw new ArgumentOutOfRangeException(locator.LocatorType.ToString());
            }
        }
    }
}
