namespace MicrosoftDocumentation.Selenium.Implementation.Elements
{
    using MicrosoftDocumentation.Core.Framework.Elements;
    using OpenQA.Selenium;

    public class SeleniumWebPageElement : IWebPageElement
    {
        private readonly IWebElement element;

        public SeleniumWebPageElement(IWebElement element)
        {
             this.element = element ?? throw new ArgumentNullException(nameof(element));   
        }

        public bool IsVisible
        {
            get
            {
                return this.element.Displayed;
            }
        }

        public string Content
        {
            get
            {
                return this.element.Text;
            }
        }

        public string TagName
        {
            get
            {
                return this.element.TagName;
            }
        }

        public void Click()
        {
            element.Click();
        }

        public string GetAttribute(string name)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException($"'{nameof(name)}' cannot be null, empty or whitespace!", nameof(name));
            }

            return element.GetAttribute(name);
        }

        public static SeleniumWebPageElement Create(IWebElement element)
        {
            return new SeleniumWebPageElement(element);
        }
    }
}
