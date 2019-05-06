namespace DemoQA_Automation
{
    using System.IO;
    using System.Reflection;
    using NUnit.Framework;
    using OpenQA.Selenium.Chrome;
    using DemoQA_Automation.Pages;
    using DemoQA_Automation.Pages.Sections.Resizable;

    [TestFixture]
    public class ResizableTests
    {
        private ChromeDriver driver;
        private HomePage HomePage;
        private Resizable Resizable;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Manage().Window.Maximize();

            HomePage = new HomePage(driver);
            HomePage.Navigate();

            Resizable = new Resizable(driver);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void ResizableSection_CanBeAccessed()
        {
            HomePage.ResizableButton.Click();

            string title = HomePage.EntryTitle.Text;
            Assert.That("Resizable" == title);
        }

        /* Resizable Functionality - Test Scenario
         1. Expand the box with 150px to the right and to the bottom
         2. Verify that the size of the expanded box is 283x283px +-1px
          */

        [Test]
        public void ResizableFunctionality_WorksAsExpected()
        {
            HomePage.ResizableButton.Click();
            Resizable.ExpandBox(150);

            string width = Resizable.Box.GetCssValue("width");
            string height = Resizable.Box.GetCssValue("height");
            
            Assert.IsTrue(width == "283px" || width == "284px" || width == "283px");
            Assert.IsTrue(height == "283px" || height == "284px" || height == "283px");
        }
    }
}
