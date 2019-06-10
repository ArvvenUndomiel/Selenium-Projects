namespace DemoQA_Automation.Pages.Sections.Resizable
{
    using OpenQA.Selenium;
    using System.Drawing;

    public partial class Resizable : BasePage
    {
        public Resizable(IWebDriver driver) : base(driver)
        { }

        public Size GetBoxSize()
        {
            return this.Box.Size;
        }

        public void ExpandBox(int pixelWidth, int pixelHeight)
        {
            this.builder.DragAndDropToOffset(this.BoxHandle, pixelWidth, pixelHeight).Perform();
        }

        public void RetractBox(int pixelWidth, int pixelHeight)
        {
            pixelWidth *= -1;
            pixelHeight *= -1;
            this.builder.DragAndDropToOffset(this.BoxHandle, pixelWidth, pixelHeight).Perform();
        }
    }
}
