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
            HomePage.OpenSection("Tabs");
        }

        [Test]
        public void TabsWidget_CanBeAccessed()
        {
            bool sectionIsLoaded = HomePage
                .VerifySection("Tabs", "https://demoqa.com/tabs/");
            Assert.IsTrue(sectionIsLoaded);
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void TabsSection_TabsCanBeSelectedAndTextDisplayed(int idNumber)
        {
            IWebElement tab = Tabs.LocateTab(idNumber);
            tab.Click();

            IWebElement text = Tabs.LocateText(idNumber);
            Assert.IsTrue(text.Displayed);
        }
    }
}
