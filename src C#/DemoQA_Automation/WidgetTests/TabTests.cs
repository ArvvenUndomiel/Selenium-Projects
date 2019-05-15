namespace DemoQA_Automation.WidgetTests
{
    using DemoQA_Automation.Pages;
    using DemoQA_Automation.Pages.Widgets.Tabs;
    using NUnit.Framework;
    using OpenQA.Selenium;

    [TestFixture]
    public class TabTests : TestsBase
    {
        private Tabs Tabs;

        [SetUp]
        public void SetUp()
        {
            Tabs = new Tabs(driver);
            HomePage.TabsButton.Click();
        }

        [Test]
        public void TabsWidget_CanBeAccessed()
        {
            string heading = HomePage.GetSectionHeading();
            string url = HomePage.GetSectionURL();

            Assert.That("Tabs" == heading);
            Assert.That("https://demoqa.com/tabs/" == url);
        }

        /*Test Scenario:
         Click on each tab and verify if related text is displayed.
        */

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void TabsFunctionality_WorksAsExpected(int idNumber)
        {
            IWebElement tab = Tabs.LocateTab(idNumber);
            tab.Click();

            IWebElement text = Tabs.LocateText(idNumber);
            Assert.IsTrue(text.Displayed);
        }
    }
}
