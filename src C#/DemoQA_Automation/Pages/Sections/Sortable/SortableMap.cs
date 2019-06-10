namespace DemoQA_Automation.Pages.Sections.Sortable
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Interactions;

    public partial class Sortable
    {
        private Actions builder => new Actions(Driver);
            
        private IWebElement LocateItem(int itemNo) => Wait.
            Until(d => { return d.FindElement(By.XPath($"//*[@id='sortable']/li[{itemNo}]")); });

    }
}
