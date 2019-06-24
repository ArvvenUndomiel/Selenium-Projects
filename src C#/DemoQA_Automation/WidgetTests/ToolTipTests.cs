namespace DemoQA_Automation.WidgetTests
{
    using NUnit.Framework;
    using DemoQA_Automation.Pages;
    using DemoQA_Automation.Pages.Widgets.ToolTip;

    [TestFixture]
    public class ToolTipTests : TestsBase
    {
        private ToolTip ToolTip;

        [SetUp]
        public void SetUp()
        {
            ToolTip = new ToolTip(driver);
            HomePage.OpenSection("Tooltip");
        }

        [Test]
        [Category("Smoke")]
        public void ToolTipWidget_CanBeAccessed()
        {
            bool sectionIsLoaded = HomePage
                .VerifySection("Tooltip", "https://demoqa.com/tooltip/");
            Assert.IsTrue(sectionIsLoaded);
        }

        [Test]
        public void ToolTipSection_HoveringOnToolTipRevealsAMessage()
        {
            string text = ToolTip.GetTextofInputField();

            Assert.That("We ask for your age only for statistical purposes." == text, "Tooltip message not shown properly");
        }

    }
}
