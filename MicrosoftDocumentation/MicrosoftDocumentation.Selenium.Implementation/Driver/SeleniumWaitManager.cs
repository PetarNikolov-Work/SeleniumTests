namespace MicrosoftDocumentation.Selenium.Implementation.Driver
{
    using MicrosoftDocumentation.Core.Framework.Driver;
    using MicrosoftDocumentation.Core.Shared.Enums;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;

    public class SeleniumWaitManager : IWaitManager
    {
        private readonly IWebDriver driver;
        public SeleniumWaitManager(IWebDriver driver) 
        {
            this.driver = driver ?? throw new ArgumentNullException(nameof(driver));
        }

        public void WaitPage(WaitType seconds)
        {
            WebDriverWait wait = new WebDriverWait(this.driver, TimeSpan.FromMilliseconds((double)seconds));
            DateTime now = DateTime.Now;

            wait.Until(wd => (DateTime.Now - now) - TimeSpan.FromMilliseconds((double)seconds) > TimeSpan.Zero);
        }
    }
}
