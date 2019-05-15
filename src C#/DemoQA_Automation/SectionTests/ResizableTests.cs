namespace DemoQA_Automation.SectionTests
{
    using NUnit.Framework;
    using DemoQA_Automation.Pages;
    using DemoQA_Automation.Pages.Sections.Resizable;

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
        public void ResizableFunctionality_WorksAsExpected()
        {
            Resizable.ExpandBox(150);

            int width = Resizable.Box.Size.Width;
            int height = Resizable.Box.Size.Height;

            Assert.IsTrue(282 <= width || 284 >= width);
            Assert.IsTrue(282 <= height || 284 >= height);
        }
    }
}
