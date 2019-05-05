namespace DemoQA_Automation
{
    using System.IO;
    using System.Reflection;
    using NUnit.Framework;
    using OpenQA.Selenium.Chrome;
    using DemoQA_Automation.Pages;
    using DemoQA_Automation.Pages.Sections.Sortable;

    [TestFixture]
    public class SortableTests
    {
        private ChromeDriver driver;
        private HomePage HomePage;
        private Sortable Sortable;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Manage().Window.Maximize();
            HomePage = new HomePage(driver);
            HomePage.Navigate();

            Sortable = new Sortable(driver);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void SortableSection_CanBeAccessed()
        {
            HomePage.SortableButton.Click();

            string title = HomePage.EntryTitle.Text;
            Assert.That("Sortable" == title);
        }

        /*Sortable Functionality - Test Scenario: 
            1. Item 2 to be moved below Item 5
            2. Item 6 to be moved above Item 1
            3. Item 7 to be moved between Item 5 and 2 */

        [Test]
        public void SortableSection_WorksAsExpected()
        {
            HomePage.SortableButton.Click();
            Sortable.builder.DragAndDropToOffset(Sortable.Item2, 0, 125).Perform();
            Sortable.builder.DragAndDropToOffset(Sortable.Item6, 0, -185).Perform();
            Sortable.builder.DragAndDropToOffset(Sortable.Item7, 0, -50).Perform();

            string firstItem = Sortable.Item1.Text;
            string sixthItem = Sortable.Item6.Text;
            string seventhItem = Sortable.Item7.Text;

            Assert.That("Item 6" == firstItem);
            Assert.That("Item 7" == sixthItem);
            Assert.That("Item 2" == seventhItem);
        }
    }
}
