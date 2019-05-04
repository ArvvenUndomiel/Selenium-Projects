namespace DemoQA_Automation.Pages
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Interactions;

    public partial class HomePage
    {
        public IWebElement EntryTitle => Wait.
            Until(d => { return d.FindElement(By.ClassName("entry-title")); });

        public IWebElement SortableButton => Wait.
            Until(d => { return d.FindElement(By.XPath("//*[@id='sidebar']/aside[1]/ul/li[1]/a")); });

    }
}
