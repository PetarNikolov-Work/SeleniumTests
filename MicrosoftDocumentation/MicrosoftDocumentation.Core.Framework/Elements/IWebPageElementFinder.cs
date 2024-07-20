namespace MicrosoftDocumentation.Core.Framework.Elements
{
    using MicrosoftDocumentation.Core.Framework.Models;
    public interface IWebPageElementFinder
    {
        IWebPageElement FindElement(Locator locator);

        IEnumerable<IWebPageElement> FindElements(Locator locator);
    }
}
