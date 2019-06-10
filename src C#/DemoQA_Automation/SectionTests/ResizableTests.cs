namespace DemoQA_Automation.SectionTests
{
    using NUnit.Framework;
    using DemoQA_Automation.Pages;
    using DemoQA_Automation.Pages.Sections.Resizable;
    using System.Drawing;

    [TestFixture]
    public class ResizableTests : TestsBase
    {
        private Resizable Resizable;

        [SetUp]
        public void SetUp()
        {
            Resizable = new Resizable(driver);
            HomePage.ResizableButton.Click();
        }

        [Test]
        public void ResizableSection_CanBeAccessed()
        {
            string heading = HomePage.GetSectionHeading();
            string url = HomePage.GetSectionURL();
            

            Assert.That("Resizable" == heading);
            Assert.That("https://demoqa.com/resizable/" == url);
        }

        /* Resizable Functionality - Test Scenario
         1. Expand the box with 150px to the right and to the bottom
         => Verify that the size of the expanded box is 283x283px +-1px */


        [Test]
        public void ResizableSection_BoxCanBeExpanded()
        {
            Size initialSize = Resizable.GetBoxSize();
            Resizable.ExpandBox(150, 150);

            Size expandedSize = Resizable.GetBoxSize();

            Assert.That(initialSize.Width < expandedSize.Width);
            Assert.That(initialSize.Height < expandedSize.Height);
        }

        [Test]
        public void ResizableSection_BoxCanBeRetracted()
        {
            Resizable.ExpandBox(250, 400);
            Size expandedSize = Resizable.GetBoxSize();

            Resizable.RetractBox(150, 100);
            Size retractedSize = Resizable.GetBoxSize();

            Assert.That(retractedSize.Width < expandedSize.Width);
            Assert.That(retractedSize.Height < expandedSize.Height);
        }
    }
}
