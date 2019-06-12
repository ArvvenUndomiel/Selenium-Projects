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
            HomePage.OpenSection("Droppable");
        }

        [Test]
        public void DroppableSection_CanBeAccessed()
        {
            bool sectionIsLoaded = HomePage
                .VerifySection("Droppable", "https://demoqa.com/droppable/");
            Assert.IsTrue(sectionIsLoaded);
        }

        [Test]
        public void DroppableSection_BoxCanBeDragAndDropped()
        {
            Droppable.DragAndDropBoxIntoTarget();

            string targetText = Droppable.GetTargetText();
            string targetColor = Droppable.GetTargetBackgroundColor();

            Assert.That("Drop here" != targetText && "Dropped!" == targetText);
            Assert.That("rgba(255, 250, 144, 1)" == targetColor);

        }
    }
}
