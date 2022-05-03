using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumApp1
{
    public class GetMethods
    {
        public static string GetText(string element, SelectorType selector)
        {
            if (selector == SelectorType.Id)
                return DriverHelper.driver.FindElement(By.Id(element)).GetAttribute("value");
            if (selector == SelectorType.Name)
                return DriverHelper.driver.FindElement(By.Name(element)).GetAttribute("value");
            else return String.Empty;

        }

        public static string GetTextFromDropDown(string element, SelectorType selector)
        {
            if (selector == SelectorType.Id)
                return new SelectElement(DriverHelper.driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            if (selector == SelectorType.Name)
                return new SelectElement(DriverHelper.driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            else return String.Empty;

        }


    }
}
