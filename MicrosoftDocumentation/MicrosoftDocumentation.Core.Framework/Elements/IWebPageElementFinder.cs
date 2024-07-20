namespace MicrosoftDocumentation.Core.Framework.Elements
{
    public interface IWebPageElementFinder
    {
        IWebPageElement FindElement(Locator locator);

        IEnumerable<IWebPageElement> FindElements(Locator locator);
    }
}
