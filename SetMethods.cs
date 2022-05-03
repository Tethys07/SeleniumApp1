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
        public static void SetText(string element, string value, SelectorType selector)
        {
            if (selector == SelectorType.Id)
                DriverHelper.driver.FindElement(By.Id(element)).SendKeys(value);
            if (selector == SelectorType.Name)
                DriverHelper.driver.FindElement(By.Name(element)).SendKeys(value);

        }

        //click button, checkbox, option, etc
        public static void Click(string element, SelectorType selector)
        {
            if (selector == SelectorType.Id)
                DriverHelper.driver.FindElement(By.Id(element)).Click();
            if (selector == SelectorType.Name)
                DriverHelper.driver.FindElement(By.Name(element)).Click();

        }

        //select dropdown
        public static void SelectDropDown(string element, string value, SelectorType selector)
        {
            //SelectElement selectElement = new SelectElement();

            if (selector == SelectorType.Id)
               new SelectElement(DriverHelper.driver.FindElement(By.Id(element))).SelectByText(value);
            if (selector == SelectorType.Name)
               new SelectElement(DriverHelper.driver.FindElement(By.Name(element))).SelectByText(value);
        }



    }
}
