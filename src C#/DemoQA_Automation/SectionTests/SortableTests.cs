namespace DemoQA_Automation.SectionTests
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
            HomePage.OpenSection("Sortable");
        }

        [Test]
        [Category("Smoke")]
        public void SortableSection_CanBeAccessed()
        {
            bool sectionIsLoaded = HomePage
                .VerifySection("Sortable", "https://demoqa.com/sortable/");
            Assert.IsTrue(sectionIsLoaded);
        }

        [Test]
        public void SortableSection_ItemsCanBeSorted()
        {
            Sortable.MoveItem(2, 3);

            string thirdItem = Sortable.GetItemText(3);
            Assert.That(thirdItem == "Item 2", "Item 2 is not on position 3");

            Sortable.MoveItem(6, 1);

            string firstItem = Sortable.GetItemText(1);
            Assert.That(firstItem == "Item 6", "Item 6 is not on position 1");

            Sortable.MoveItem(7, 5);
            string fifthItem = Sortable.GetItemText(5);
            Assert.That(fifthItem == "Item 7", "Item 7 is not on position 5");
        }
    }
}
