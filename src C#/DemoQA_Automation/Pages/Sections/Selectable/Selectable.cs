namespace DemoQA_Automation.Pages.Sections.Selectable
{
    using OpenQA.Selenium;

    public partial class Selectable : BasePage
    {
        public Selectable(IWebDriver driver) : base(driver)
        {}

        /// <summary>
        /// This method will verify if on click the color of the element has changed to orange.
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public bool OnClick_ColorShouldBecomeOrange(IWebElement element)
        {
            string changeColor = element.GetCssValue("background-color");
            return "rgba(243, 152, 20, 1)" == changeColor;
        }
    }
}
