namespace DemoQA_Automation.Pages.Sections.Resizable
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Interactions;

    public partial class Resizable : BasePage
    {
        public Resizable(IWebDriver driver) : base(driver)
        { }

        public Actions builder => new Actions(Driver);

        public void ExpandBox(int pixels)
        {
            this.builder.DragAndDropToOffset(this.BoxHandle, pixels, pixels).Perform();
        }
    }
}
