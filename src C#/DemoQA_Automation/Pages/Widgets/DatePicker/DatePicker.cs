namespace DemoQA_Automation.Pages.Widgets.DatePicker
{
    using OpenQA.Selenium;
    using System;
    using System.Collections.Generic;

    public partial class DatePicker : BasePage
    {
        public DatePicker(IWebDriver driver) : base(driver)
        { }

        public DateTime GetCurrentDate()
        {
            return DateTime.Now;
        }

        public DateTime GetDateFromCalendar()
        {
            datePicker.Click();
            string month = calendarMonth.Text;
            string year = calendarYear.Text;
            string day = highlightedDay.Text;
            string stringDate = $"{month} {day}, {year}";

            DateTime calendarDate = DateTime.Parse(stringDate);
            return calendarDate;
        }

        public string ChooseADate(string dateInput)
        {
            DateTime date = DateTime.Parse(dateInput);
            datePicker.Click();

            var currentDate = GetCurrentDate();

            var monthValues = new Dictionary<int, string>()
            {
                { 1, "January"},
                { 2, "February"},
                { 3, "March"},
                { 4, "April"},
                { 5, "May"},
                { 6, "June"},
                { 7, "July"},
                { 8, "August"},
                { 9, "September"},
                { 10, "October"},
                { 11, "November"},
                { 12, "December"}
            };

            string monthToBe = monthValues[date.Month];
            string yearToBe = date.Year.ToString();

            if (date.CompareTo(currentDate) > 0)
            {
                while (calendarYear.Text != yearToBe)
                {
                    this.rightArrow.Click();
                }
                while (calendarMonth.Text != monthToBe)
                {
                    this.rightArrow.Click();
                }
            }
            else if (date.CompareTo(currentDate) < 0)
            {
                while (calendarYear.Text != yearToBe)
                {
                    this.leftArrow.Click();
                }
                while (calendarMonth.Text != monthToBe)
                {
                    this.leftArrow.Click();
                }
            }

            string dayToBe = date.Day.ToString();
            string path = $"//*[@id='ui-datepicker-div']/table/tbody/tr//a[contains(text(), {dayToBe})]";

            Driver.FindElement(By.XPath(path)).Click();

            return this.datePicker.GetAttribute("value");
        }
    }
}
