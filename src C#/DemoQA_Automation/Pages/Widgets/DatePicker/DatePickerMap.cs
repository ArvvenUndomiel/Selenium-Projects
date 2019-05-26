namespace DemoQA_Automation.Pages.Widgets.DatePicker
{
    using OpenQA.Selenium;

    public partial class DatePicker
    {
        private IWebElement datePicker => Wait.
            Until(d => { return d.FindElement(By.Id("datepicker")); });

        private IWebElement calendarMonth => Wait.
            Until(d => { return d.FindElement(By.ClassName("ui-datepicker-month")); });

        private IWebElement calendarYear => Wait.
            Until(d => { return d.FindElement(By.ClassName("ui-datepicker-year")); });

        private IWebElement highlightedDay => Wait.
            Until(d => { return d.FindElement(By.ClassName("ui-state-highlight")); });

        private IWebElement leftArrow => Wait.
            Until(d => { return d.FindElement(By.XPath("//*[@id='ui-datepicker-div']/div/a[1]/span")); });

        private IWebElement rightArrow => Wait.
            Until(d => { return d.FindElement(By.XPath("//*[@id='ui-datepicker-div']/div/a[2]/span")); });

    }
}
