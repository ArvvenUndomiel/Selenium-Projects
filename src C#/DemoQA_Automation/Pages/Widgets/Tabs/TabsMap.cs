namespace DemoQA_Automation.Pages.Widgets.Tabs
{
    using OpenQA.Selenium;

    public partial class Tabs
    {
        public IWebElement LocateTab(int idNumber)
        {
            IWebElement tab = Wait.Until(d => { return d.FindElement(By.Id($"ui-id-{idNumber}")); });
            return tab;
        }

        public IWebElement LocateText(int idNumber)
        {
            IWebElement text = Wait.Until(d => { return d.FindElement(By.Id($"tabs-{idNumber}")); });
            return text;
        }
    }
}
