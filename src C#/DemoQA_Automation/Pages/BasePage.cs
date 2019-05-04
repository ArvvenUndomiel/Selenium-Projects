namespace DemoQA_Automation.Pages
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;
    using System;

    public abstract class BasePage
    {
        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; }
        public WebDriverWait Wait => new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        public string BaseUrl => "https://demoqa.com/";
    }
}
