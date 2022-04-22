using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumApp1
{
    public class SetMethods
    {
        //Set Text
        public static void SetText(IWebDriver driver, string element, string value, string selectorType)
        {
            if (selectorType == "Id")
                driver.FindElement(By.Id(element)).SendKeys(value);
            if (selectorType == "Name")
                driver.FindElement(By.Name(element)).SendKeys(value);

        }

        //click button, checkbox, option, etc
        public static void Click(IWebDriver driver, string element, string selectorType)
        {
            if (selectorType == "Id")
                driver.FindElement(By.Id(element)).Click();
            if (selectorType == "Name")
                driver.FindElement(By.Name(element)).Click();

        }

        //select dropdown
        public static void SelectDropDown(IWebDriver driver, string element, string value, string selectorType)
        {
            //SelectElement selectElement = new SelectElement();

            if (selectorType == "Id")
               new SelectElement(driver.FindElement(By.Id(element))).SelectByText(value);
            if (selectorType == "Name")
               new SelectElement(driver.FindElement(By.Name(element))).SelectByText(value);
        }



    }
}
