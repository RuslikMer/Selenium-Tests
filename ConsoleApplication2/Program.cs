using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Drawing.Imaging;
using System.IO;
using OpenQA.Selenium.Firefox;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (var driver = new ChromeDriver())
            //{
            //    driver.Navigate().GoToUrl("http://testing-ground.scraping.pro/login");
            //    var userNameField = driver.FindElementById("usr");
            //    var userPasswordField = driver.FindElementById("pwd");
            //    var loginButton = driver.FindElementByXPath("//input[@value='Login']");
            //    userNameField.SendKeys("admin");
            //    userPasswordField.SendKeys("12345");
            //    loginButton.Click();
            //    var result = driver.FindElementByXPath("//div[@id='case_login']/h3").Text;
            //    File.WriteAllText("result.txt", result);

            //    driver.GetScreenshot().SaveAsFile(@"screen.png", ImageFormat.Png);
            //}
            using (var driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("https://eplaza.panasonic.ru/");
                Task.Delay(25000);
                var Registration = driver.FindElementByXPath("/html/body/div[1]/header/nav/div/div/ul/li[1]/a");
                Registration.Click();
                Task.Delay(5000);
                var city = driver.FindElementByXPath("//*[@id=\"person\"]/div/form/div[1]/div[1]/div[1]/a/span");
                city.Click();
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                var myCity = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"popup - location - wrapper - register\"]/div[2]/div[2]/div[1]/ul/li[1]/a")));
                //var myCity = driver.FindElementsByXPath("//*[@id=\"popup - location - wrapper - register\"]/div[2]/div[2]/div[1]/ul/li[1]/a");
                myCity.Click();
                var mail = driver.FindElementByXPath("//*[@id=\"person\"]/div/form/div[1]/div[2]/div[1]/div[2]/input");
                mail.SendKeys("rebus@mail.ru");
                mail = driver.FindElementByXPath("//*[@id=\"person\"]/div/form/div[1]/div[2]/div[2]/div[2]/input");
                mail.SendKeys("rebus123");
                mail = driver.FindElementByXPath("//*[@id=\"person\"]/div/form/div[1]/div[2]/div[3]/div[2]/input");
                mail.SendKeys("rebus123");
                mail = driver.FindElementByName("REGISTER[PERSONAL_GENDER]");
                mail.Click();
                mail = driver.FindElementByXPath("//*[@id=\"person\"]/div/form/div[1]/div[2]/div[4]/div[2]/div/div/select/option[2]");
                mail.Click();
                mail = driver.FindElementByName("REGISTER[NAME]");
                mail.SendKeys("Eplaza");
                mail = driver.FindElementByName("REGISTER[LAST_NAME]");
                mail.SendKeys("Panasonic");
                mail = driver.FindElementByName("REGISTER[PERSONAL_PHONE]");
                mail.SendKeys("79053654311");
                mail = driver.FindElementByName("day");
                mail.Click();
                mail = driver.FindElementByXPath("//*[@id=\"person\"]/div/form/div[1]/div[3]/div[4]/div[2]/div/div[1]/select/option[2]");
                mail.Click();
                mail = driver.FindElementByName("month");
                mail.Click();
                mail = driver.FindElementByXPath("//*[@id=\"person\"]/div/form/div[1]/div[3]/div[4]/div[2]/div/div[2]/select/option[2]");
                mail.Click();
                mail = driver.FindElementByName("year");
                mail.Click();
                mail = driver.FindElementByXPath("//*[@id=\"person\"]/div/form/div[1]/div[3]/div[4]/div[2]/div/div[3]/select/option[21]");
                mail.Click();
                mail = driver.FindElementByXPath("//*[@id=\"person\"]/div/form/div[2]/div[2]/label");
                mail.Click();






            }
        }
    }
}
