namespace DemoQA_Automation.Pages.Widgets.Spinner
{
    using OpenQA.Selenium;

    public partial class Spinner: BasePage
    {
        public Spinner(IWebDriver driver) : base(driver)
        {}

        public int SetValueTo5()
        {
            SetValueTo5Button.Click();
            return GetValueFromSpinnerField();
        }

        public bool IsElementEnabled(IWebElement element)
        {
            return element.Enabled;
        }

        public int GetValueFromSpinnerField()
        {
            return int.Parse(SpinnerField.GetAttribute("aria-valuenow"));
        }

        public void PressArrowOnKeyboard(string direction)
        {
            if (direction == "up")
            {
                SpinnerField.SendKeys(Keys.ArrowUp);
            }
            else if (direction == "down")
            {
                SpinnerField.SendKeys(Keys.ArrowDown);
            }
        }
    }
}
