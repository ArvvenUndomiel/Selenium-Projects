namespace DemoQA_Automation.Pages.Widgets.ToolTip
{
    using OpenQA.Selenium;

    public partial class ToolTip : BasePage
    {
        public ToolTip(IWebDriver driver) : base(driver)
        {}

        public string GetTextofInputField()
        {
            return this.InputField.GetAttribute("title");
        }
    }
}
