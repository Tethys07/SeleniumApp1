using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumApp1
{
    internal class TechListicPageObjects
    {
        public IWebElement Name => DriverHelper.driver.FindElement(By.Name("firstname"));


        public void EnterFirstName(string name)
        {
            Name.SendKeys(name);
            Name.SendKeys(Keys.Tab);
        }

        public string VerifyFirstName(string name) => DriverHelper.driver.FindElement(By.Name(name)).GetAttribute("name");

    }
}
