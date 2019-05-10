namespace DemoQA_Automation.Pages.Sections.Droppable
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Interactions;

    public partial class Droppable
    {
        public Actions builder => new Actions(Driver);

        public IWebElement Box => Wait.
            Until(d => { return d.FindElement(By.Id("draggable")); });

        public IWebElement Target => Wait.
            Until(d => { return d.FindElement(By.Id("droppable")); });
    }
}
