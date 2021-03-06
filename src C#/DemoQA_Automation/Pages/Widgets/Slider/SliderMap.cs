﻿namespace DemoQA_Automation.Pages.Widgets.Slider
{
    using OpenQA.Selenium;

    public partial class Slider
    {
        private IWebElement SliderHandle => Wait.
            Until(d => { return d.FindElement(By.XPath("//*[@id='slider']/span")); });
    }
}
