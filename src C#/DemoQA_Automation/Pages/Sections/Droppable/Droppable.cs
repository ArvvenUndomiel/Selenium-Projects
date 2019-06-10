namespace DemoQA_Automation.Pages.Sections.Droppable
{
    using OpenQA.Selenium;

    public partial class Droppable : BasePage
    {
        public Droppable(IWebDriver driver) : base(driver)
        {}

        public void DragAndDropBoxIntoTarget()
        {
            this.builder.DragAndDrop(this.Box, this.Target).Perform();
        }

        public string GetTargetText()
        {
            return this.Target.Text;
        }

        public string GetTargetBackgroundColor()
        {
            return this.Target.GetCssValue("background-color");
        }
    }
}
