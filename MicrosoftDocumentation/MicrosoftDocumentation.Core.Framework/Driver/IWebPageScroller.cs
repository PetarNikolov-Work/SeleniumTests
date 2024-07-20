namespace MicrosoftDocumentation.Core.Framework.Driver
{
    public interface IWebPageScroller<T>
    {
        void ScrollPageToElement(string executableScript, T element);
    }
}
