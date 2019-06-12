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
            HomePage.OpenSection("Slider");
        }

        [Test]
        public void SliderWidget_CanBeAccessed()
        {
            bool sectionIsLoaded = HomePage
                .VerifySection("Slider", "https://demoqa.com/slider/");
            Assert.IsTrue(sectionIsLoaded);
        }

        [Test]
        public void SliderHandle_CanSlideLeftAndRight()
        {
            Slider.SlideHandle(240);
            int position = Slider.GetHandlePosition();
            Assert.That(position > 0);

            Slider.SlideHandle(-100);
            int newPosition = Slider.GetHandlePosition();
            Assert.That(newPosition < position);
        }
    }
}
