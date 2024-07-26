namespace MicrosoftDocumentation.Selenium.Implementation.Driver
{
    using MicrosoftDocumentation.Selenium.Implementation.Driver.Abstractions;
    using MicrosoftDocumentation.Core.Framework.Driver;
    using MicrosoftDocumentation.Core.Shared.Enums;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;

    public class SeleniumWaitManager : BaseSeleniumWebDriver, IWaitManager
    {
        private SeleniumWaitManager(IWebDriver driver) 
            : base(driver)
        {
            
        }

        public void WaitPage(WaitType seconds)
        {
            WebDriverWait wait = new WebDriverWait(base.Driver, TimeSpan.FromMilliseconds((double)seconds));
            DateTime now = DateTime.Now;

            wait.Until(wd => (DateTime.Now - now) - TimeSpan.FromMilliseconds((double)seconds) > TimeSpan.Zero);
        }

        public static SeleniumWaitManager Create(IWebDriver driver)
        {
            return new SeleniumWaitManager(driver);
        }
    }
}
