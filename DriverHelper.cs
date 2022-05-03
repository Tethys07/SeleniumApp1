using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace SeleniumApp1
{
    public class DriverHelper
    {
        public static IWebDriver driver { get; set; }
        public static IWebElement element { get; set; }
    
    }

    public enum SelectorType
    {
        Id,
        Name,
        LinkText,
        CssName,
        ClassName
    }


}
