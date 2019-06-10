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
            HomePage.DraggableButton.Click();
        }

        [Test]
        public void DraggableSection_CanBeAccessed()
        {
            string heading = HomePage.GetSectionHeading();
            string url = HomePage.GetSectionURL();

            Assert.That("Draggable" == heading);
            Assert.That("https://demoqa.com/draggable/" == url);
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
