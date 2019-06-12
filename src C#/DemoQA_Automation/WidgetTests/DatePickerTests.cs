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
            HomePage.OpenSection("Datepicker");
        }

        [Test]
        public void DatePickerWidget_CanBeAccessed()
        {
            bool sectionIsLoaded = HomePage
                .VerifySection("Datepicker", "https://demoqa.com/datepicker/");
            Assert.IsTrue(sectionIsLoaded);
        }

        [Test]
        public void CalendarShowsTodaysDate_AndIsHighlighted()
        {
            var currentDate = DatePicker.GetCurrentDate().Date;
            var calendarDate = DatePicker.GetDateFromCalendar().Date;

            Assert.AreEqual(currentDate, calendarDate);

        }

        [TestCase ("2 August 2020")]
        [TestCase ("17 September 2019")]
        [TestCase ("1 January 2015")]
        [Test]
        public void ChooseADate_ShouldSelectDateFromCalendar(string date)
        {
            // Choose a date in format: d MMMM yyyy
            string changedDate = DatePicker.ChooseADate(date);

            var actual = DateTime.Parse(changedDate, CultureInfo.GetCultureInfo("en-US"));
            Assert.AreEqual(date, actual.ToString("d MMMM yyyy"));
        }

    }
}
