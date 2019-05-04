namespace DemoQA_Automation.Pages.Sections.Sortable
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Interactions;

    public partial class Sortable
    {
        public Actions builder => new Actions(Driver);

        public IWebElement Item1 => Wait.
            Until(d => { return d.FindElement(By.XPath("//*[@id='sortable']/li[1]")); });

        public IWebElement Item2 => Wait.
            Until(d => { return d.FindElement(By.XPath("//*[@id='sortable']/li[2]")); });

        public IWebElement Item5 => Wait.
            Until(d => { return d.FindElement(By.XPath("//*[@id='sortable']/li[5]")); });

        public IWebElement Item6 => Wait.
            Until(d => { return d.FindElement(By.XPath("//*[@id='sortable']/li[6]")); });

        public IWebElement Item7 => Wait.
            Until(d => { return d.FindElement(By.XPath("//*[@id='sortable']/li[7]")); });
    }
}
