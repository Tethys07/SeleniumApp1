using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support;
using SeleniumExtras.PageObjects;


namespace SeleniumApp1
{
    public class GooglePageObject
    {

        //POM
        public IWebElement search => DriverHelper.driver.FindElement(By.Name("q"));
        
        //Page Factory - deprecated
        //[FindsBy(How = How.Id, Using = "TitleId")]
        //public IWebElement TitleId { get; set; }

        //[FindsBy(How = How.Name, Using = "q")]
        //public IWebElement SearchBox { get; set; }

        public void ClickSearch() => search.SendKeys(Keys.Enter);

        public bool VerifySearchPage() => search.Displayed;


    }
}
