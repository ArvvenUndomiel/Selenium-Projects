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
            HomePage.SelectableButton.Click();
        }

        [Test]
        public void SelectableSection_CanBeAccessed()
        {
            string heading = HomePage.GetSectionHeading();
            string url = HomePage.GetSectionURL();

            Assert.That("Selectable" == heading);
            Assert.That("https://demoqa.com/selectable/" == url);
        }

        [Test]
        public void SelectableSection_OnSelectionItemsChangeColor()
        {
            var items = Selectable.GetAllItems();
            foreach (var item in items)
            {
                item.Click();
                Assert.That(Selectable.OnClick_ColorShouldBecomeOrange(item));
            }           
        }
    }
}
