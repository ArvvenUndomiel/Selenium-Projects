namespace DemoQA_Automation
{
    using NUnit.Framework;
    using DemoQA_Automation.Pages;
    using DemoQA_Automation.Pages.Sections.Sortable;

    [TestFixture]
    public class SortableTests : TestsBase
    {
        private Sortable Sortable;

        [SetUp]
        public void SetUp()
        {
            Sortable = new Sortable(driver);
            HomePage.SortableButton.Click();
        }

        [Test]
        public void SortableSection_CanBeAccessed()
        {
            string heading = HomePage.GetSectionHeading();
            string url = HomePage.GetSectionURL();

            Assert.That("Sortable" == heading);
            Assert.That("https://demoqa.com/sortable/" == url);
        }

        /*Sortable Functionality - Test Scenario: 
            1. Item 2 to be moved below Item 5
            2. Item 6 to be moved above Item 1
            3. Item 7 to be moved between Item 5 and 2 */

        [Test]
        public void SortableSection_WorksAsExpected()
        {
            Sortable.builder.DragAndDropToOffset(Sortable.Item2, 0, 125).Perform();
            Sortable.builder.DragAndDropToOffset(Sortable.Item6, 0, -185).Perform();
            Sortable.builder.DragAndDropToOffset(Sortable.Item7, 0, -50).Perform();

            string firstItem = Sortable.Item1.Text;
            string sixthItem = Sortable.Item6.Text;
            string seventhItem = Sortable.Item7.Text;

            Assert.That("Item 6" == firstItem);
            Assert.That("Item 7" == sixthItem);
            Assert.That("Item 2" == seventhItem);
        }
    }
}
