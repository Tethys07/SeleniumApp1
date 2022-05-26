using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;


namespace SeleniumApp1
{
    
    [TestFixture]
    public class UITests : DriverHelper
    {
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            Console.WriteLine("Opened Chrome browser");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [TearDown]
        public void Teardown()
        {
            driver.Close();
            Console.WriteLine("Driver closed.");
            driver.Quit();
        }
        
        
        [Test]        
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://google.com");
            driver.FindElement(By.Name("q")).SendKeys("Selenium Automation");
            driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
            Assert.IsTrue(driver.FindElement(By.CssSelector("[class~='gLFyf'][value='Selenium Automation']")).Displayed);
            
        }

        [Test]
        public void Test2()
        {
            driver.Navigate().GoToUrl("https://www.techlistic.com/p/selenium-practice-form.html");
            SetMethods.SetText("firstname", "Bob", SelectorType.Name);
            driver.FindElement(By.Name("firstname")).SendKeys(Keys.Tab);
            string fName = GetMethods.GetText("firstname", SelectorType.Name);
            Assert.AreEqual("Bob", fName);
            
        }

        [Test]
        public void TestGoogleUsingPOM()
        {
            driver.Navigate().GoToUrl("https://google.com");
            GooglePageObject page = new GooglePageObject();
            page.search.SendKeys("selenium automation");
            page.ClickSearch();
            Assert.IsTrue(page.VerifySearchPage());
            
        }

        [Test]
        public void TestTechListPOM()
        {
            //this web site does not update forms to pick up attributes
            driver.Navigate().GoToUrl("https://www.techlistic.com/p/selenium-practice-form.html");
            TechListicPageObjects page = new TechListicPageObjects();
            page.EnterFirstName("Bob");
            Assert.AreEqual("Bob", page.VerifyFirstName("Bob"));
            
        }

        [Test]
        public void SwagLabsPOM()
        {

            driver.Navigate().GoToUrl("https://www.saucedemo.com/"); //this site tries to install malware, terrible
            SauceDemoPageObjects page = new SauceDemoPageObjects();
            page.EnterFirstName("Jen");
            Assert.AreEqual(page.VerifyFirstName("Jen"), "Jen");
            Assert.Pass();

        }

        [Test]
        public void GoogleTest2()
        {
            driver.Navigate().GoToUrl("https://google.com");
            GooglePageObject g = new GooglePageObject();
            g.search.SendKeys("Automation");
            Assert.IsTrue(g.VerifySearchPage());

        }

    }
}
