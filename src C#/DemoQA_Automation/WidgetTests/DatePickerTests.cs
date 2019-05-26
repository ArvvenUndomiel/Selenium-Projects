namespace DemoQA_Automation.WidgetTests
{
    using DemoQA_Automation.Pages;
    using DemoQA_Automation.Pages.Widgets.DatePicker;
    using NUnit.Framework;

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

        [Test]
        public void ChooseADate_ShouldSelectDateFromCalendar()
        {
            // Choose a date in format: dd/MM/yyyy
            string changedDate = DatePicker.ChooseADate("02 August 2020");

            //Format of output date is: mm/dd/yyyy
            Assert.True(changedDate == "08/02/2020");
        }

    }
}
