namespace DemoQA_Automation.WidgetTests
{
    using DemoQA_Automation.Pages.Widgets.Accordion;
    using NUnit.Framework;

    [TestFixture]
    public class AccordionTests : TestsBase
    {
        private Accordion Accordion;

        [SetUp]
        public void SetUp()
        {
            Accordion = new Accordion(driver);
            HomePage.AccordionButton.Click();
        }

        [Test]
        public void AccordionWidget_CanBeAccessed()
        {
            string heading = HomePage.GetSectionHeading();
            string url = HomePage.GetSectionURL();

            Assert.That(heading == "Accordion");
            Assert.That(url == "https://demoqa.com/accordion/");
        }

        [Test]
        public void AccordionFunctionality_WorksAsExpected()
        {

        }
    }
}
