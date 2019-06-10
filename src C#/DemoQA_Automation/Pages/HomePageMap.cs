namespace DemoQA_Automation.Pages
{
    using OpenQA.Selenium;

    public partial class HomePage
    {
        public IWebElement EntryTitle => Wait.
            Until(d => { return d.FindElement(By.ClassName("entry-title")); });

        //SideBar Nav Buttons

        public IWebElement SortableButton => Wait.
            Until(d => { return d.FindElement(By.LinkText("Sortable")); });

        public IWebElement SelectableButton => Wait.
            Until(d => { return d.FindElement(By.LinkText("Selectable")); });

        public IWebElement ResizableButton => Wait.
            Until(d => { return d.FindElement(By.LinkText("Resizable")); });

        public IWebElement DroppableButton => Wait.
            Until(d => { return d.FindElement(By.LinkText("Droppable")); });

        public IWebElement DraggableButton => Wait.
            Until(d => { return d.FindElement(By.LinkText("Draggable")); });

        public IWebElement ToolTipButton => Wait.
            Until(d => { return d.FindElement(By.LinkText("Tooltip")); });

        public IWebElement TabsButton => Wait.
            Until(d => { return d.FindElement(By.LinkText("Tabs")); });

        public IWebElement SpinnerButton => Wait.
            Until(d => { return d.FindElement(By.LinkText("Spinner")); });

        public IWebElement SliderButton => Wait.
            Until(d => { return d.FindElement(By.LinkText("Slider")); });

        public IWebElement DatePickerButton => Wait.
            Until(d => { return d.FindElement(By.LinkText("Datepicker")); });

        public IWebElement AccordionButton => Wait.
            Until(d => { return d.FindElement(By.LinkText("Accordion")); });

    }
}
