namespace DemoQA_Automation.WidgetTests
{
    using DemoQA_Automation.Pages;
    using DemoQA_Automation.Pages.Widgets.DatePicker;
    using NUnit.Framework;
    using System;
    using System.Globalization;

    [TestFixture]
    public class DatePickerTests : TestsBase
    {
        private DatePicker DatePicker;

        [SetUp]
        public void SetUp()
        {
            DatePicker = new DatePicker(driver);
            HomePage.DatePickerButton.Click();
        }

        [Test]
        public void DatePickerWidget_CanBeAccessed()
        {
            string heading = HomePage.GetSectionHeading();
            string url = HomePage.GetSectionURL();

            Assert.That(heading == "Datepicker");
            Assert.That(url == "https://demoqa.com/datepicker/");
        }

        [Test]
        public void CalendarShowsTodaysDate_AndIsHighlighted()
        {
            var currentDate = DatePicker.GetCurrentDate().Date;
            var calendarDate = DatePicker.GetDateFromCalendar().Date;

            Assert.AreEqual(currentDate, calendarDate);

        }

        [TestCase ("August 2, 2020")]
        [TestCase ("17 September 2019")]
        [TestCase ("01 January 2015")]
        [Test]
        public void ChooseADate_ShouldSelectDateFromCalendar(string date)
        {
            // Choose a date in format: dd/MM/yyyy
            string changedDate = DatePicker.ChooseADate(date);
            

            //DateTime expectedDate = DateTime.ParseExact
            
            Assert.AreEqual(changedDate,expectedDate);
        }

    }
}
