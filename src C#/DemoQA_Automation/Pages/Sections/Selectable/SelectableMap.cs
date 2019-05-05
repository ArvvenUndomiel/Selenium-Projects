namespace DemoQA_Automation.Pages.Sections.Selectable
{
    using OpenQA.Selenium;

    public partial class Selectable
    {
        public IWebElement Item1 => Wait.
            Until(d => { return d.FindElement(By.XPath("//*[@id='selectable']/li[1]")); });

        public IWebElement Item2 => Wait.
            Until(d => { return d.FindElement(By.XPath("//*[@id='selectable']/li[2]")); });

        public IWebElement Item3 => Wait.
            Until(d => { return d.FindElement(By.XPath("//*[@id='selectable']/li[3]")); });

        public IWebElement Item4 => Wait.
            Until(d => { return d.FindElement(By.XPath("//*[@id='selectable']/li[4]")); });

        public IWebElement Item5 => Wait.
            Until(d => { return d.FindElement(By.XPath("//*[@id='selectable']/li[5]")); });

        public IWebElement Item6 => Wait.
            Until(d => { return d.FindElement(By.XPath("//*[@id='selectable']/li[6]")); });

        public IWebElement Item7 => Wait.
            Until(d => { return d.FindElement(By.XPath("//*[@id='selectable']/li[7]")); });
    }
}
