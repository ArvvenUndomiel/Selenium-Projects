namespace DemoQA_Automation.SectionTests
{
    using NUnit.Framework;
    using DemoQA_Automation.Pages;
    using DemoQA_Automation.Pages.Sections.Draggable;
    using System.Drawing;

    [TestFixture]
    public class DraggableTests : TestsBase
    {
        private Draggable Draggable;
        
        [SetUp]
        public void SetUp()
        {
            Draggable = new Draggable(driver);
            HomePage.OpenSection("Draggable");
        }

        [Test]
        public void DraggableSection_CanBeAccessed()
        {
            bool sectionIsLoaded = HomePage
                .VerifySection("Draggable", "https://demoqa.com/draggable/");
            Assert.IsTrue(sectionIsLoaded);
        }


        [Test]
        public void DraggableSection_BoxCanBeDragged()
        {
            Point initialCoordinates = Draggable.GetBoxLocationOnPage();

            Draggable.DragBox(150, 150);

            Point newCoordinates = Draggable.GetBoxLocationOnPage();

            Assert.That(initialCoordinates.X < newCoordinates.X);
            Assert.That(initialCoordinates.Y < newCoordinates.Y);

        }

    }
}
