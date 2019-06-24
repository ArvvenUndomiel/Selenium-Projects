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
            HomePage.OpenSection("Spinner");
        }

        [Test]
        [Category("Smoke")]
        public void SpinnerWidget_CanBeAccessed()
        {
            bool sectionIsLoaded = HomePage
                .VerifySection("Spinner", "https://demoqa.com/spinner/");
            Assert.IsTrue(sectionIsLoaded);
        }


        [TestCase(2)]
        [TestCase(5)]
        [TestCase(10)]
        [Test]
        public void SpinnerUpArrow_ShouldIncrementValue_mouseTests(int numberofClicks)
        {
            int initialValue = Spinner.SetValueTo5();
            Assert.That(initialValue == 5);

            Spinner.ClickOnArrow("up", numberofClicks);
            int increasedValue = Spinner.GetValueFromSpinnerField();

            Assert.That(increasedValue == initialValue + numberofClicks, "Up icon cannot increment value");
        }

        [TestCase(2)]
        [TestCase(5)]
        [TestCase(10)]
        [Test]
        public void SpinnerDownArrow_ShouldDecrementValue__mouseTests(int numberofClicks)
        {
            int initialValue = Spinner.SetValueTo5();
            Assert.That(initialValue == 5);

            Spinner.ClickOnArrow("down", numberofClicks);
            int decreasedValue = Spinner.GetValueFromSpinnerField();

            Assert.That(decreasedValue == initialValue - numberofClicks, "Down icon cannot decrement value");

        }

        [TestCase(3)]
        [TestCase(1)]
        [TestCase(7)]
        [Test]
        public void SpinnerUpArrow_ShouldIncrementValue_keyboardTests(int numberOfTimes)
        {
            Spinner.TypeIntoField("8");
            Spinner.PressArrowOnKeyboard("up", numberOfTimes);

            int increasedValue = Spinner.GetValueFromSpinnerField();
            Assert.That(increasedValue == 8 + numberOfTimes, "Up arrow on keyboard does not increment value");
        }

        [TestCase(3)]
        [TestCase(1)]
        [TestCase(7)]
        [Test]
        public void SpinnerDownArrow_ShouldDecrementValue__keyboardTests(int numberOfTimes)
        {
            Spinner.TypeIntoField("1000");
            Spinner.PressArrowOnKeyboard("down", numberOfTimes);

            int decreasedValue = Spinner.GetValueFromSpinnerField();
            Assert.That(decreasedValue == 1000 - numberOfTimes, "Down arrow on keyboard does not decrement value");
        }

        
        [Test]
        public void SetValueTo5Button_ShouldSetCorrectValue()
        {
            int value = Spinner.SetValueTo5();
            Assert.That(value == 5, "Set value button does not set correct value");
        }

        
        [Test]
        public void DisableButton_ShouldDisableOrEnableSpinner()
        {

            Spinner.ClickonButton("Toggle disable/enable");
            bool enabled = Spinner.IsElementEnabled(Spinner.SpinnerField);
            Assert.IsFalse(enabled, "Spinner is not disabled as expected");

            Spinner.ClickonButton("Toggle disable/enable");
            enabled = Spinner.IsElementEnabled(Spinner.SpinnerField);
            Assert.IsTrue(enabled, "Spinner is not enabled as expected");
        }

        
        [Test]
        public void DestroyButton_ShouldRemoveOrAddSpinner()
        {
            Spinner.ClickonButton("Toggle widget");
            Assert.IsEmpty(Spinner.UpArrowElement, "Spinner up arrow does not disappear");
            Assert.IsEmpty(Spinner.DownArrowElement, "Spinner down arrow does not disappear");

            Spinner.ClickonButton("Toggle widget");
            Assert.IsNotEmpty(Spinner.UpArrowElement, "Spinner up arrow does not reappear");
            Assert.IsNotEmpty(Spinner.DownArrowElement, "Spinner down arrow does not reappear");
        }

        [Test]
        public void GetValue_ShowsCorrectValue()
        {
            Spinner.TypeIntoField("19");
            Spinner.ClickonButton("Get value");

            string text = driver.SwitchTo().Alert().Text;
            Assert.That(text == "19", "Get Value button does not show alert message properly");

            driver.SwitchTo().Alert().Accept();
        }
    }
}
