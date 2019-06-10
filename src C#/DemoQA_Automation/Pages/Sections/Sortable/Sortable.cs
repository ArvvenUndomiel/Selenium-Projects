namespace DemoQA_Automation.Pages.Sections.Sortable
{
    using OpenQA.Selenium;
    using System;

    public partial class Sortable : BasePage
    {
        public Sortable(IWebDriver driver): base(driver)
        {}

        
        /// <summary>
        /// This method will Drag and Drop the item (itemNo) 
        /// and move it to item (position).
        /// </summary>
        /// <param name="itemNo"></param>
        /// <param name="position"></param>
        public void MoveItem(int itemNo, int position)
        {
            IWebElement item = this.LocateItem(itemNo);
            int pixels = this.CalculatePosition(itemNo, position);

            this.builder.DragAndDropToOffset(item, 0, pixels).Perform();
        }

        public string GetItemText(int itemNo)
        {
            return this.LocateItem(itemNo).Text;
        }

        private int CalculatePosition(int initialPosition, int finalPosition)
        {
            int pixels;
            pixels = Math.Abs(initialPosition - finalPosition) * 40;
            if ((finalPosition - initialPosition) < 0)
            {
                pixels *= -1;
            }
            return pixels;
        }

    }
}
