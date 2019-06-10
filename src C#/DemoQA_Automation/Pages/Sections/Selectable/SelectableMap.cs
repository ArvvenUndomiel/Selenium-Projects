namespace DemoQA_Automation.Pages.Sections.Selectable
{
    using OpenQA.Selenium;
    using System.Collections.Generic;

    public partial class Selectable
    {

        /// <summary>
        /// This method will return a List of all Items on the page.
        /// </summary>
        /// <returns></returns>
        public List<IWebElement> GetAllItems()
        {
            return new List<IWebElement>(Wait.Until(d => { return d.FindElements(By.XPath("//*[@id='selectable']/li")); }));
        }
    }
}
