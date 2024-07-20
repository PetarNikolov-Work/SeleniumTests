namespace MicrosoftDocumentation.Core.Framework.Models
{
    using System;
    public sealed class Locator
    {
        private readonly LocatorType locatorType;
        private string value;

        private Locator(LocatorType locatorType, string value)
        {
            this.locatorType = locatorType;
            this.value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string Value
        {
            get
            {
                return this.value;
            }
        }

        public LocatorType LocatorType
        {
            get
            {
                return this.locatorType;
            }
        }

        public static Locator Create(LocatorType locatorType, string value)
        {
            return new Locator(locatorType, value);
        }
    }
}
