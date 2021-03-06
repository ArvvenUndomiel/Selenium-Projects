﻿namespace DemoQA_Automation.Pages.Sections.Draggable
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Interactions;

    public partial class Draggable
    {
        private Actions builder => new Actions(Driver);

        private IWebElement Box => Wait.
            Until(d => { return d.FindElement(By.Id("draggable")); });
    }
}
