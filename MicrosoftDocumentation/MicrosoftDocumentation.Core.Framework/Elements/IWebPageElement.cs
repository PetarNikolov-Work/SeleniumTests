namespace MicrosoftDocumentation.Core.Framework.Elements
{
    public interface IWebPageElement
    {
        bool IsVisible { get; }

        string Content { get; }

        string TagName { get; }

        string GetAttribute(string name);

        void Click();
    }
}
