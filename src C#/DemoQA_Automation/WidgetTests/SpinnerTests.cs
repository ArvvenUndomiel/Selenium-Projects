namespace DemoQA_Automation.WidgetTests
{
    using NUnit.Framework;
    using DemoQA_Automation.Pages.Widgets.Spinner;

    [TestFixture]
    public class SpinnerTests: TestsBase
    {
        private Spinner Spinner;

        [SetUp]
        public void SetUp()
        {
            Spinner = new Spinner(driver);
            HomePage.SpinnerButton.Click();
        }

        [Test]
        public void SpinnerWidget_CanBeAccessed()
        {
            string heading = HomePage.GetSectionHeading();
            string url = HomePage.GetSectionURL();

            Assert.That("Spinner" == heading);
            Assert.That("https://demoqa.com/spinner/" == url);
        }

        [Test]
        public void SpinnerUpArrow_ShouldIncrementValue()
        {
            Spinner.SetValueTo5.Click();
            int initialValue = int.Parse(Spinner.SpinnerField.GetAttribute("aria-valuenow"));
            Assert.That(initialValue == 5);
            //TO DO: add exception messages;

            Spinner.UpArrow.Click();
            int increasedValue = int.Parse(Spinner.SpinnerField.GetAttribute("aria-valuenow"));

            Assert.That(increasedValue == initialValue + 1);
        }

        [Test]
        public void SpinnerDownArrow_ShouldDecrementValue()
        {
            Spinner.SetValueTo5.Click();
            int initialValue = int.Parse(Spinner.SpinnerField.GetAttribute("aria-valuenow"));
            Assert.That(initialValue == 5);

            Spinner.DownArrow.Click();
            int decreasedValue = int.Parse(Spinner.SpinnerField.GetAttribute("aria-valuenow"));
            Assert.That(decreasedValue == initialValue - 1);

        }
        //TO DO: Refactor the methods
    }
}
