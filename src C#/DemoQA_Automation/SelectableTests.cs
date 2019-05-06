namespace DemoQA_Automation
{
    using DemoQA_Automation.Pages;
    using DemoQA_Automation.Pages.Sections.Selectable;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using System.Collections.Generic;
    using System.IO;
    using System.Reflection;

    [TestFixture]
    public class SelectableTests
    {
        private ChromeDriver driver;
        private HomePage HomePage;
        private Selectable Selectable;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Manage().Window.Maximize();
            HomePage = new HomePage(driver);
            HomePage.Navigate();

            Selectable = new Selectable(driver);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void SelectableSection_CanBeAccessed()
        {
            HomePage.SelectableButton.Click();

            string title = HomePage.EntryTitle.Text;

            Assert.That("Selectable" == title);
        }


        /*Selectable functionality - Test Scenario:
           1. Click on each item
           => Color of item changes to orange
        */


        [Test]
        public void SelectableFunctionality_WorksAsExpected()
        {
            HomePage.SelectableButton.Click();

            var selectables = this.GetAllSelectables();
            foreach (var element in selectables)
            {
                element.Click();
                Assert.That(Selectable.OnClick_ColorShouldBecomeOrange(element));
            }            
        }


        private IEnumerable<IWebElement> GetAllSelectables()
        {
            return new List<IWebElement>
            {
                Selectable.Item1,
                Selectable.Item2,
                Selectable.Item3,
                Selectable.Item4,
                Selectable.Item5,
                Selectable.Item6,
                Selectable.Item7,
            };
        }
    }
}
