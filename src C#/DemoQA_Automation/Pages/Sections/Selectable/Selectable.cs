namespace DemoQA_Automation.Pages.Sections.Selectable
{
    using OpenQA.Selenium;

    public partial class Selectable : BasePage
    {
        public Selectable(IWebDriver driver) : base(driver)
        {}

        public bool NormalColor_ShouldBeWhite(IWebElement element)
        {
            string initialColor = element.GetCssValue("background-color");
            return "rgba(255, 255, 255, 1)" == initialColor;
        }

        public bool OnClick_ColorShouldBecomeOrange(IWebElement element)
        {
            string changeColor = element.GetCssValue("background-color");
            return "rgba(243, 152, 20, 1)" == changeColor;
        }
    }
}
