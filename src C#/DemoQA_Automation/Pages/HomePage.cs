namespace DemoQA_Automation.Pages
{
    using OpenQA.Selenium;

    public partial class HomePage : BasePage
    {
        public HomePage(IWebDriver driver): base(driver)
        { }

        public void Navigate() => Driver.Navigate().GoToUrl(BaseUrl);

        public void OpenSection(string sectionName)
        {
            IWebElement Section = Wait.
            Until(d => { return d.FindElement(By.LinkText($"{sectionName}")); });
            Section.Click();
        }

        public bool VerifySection(string heading, string url)
        {
            if (heading == GetSectionHeading() && url == GetSectionURL())
            {
                return true;
            }
            return false;
        }

        private string GetSectionHeading()
        {
            return this.EntryTitle.Text;
        }

        private string GetSectionURL()
        {
            return this.Driver.Url;
        }
    }
}
