namespace DemoQA_Automation.Pages.Sections.Resizable
{
    using OpenQA.Selenium;

    public partial class Resizable
    {
        public IWebElement BoxHandle => Wait.
            Until(d => { return d.FindElement(By.XPath("//*[@id='resizable']/div[3]")); });

        public IWebElement Box => Wait.
            Until(d => { return d.FindElement(By.Id("resizable")); });
    }
}
