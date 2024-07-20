namespace MicrosoftDocumentation.Core.Framework.Driver
{
    public interface IWebPageNavigator
    {
        string CurrentUrl { get; }
        void NavigateToPage(string pageUrl);
    }
}
