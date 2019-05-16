namespace DemoQA_Automation.Pages.Widgets.Spinner
{
    using OpenQA.Selenium;

    public partial class Spinner
    {
        public IWebElement SetValueTo5 => Wait.
            Until(d => { return d.FindElement(By.Id("setvalue")); });

        public IWebElement UpArrow => Wait.
            Until(d => { return d.FindElement(By.XPath("//*[@id='content']/div[2]/p[1]/span/a[1]/span[1]")); });

        public IWebElement DownArrow => Wait.
            Until(d => { return d.FindElement(By.XPath("//*[@id='content']/div[2]/p[1]/span/a[2]/span[1]")); });

        public IWebElement SpinnerField => Wait.
            Until(d => { return d.FindElement(By.Id("spinner")); });
    }
}
