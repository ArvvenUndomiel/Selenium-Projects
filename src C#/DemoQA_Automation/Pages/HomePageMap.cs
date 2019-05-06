namespace DemoQA_Automation.Pages
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Interactions;

    public partial class HomePage
    {
        public IWebElement EntryTitle => Wait.
            Until(d => { return d.FindElement(By.ClassName("entry-title")); });

        //SideBar Nav Buttons

        public IWebElement SortableButton => Wait.
            Until(d => { return d.FindElement(By.XPath("//*[@id='sidebar']/aside[1]/ul/li[1]/a")); });

        public IWebElement SelectableButton => Wait.
            Until(d => { return d.FindElement(By.XPath("//*[@id='sidebar']/aside[1]/ul/li[2]/a")); });

        public IWebElement ResizableButton => Wait.
            Until(d => { return d.FindElement(By.XPath("//*[@id='sidebar']/aside[1]/ul/li[3]/a")); });

    }
}
