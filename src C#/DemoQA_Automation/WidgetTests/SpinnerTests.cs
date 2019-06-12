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

            Assert.That(increasedValue == initialValue + numberofClicks);
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

            Assert.That(decreasedValue == initialValue - numberofClicks);

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
            Assert.That(increasedValue == 8 + numberOfTimes);
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
            Assert.That(decreasedValue == 1000 - numberOfTimes);
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

            Spinner.ClickonButton("Toggle disable/enable");
            bool enabled = Spinner.IsElementEnabled(Spinner.SpinnerField);
            Assert.IsFalse(enabled);

            Spinner.ClickonButton("Toggle disable/enable");
            enabled = Spinner.IsElementEnabled(Spinner.SpinnerField);
            Assert.IsTrue(enabled);
        }

        
        [Test]
        public void DestroyButton_ShouldRemoveOrAddSpinner()
        {
            Spinner.ClickonButton("Toggle widget");
            Assert.IsEmpty(Spinner.UpArrowElement);
            Assert.IsEmpty(Spinner.DownArrowElement);

            Spinner.ClickonButton("Toggle widget");
            Assert.IsNotEmpty(Spinner.UpArrowElement);
            Assert.IsNotEmpty(Spinner.DownArrowElement);
        }

        [Test]
        public void GetValue_ShowsCorrectValue()
        {
            Spinner.TypeIntoField("19");
            Spinner.ClickonButton("Get value");

            string text = driver.SwitchTo().Alert().Text;
            Assert.That(text == "19");

            driver.SwitchTo().Alert().Accept();
        }
    }
}
