namespace DemoQA_Automation.Pages.Sections.Draggable
{
    using OpenQA.Selenium;

    public partial class Draggable : BasePage
    {
        public Draggable(IWebDriver driver) : base(driver)
        {}

        public void DragBox(int x, int y)
        {
            this.builder.MoveToElement(this.Box, 0, 0).DragAndDropToOffset(this.Box, x, y).Perform();
        }
    }
}
