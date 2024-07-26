namespace MicrosoftDocumentation.Selenium.Implementation.Driver
{
    using MicrosoftDocumentation.Selenium.Implementation.Driver.Abstractions;
    using MicrosoftDocumentation.Core.Framework.Driver;
    using NUnit.Framework.Interfaces;
    using NUnit.Framework;
    using OpenQA.Selenium;

    public class SeleniumScreenshotManager : BaseSeleniumWebDriver, IScreenshotManager
    {
        private SeleniumScreenshotManager(IWebDriver driver)
            : base(driver)
        {
            
        }

        public void TakeScreenshotForFailedTest()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                Screenshot screenshot = ((ITakesScreenshot)base.Driver).GetScreenshot();
                string directoryPath = @"..\..\..\Screenshots\";

                if (!System.IO.Directory.Exists(directoryPath))
                {
                    System.IO.Directory.CreateDirectory(directoryPath);
                }

                string testFile = directoryPath + TestContext.CurrentContext.Test.Name + ".png";

                screenshot.SaveAsFile(testFile);
            }
        }

        public static SeleniumScreenshotManager Create(IWebDriver driver)
        {
            return new SeleniumScreenshotManager(driver);   
        }
    }
}
