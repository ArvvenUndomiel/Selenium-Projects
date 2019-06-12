namespace DemoQA_Automation.Pages
{
    using OpenQA.Selenium;

    public partial class HomePage
    {
        private IWebElement EntryTitle => Wait.
            Until(d => { return d.FindElement(By.ClassName("entry-title")); });
    }
}
