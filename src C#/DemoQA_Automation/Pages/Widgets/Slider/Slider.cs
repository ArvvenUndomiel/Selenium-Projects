namespace DemoQA_Automation.Pages.Widgets.Slider
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Interactions;
    using System.Linq;
    using System.Text.RegularExpressions;

    public partial class Slider : BasePage
    {
        public Slider(IWebDriver driver) : base(driver)
        { }

        public void SlideHandle(int pixels)
        {
            Actions builder = new Actions(Driver);

            builder.DragAndDropToOffset(this.SliderHandle, pixels, 0).Perform();
        }

        public int GetHandlePosition()
        {
            string attribute = SliderHandle.GetAttribute("style");
            string [] stringNumbers = Regex.Split(attribute, @"\D+");
            stringNumbers = stringNumbers.Where(x => !string.IsNullOrEmpty(x)).ToArray();

            int number = int.Parse(stringNumbers[0]);
            return number;
        }
    }
}
