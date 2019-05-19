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
            //TO DO: add exception messages;
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
        public void SpinnerUpArrow_ShouldIncrementValue_mouseTests()
        {
            int initialValue = Spinner.SetValueTo5();
            Assert.That(initialValue == 5);

            Spinner.UpArrow.Click();
            int increasedValue = Spinner.GetValueFromSpinnerField();

            Assert.That(increasedValue == initialValue + 1);
        }

        [Test]
        public void SpinnerDownArrow_ShouldDecrementValue__mouseTests()
        {
            int initialValue = Spinner.SetValueTo5();
            Assert.That(initialValue == 5);

            Spinner.DownArrow.Click();
            int decreasedValue = Spinner.GetValueFromSpinnerField();
            Assert.That(decreasedValue == initialValue - 1);

        }
        
        [Test]
        public void SpinnerUpArrow_ShouldIncrementValue_keyboardTests()
        {
            Spinner.SpinnerField.SendKeys("8");
            Spinner.PressArrowOnKeyboard("up");

            int increasedValue = Spinner.GetValueFromSpinnerField();
            Assert.That(increasedValue == 9);
        }

        [Test]
        public void SpinnerDownArrow_ShouldDecrementValue__keyboardTests()
        {
            Spinner.SpinnerField.SendKeys("1000");
            Spinner.PressArrowOnKeyboard("down");

            int decreasedValue = Spinner.GetValueFromSpinnerField();
            Assert.That(decreasedValue == 999);
        }

        [Test]
        public void SetValueTo5Button_ShouldSetCorrectValue()
        {
            int value = Spinner.SetValueTo5();
            Assert.That(value == 5);
        }

        [Test]
        public void DisableButton_ShouldDisableOrEnableSpinner()
        {
            
            Spinner.DisableButton.Click();
            bool enabled = Spinner.IsElementEnabled(Spinner.SpinnerField);
            Assert.IsFalse(enabled);

            Spinner.DisableButton.Click();
            enabled = Spinner.IsElementEnabled(Spinner.SpinnerField);
            Assert.IsTrue(enabled);
        }

        [Test]
        public void DestroyButton_ShouldRemoveOrAddSpinner()
        {
            Spinner.DestroyButton.Click();
            Assert.IsEmpty(Spinner.UpArrowCheck);
            Assert.IsEmpty(Spinner.DownArrowCheck);

            Spinner.DestroyButton.Click();
            Assert.IsNotEmpty(Spinner.UpArrowCheck);
            Assert.IsNotEmpty(Spinner.DownArrowCheck);
        }

        [Test]
        public void GetValue_ShowsCorrectValue()
        {
            Spinner.SpinnerField.SendKeys("19");
            Spinner.GetValueButton.Click();

            string text = driver.SwitchTo().Alert().Text;
            Assert.That(text == "19");

            driver.SwitchTo().Alert().Accept();
        }
    }
}
