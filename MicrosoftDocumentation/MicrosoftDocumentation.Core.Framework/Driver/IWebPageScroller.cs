namespace MicrosoftDocumentation.Core.Framework.Driver
{
    using MicrosoftDocumentation.Core.Framework.Elements;
    public interface IWebPageScroller
    {
        void ScrollPageToElement(string executableScript, IWebPageElement element);
    }
}
