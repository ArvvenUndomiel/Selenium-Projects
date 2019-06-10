namespace DemoQA_Automation.Pages.Widgets.Spinner
{
    using OpenQA.Selenium;

    public partial class Spinner : BasePage
    {
        public Spinner(IWebDriver driver) : base(driver)
        { }

        public int SetValueTo5()
        {
            this.SetValueTo5Button.Click();
            return GetValueFromSpinnerField();
        }

        public bool IsElementEnabled(IWebElement element)
        {
            return element.Enabled;
        }

        public int GetValueFromSpinnerField()
        {
            return int.Parse(this.SpinnerField.GetAttribute("aria-valuenow"));
        }

        /// <summary>
        /// This method will click on the arrow as many times as specified.
        /// Allowed values for arrow: "up" and "down".
        /// </summary>
        /// <param name="arrow"></param>
        /// <param name="numberOfTimes"></param>
        public void ClickOnArrow(string arrow, int numberOfTimes)
        {
            if (arrow == "up")
            {
                for (int i = 1; i <= numberOfTimes; i++)
                {
                    this.UpArrow.Click();
                }
            }
            else if (arrow == "down")
            {
                for (int i = 1; i <= numberOfTimes; i++)
                {
                    this.DownArrow.Click();
                }
            }
        }

        /// <summary>
        /// This method will press the arrows on the keyboard as many times as specified.
        /// Allowed values for arrow: "up" and "down".
        /// </summary>
        /// <param name="arrow"></param>
        /// <param name="numberOfTimes"></param>
        public void PressArrowOnKeyboard(string arrow, int numberOfTimes)
        {
            if (arrow == "up")
            {
                for (int i = 1; i <= numberOfTimes; i++)
                {
                    this.SpinnerField.SendKeys(Keys.ArrowUp);
                }
            }
            else if (arrow == "down")
            {
                for (int i = 1; i <= numberOfTimes; i++)
                {
                    this.SpinnerField.SendKeys(Keys.ArrowDown);
                }
            }
        }

        public void TypeIntoField(string number)
        {
            this.SpinnerField.SendKeys(number);
        }

        /// <summary>
        /// Allowed values: "Toggle disable/enable", "Toggle widget" and "Get value"
        /// </summary>
        /// <param name="buttonName"></param>
        public void ClickonButton(string buttonName)
        {
            if (buttonName == "Toggle disable/enable")
            {
                this.DisableButton.Click();
            }
            else if(buttonName == "Toggle widget")
            {
                this.DestroyButton.Click();
            }
            else if(buttonName == "Get value")
            {
                this.GetValueButton.Click();
            }
        }
    }
}
