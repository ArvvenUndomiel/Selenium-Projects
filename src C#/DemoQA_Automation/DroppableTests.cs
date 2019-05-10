namespace DemoQA_Automation
{
    using System.IO;
    using System.Reflection;
    using NUnit.Framework;
    using OpenQA.Selenium.Chrome;
    using DemoQA_Automation.Pages;
    using DemoQA_Automation.Pages.Sections.Droppable;
    using OpenQA.Selenium.Interactions;

    [TestFixture]
    public class DroppableTests
    {
        private ChromeDriver driver;
        private HomePage HomePage;
        private Droppable Droppable;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Manage().Window.Maximize();

            HomePage = new HomePage(driver);
            HomePage.Navigate();

            Droppable = new Droppable(driver);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void DroppableSection_CanBeAccessed()
        {
            HomePage.DroppableButton.Click();

            string title = HomePage.EntryTitle.Text;

            Assert.That("Droppable" == title);
        }

        /* Droppable Functionality - Test Scenario
         1. Drag and Drop the left box inside the right box
         => Observe the color of the right box and the text changes*/

        [Test]
        public void DroppableFunctionality_WorksAsExpected()
        {
            HomePage.DroppableButton.Click();

            Droppable.builder.DragAndDrop(Droppable.Box, Droppable.Target).Perform();

            string targetText = Droppable.Target.Text;
            string targetColor = Droppable.Target.GetCssValue("background-color");

            Assert.That("Drop here" != targetText && "Dropped!" == targetText);
            Assert.That("rgba(255, 250, 144, 1)" == targetColor);
            
        }
    }
}
