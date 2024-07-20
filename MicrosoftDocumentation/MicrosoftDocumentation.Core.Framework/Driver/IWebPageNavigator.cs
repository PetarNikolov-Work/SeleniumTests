namespace MicrosoftDocumentation.Core.Framework.Driver
{
    public interface IWebPageNavigator
    {
        void NavigateToPage(string pageUrl);

        string CurrentUrl();
    }
}
