namespace MicrosoftDocumentation.Selenium.Implementation.Driver.Abstractions
{
    using OpenQA.Selenium;
    using System;

    public abstract class BaseSeleniumWebDriver
    {
        private readonly IWebDriver driver;
        public BaseSeleniumWebDriver(IWebDriver driver)
        {
            this.driver = driver ?? throw new ArgumentNullException(nameof(driver));
        }

        protected IWebDriver Driver 
        { 
            get 
            { 
                return this.driver; 
            } 
        }
    }
}
