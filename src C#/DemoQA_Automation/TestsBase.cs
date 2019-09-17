namespace DemoQA_Automation
{
    using System.IO;
    using System.Reflection;
    using OpenQA.Selenium.Chrome;
    using DemoQA_Automation.Pages;
    using NUnit.Framework;

    public abstract class TestsBase
    {
        protected ChromeDriver driver;
        protected HomePage HomePage;

        [SetUp]
        public void GeneralSetUp()
        {

            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Manage().Window.Maximize();

            HomePage = new HomePage(driver);
            HomePage.Navigate();
        }

        [TearDown]
        public void TearDown() => driver.Quit();
    }
}
