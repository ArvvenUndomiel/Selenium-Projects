namespace DemoQA_Automation.SectionTests
{
    using NUnit.Framework;
    using DemoQA_Automation.Pages;
    using DemoQA_Automation.Pages.Sections.Draggable;

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

        /*Draggable Functionality - Test Scenario
         1. Drag the box 150px to the left and 150px to the bottom
         => Verify the new location of the box
        */

        [Test]
        public void DraggableSection_BoxCanBeDragged()
        {
            Draggable.DragBox(150, 150);

            int X = Draggable.Box.Location.X;
            int Y = Draggable.Box.Location.Y;

            Assert.That(636 <= X || 638 >= X);
            Assert.That(468 <= Y || 470 >= Y);
        }

    }
}
