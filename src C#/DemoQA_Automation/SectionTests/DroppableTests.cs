namespace DemoQA_Automation.SectionTests
{
    using NUnit.Framework;
    using DemoQA_Automation.Pages;
    using DemoQA_Automation.Pages.Sections.Droppable;

    [TestFixture]
    public class DroppableTests : TestsBase
    {
        private Droppable Droppable;

        [SetUp]
        public void SetUp()
        {
            Droppable = new Droppable(driver);
            HomePage.DroppableButton.Click();
        }

        [Test]
        public void DroppableSection_CanBeAccessed()
        {
            string heading = HomePage.GetSectionHeading();
            string url = HomePage.GetSectionURL();

            Assert.That("Droppable" == heading);
            Assert.That("https://demoqa.com/droppable/" == url);
        }

        /* Droppable Functionality - Test Scenario
         1. Drag and Drop the left box inside the right box
         => Observe the color of the right box and the text changes*/

        [Test]
        public void DroppableFunctionality_WorksAsExpected()
        {
            Droppable.builder.DragAndDrop(Droppable.Box, Droppable.Target).Perform();

            string targetText = Droppable.Target.Text;
            string targetColor = Droppable.Target.GetCssValue("background-color");

            Assert.That("Drop here" != targetText && "Dropped!" == targetText);
            Assert.That("rgba(255, 250, 144, 1)" == targetColor);
            
        }
    }
}
