namespace DemoQA_Automation.Pages
{
    using OpenQA.Selenium;

    public partial class HomePage
    {
        public IWebElement EntryTitle => Wait.
            Until(d => { return d.FindElement(By.ClassName("entry-title")); });

        //SideBar Nav Buttons

        public IWebElement SortableButton => Wait.
            Until(d => { return d.FindElement(By.XPath("//*[@id='sidebar']/aside[1]/ul/li[1]/a")); });

        public IWebElement SelectableButton => Wait.
            Until(d => { return d.FindElement(By.XPath("//*[@id='sidebar']/aside[1]/ul/li[2]/a")); });

        public IWebElement ResizableButton => Wait.
            Until(d => { return d.FindElement(By.XPath("//*[@id='sidebar']/aside[1]/ul/li[3]/a")); });

        public IWebElement DroppableButton => Wait.
            Until(d => { return d.FindElement(By.XPath("//*[@id='sidebar']/aside[1]/ul/li[4]/a")); });

        public IWebElement DraggableButton => Wait.
            Until(d => { return d.FindElement(By.XPath("//*[@id='sidebar']/aside[1]/ul/li[5]/a")); });

        public IWebElement ToolTipButton => Wait.
            Until(d => { return d.FindElement(By.XPath("//*[@id='sidebar']/aside[2]/ul/li[1]/a")); });

        public IWebElement TabsButton => Wait.
            Until(d => { return d.FindElement(By.XPath("//*[@id='sidebar']/aside[2]/ul/li[2]/a")); });

        public IWebElement SpinnerButton => Wait.
            Until(d => { return d.FindElement(By.XPath("//*[@id='sidebar']/aside[2]/ul/li[3]/a")); });

        public IWebElement SliderButton => Wait.
            Until(d => { return d.FindElement(By.XPath("//*[@id='sidebar']/aside[2]/ul/li[4]/a")); });

        public IWebElement DatePickerButton => Wait.
            Until(d => { return d.FindElement(By.XPath("//*[@id='sidebar']/aside[2]/ul/li[9]/a")); });

        public IWebElement AccordionButton => Wait.
            Until(d => { return d.FindElement(By.XPath("//*[@id='sidebar']/aside[2]/ul/li[14]/a")); });
    }
}
