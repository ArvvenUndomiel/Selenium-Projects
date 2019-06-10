namespace DemoQA_Automation.Pages.Widgets.Spinner
{
    using OpenQA.Selenium;
    using System.Collections.Generic;

    public partial class Spinner
    {
        private IWebElement SetValueTo5Button => Wait.
            Until(d => { return d.FindElement(By.Id("setvalue")); });

        private IWebElement UpArrow => Wait.
            Until(d => { return d.FindElement(By.XPath("//*[@id='content']/div[2]/p[1]/span/a[1]/span[1]")); });

        private IWebElement DownArrow => Wait.
            Until(d => { return d.FindElement(By.XPath("//*[@id='content']/div[2]/p[1]/span/a[2]/span[1]")); });

        public IWebElement SpinnerField => Wait.
            Until(d => { return d.FindElement(By.Id("spinner")); });

        private IWebElement DisableButton => Wait.
            Until(d => { return d.FindElement(By.Id("disable")); });

        private IWebElement DestroyButton => Wait.
            Until(d => { return d.FindElement(By.Id("destroy")); });

        private IWebElement GetValueButton => Wait.
            Until(d => { return d.FindElement(By.Id("getvalue")); });



        public IEnumerable<IWebElement> UpArrowElement => Wait.
           Until(d => { return d.FindElements(By.XPath("//*[@id='content']/div[2]/p[1]/span/a[1]/span[1]")); });

        public IEnumerable<IWebElement> DownArrowElement => Wait.
            Until(d => { return d.FindElements(By.XPath("//*[@id='content']/div[2]/p[1]/span/a[2]/span[1]")); });

    }
}
