namespace DemoQA_Automation
{
    using DemoQA_Automation.Pages;
    using DemoQA_Automation.Pages.Sections.Selectable;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System.Collections.Generic;

    [TestFixture]
    public class SelectableTests : TestsBase
    {
        private Selectable Selectable;

        [SetUp]
        public void SetUp()
        {
            Selectable = new Selectable(driver);
            HomePage.SelectableButton.Click();
        }

        [Test]
        public void SelectableSection_CanBeAccessed()
        {
            string heading = HomePage.GetSectionHeading();
            string url = HomePage.GetSectionURL();

            Assert.That("Selectable" == heading);
            Assert.That("https://demoqa.com/selectable/" == url);
        }


        /*Selectable functionality - Test Scenario:
           1. Click on each item
           => Color of item changes to orange
        */


        [Test]
        public void SelectableFunctionality_WorksAsExpected()
        {
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
