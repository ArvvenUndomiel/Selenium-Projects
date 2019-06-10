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
            HomePage.ToolTipButton.Click();
        }

        [Test]
        public void ToolTipWidget_CanBeAccessed()
        {
            string heading = HomePage.GetSectionHeading();
            string url = HomePage.GetSectionURL();

            Assert.That("Tooltip" == heading);
            Assert.That("https://demoqa.com/tooltip/" == url);
        }

        [Test]
        public void ToolTipSection_HoveringOnToolTipRevealsAMessage()
        {
            string text = ToolTip.GetTextofInputField();

            Assert.That("We ask for your age only for statistical purposes." == text);
        }

    }
}
