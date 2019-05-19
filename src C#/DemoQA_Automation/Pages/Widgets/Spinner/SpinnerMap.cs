namespace DemoQA_Automation.Pages.Widgets.Spinner
{
    using OpenQA.Selenium;
    using System.Collections.Generic;

    public partial class Spinner
    {
        public IWebElement SetValueTo5Button => Wait.
            Until(d => { return d.FindElement(By.Id("setvalue")); });

        public IWebElement UpArrow => Wait.
            Until(d => { return d.FindElement(By.XPath("//*[@id='content']/div[2]/p[1]/span/a[1]/span[1]")); });

        public IWebElement DownArrow => Wait.
            Until(d => { return d.FindElement(By.XPath("//*[@id='content']/div[2]/p[1]/span/a[2]/span[1]")); });

        public IWebElement SpinnerField => Wait.
            Until(d => { return d.FindElement(By.Id("spinner")); });

        public IWebElement DisableButton => Wait.
            Until(d => { return d.FindElement(By.Id("disable")); });

        public IWebElement DestroyButton => Wait.
            Until(d => { return d.FindElement(By.Id("destroy")); });

        public IWebElement GetValueButton => Wait.
            Until(d => { return d.FindElement(By.Id("getvalue")); });



        public IEnumerable<IWebElement> UpArrowCheck => Wait.
           Until(d => { return d.FindElements(By.XPath("//*[@id='content']/div[2]/p[1]/span/a[1]/span[1]")); });

        public IEnumerable<IWebElement> DownArrowCheck => Wait.
            Until(d => { return d.FindElements(By.XPath("//*[@id='content']/div[2]/p[1]/span/a[2]/span[1]")); });

    }
}
