namespace DemoQA_Automation.Pages
{
    using OpenQA.Selenium;

    public partial class HomePage : BasePage
    {
        public HomePage(IWebDriver driver): base(driver)
        { }

        public void Navigate() => Driver.Navigate().GoToUrl(BaseUrl);
    }
}
