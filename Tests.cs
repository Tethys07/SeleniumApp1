//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SeleniumApp1
{
    
    
    public class Tests : DriverHelper
    {
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("https://google.com");
            Console.WriteLine("Opened browser and navigated to URL");
        }

        [TearDown]
        public void Teardown()
        {
            driver.Close();
            Console.WriteLine("Driver closed.");
        }
        
        
        [Test]        
        public void Test1()
        {
            
            //driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://google.com");
            driver.FindElement(By.Name("q")).SendKeys("Selenium Automation");
            driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
            Thread.Sleep(5000);
            //driver.Close();
            //driver.Quit();

            //Assert.Pass();

        }

        [Test]
        public void Test2()
        {
            driver.Navigate().GoToUrl("https://www.techlistic.com/p/selenium-practice-form.html");
                        
            SetMethods.SetText(driver, "firstname", "Bob", "Name");


            Thread.Sleep(5000);

        }






    }
}
