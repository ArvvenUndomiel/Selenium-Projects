namespace DemoQA_Automation.SectionTests
{
    using DemoQA_Automation.Pages;
    using DemoQA_Automation.Pages.Sections.Selectable;
    using NUnit.Framework;

    [TestFixture]
    public class SelectableTests : TestsBase
    {
        private Selectable Selectable;

        [SetUp]
        public void SetUp()
        {
            Selectable = new Selectable(driver);
            HomePage.OpenSection("Selectable");
        }

        [Test]
        [Category("Smoke")]
        public void SelectableSection_CanBeAccessed()
        {
            bool sectionIsLoaded = HomePage
                .VerifySection("Selectable", "https://demoqa.com/selectable/");
            Assert.IsTrue(sectionIsLoaded);
        }

        [Test]
        public void SelectableSection_OnSelectionItemsChangeColor()
        {
            var items = Selectable.GetAllItems();
            foreach (var item in items)
            {
                item.Click();
                Assert.That(Selectable.OnClick_ColorShouldBecomeOrange(item), "Item does not change color as expected");
            }           
        }
    }
}
