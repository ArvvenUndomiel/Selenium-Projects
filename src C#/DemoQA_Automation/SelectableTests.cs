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
    using System.Threading;

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

        /*Selectable functionality - Test Scenario 1:
           1. Item 4's color is white
           2. Click on Item 4
           => Color of Item 4 changes to orange
        */

        [Test]
        public void SelectableFunctionality_Scenario1()
        {
            HomePage.SelectableButton.Click();

            Assert.That(Selectable.NormalColor_ShouldBeWhite(Selectable.Item4));

            Selectable.Item4.Click();

            Assert.That(Selectable.OnClick_ColorShouldBecomeOrange(Selectable.Item4));
        }

        /*Selectable functionality - Test Scenario 2:
           1. Click on Item 4
           => Color of Item 4 changes to orange
           2. Click on Item 2
           => Color of Item 4 goes back to white, color of Item 2 becomes orange
        */

            [Test]
        public void SelectableFunctionality_Scenario2()
        {
            HomePage.SelectableButton.Click();
            Selectable.Item4.Click();
            Assert.That(Selectable.OnClick_ColorShouldBecomeOrange(Selectable.Item4));

            Selectable.Item2.Click();

            Assert.That(Selectable.NormalColor_ShouldBeWhite(Selectable.Item4));
            Assert.That(Selectable.OnClick_ColorShouldBecomeOrange(Selectable.Item2));

        }

        //Scenario3


        [Test]
        public void Scenario3_Tests()
        {
            HomePage.SelectableButton.Click();

            var selectables = this.GetAllSelectables();
            foreach (var element in selectables)
            {
                element.Click();
                Thread.Sleep(2000);
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
