namespace DemoQA_Automation.Pages.Widgets.ToolTip
{
    using OpenQA.Selenium;

    public partial class ToolTip
    {
        public IWebElement InputField => Wait.
            Until(d => { return d.FindElement(By.Id("age")); });        
    }
}
