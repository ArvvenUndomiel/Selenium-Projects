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
            HomePage.OpenSection("Resizable");
        }

        [Test]
        [Category("Smoke")]
        public void ResizableSection_CanBeAccessed()
        {
            bool sectionIsLoaded = HomePage
                .VerifySection("Resizable", "https://demoqa.com/resizable/");
            Assert.IsTrue(sectionIsLoaded);
        }

        [Test]
        public void ResizableSection_BoxCanBeExpanded()
        {
            Size initialSize = Resizable.GetBoxSize();
            Resizable.ExpandBox(150, 150);

            Size expandedSize = Resizable.GetBoxSize();

            Assert.That(initialSize.Width < expandedSize.Width, "Box is not expanded correctly along X axis");
            Assert.That(initialSize.Height < expandedSize.Height, "Box is not expanded correctly along Y axis");
        }

        [Test]
        public void ResizableSection_BoxCanBeRetracted()
        {
            Resizable.ExpandBox(250, 400);
            Size expandedSize = Resizable.GetBoxSize();

            Resizable.RetractBox(150, 100);
            Size retractedSize = Resizable.GetBoxSize();

            Assert.That(retractedSize.Width < expandedSize.Width, "Box is not retracted correctly along X axis");
            Assert.That(retractedSize.Height < expandedSize.Height, "Box is not retracted correctly along Y axis");
        }
    }
}
