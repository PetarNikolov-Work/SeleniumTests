namespace MicrosoftDocumentation.Selenium.Implementation.Driver
{
    using MicrosoftDocumentation.Core.Framework.Driver;
    using NUnit.Framework.Interfaces;
    using NUnit.Framework;
    using OpenQA.Selenium;

    public class SeleniumScreenshotManager : IScreenshotManager
    {
        private readonly IWebDriver driver;
        public SeleniumScreenshotManager(IWebDriver driver)
        {
            this.driver = driver ?? throw new ArgumentNullException(nameof(driver));
        }

        public void TakeScreenshotForFailedTest()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                Screenshot screenshot = ((ITakesScreenshot)this.driver).GetScreenshot();
                string directoryPath = @"..\..\..\Screenshots\";

                if (!System.IO.Directory.Exists(directoryPath))
                {
                    System.IO.Directory.CreateDirectory(directoryPath);
                }

                string testFile = directoryPath + TestContext.CurrentContext.Test.Name + ".png";

                screenshot.SaveAsFile(testFile);
            }
        }
    }
}
