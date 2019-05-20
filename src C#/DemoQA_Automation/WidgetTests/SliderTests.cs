namespace DemoQA_Automation.WidgetTests
{
    using NUnit.Framework;
    using DemoQA_Automation.Pages;
    using DemoQA_Automation.Pages.Widgets.Slider;

    [TestFixture]
    public class SliderTests : TestsBase
    {
        private Slider Slider;

        [SetUp]
        public void SetUp()
        {
            Slider = new Slider(driver);
            HomePage.SliderButton.Click();
        }

        [Test]
        public void SliderWidget_CanBeAccessed()
        {
            string heading = HomePage.GetSectionHeading();
            string url = HomePage.GetSectionURL();

            Assert.That(heading == "Slider");
            Assert.That(url == "https://demoqa.com/slider/");
        }

        [Test]
        public void SliderHandle_CanSlideLeftAndRight()
        {
            Slider.SlideHandle(240);
            int position = Slider.GetHandlePosition();
            Assert.That(position > 0);

            Slider.SlideHandle(-100);
            int newPosition = Slider.GetHandlePosition();
            
        }
    }
}
