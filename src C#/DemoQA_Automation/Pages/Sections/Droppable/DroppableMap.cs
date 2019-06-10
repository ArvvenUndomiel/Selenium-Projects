namespace DemoQA_Automation.Pages.Sections.Droppable
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Interactions;

    public partial class Droppable
    {
        private Actions builder => new Actions(Driver);

        private IWebElement Box => Wait.
            Until(d => { return d.FindElement(By.Id("draggable")); });

        private IWebElement Target => Wait.
            Until(d => { return d.FindElement(By.Id("droppable")); });
    }
}
