namespace DemoQA_Automation.Pages.Sections.Resizable
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Interactions;

    public partial class Resizable
    {
        private Actions builder => new Actions(Driver);

        private IWebElement BoxHandle => Wait.
            Until(d => { return d.FindElement(By.XPath("//*[@id='resizable']/div[3]")); });

        private IWebElement Box => Wait.
            Until(d => { return d.FindElement(By.Id("resizable")); });
    }
}
