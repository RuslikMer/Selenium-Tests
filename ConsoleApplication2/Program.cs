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

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using (var driver = new ChromeDriver())
            {

                driver.Navigate().GoToUrl("https://club.panasonic.ru/profile/");
                driver.Manage().Window.Maximize();

                var login = driver.FindElementByXPath("/html/body/div/div[3]/div[1]/div/div[2]/a/img");
                login.Click();
                //Task.Delay(2000).Wait();
                //driver.SwitchTo().Window(driver.WindowHandles.ToList().Last());
                login = driver.FindElementByName("DIRECT_CRM_EMAIL");
                login.SendKeys("wormix@mail.ru");

                login = driver.FindElementByName("DIRECT_CRM_PASSWORD");
                login.SendKeys("1234567");
                login = driver.FindElementByXPath("/html/body/div/div[5]/aside/div/div[1]/div[1]/form/button");
                login.Click();
                Task.Delay(4000).Wait();
                //driver.Navigate().GoToUrl("https://eplaza.panasonic.ru/personal/personal_data/");
                login = driver.FindElementByXPath("/html/body/div/div[2]/div[2]/div[2]/div/div[1]/ul/li[1]/a");
                login.Click();
                //login.SendKeys("Среда Тест");

                var data = driver.FindElementByXPath("/html/body/div/div[2]/div[2]/div[2]/div/div[2]/ul[1]/li[2]/a");
                data.Click();
                //mail.SendKeys("vortex@mail.ru");
                data = driver.FindElementByName("LASTNAME");
                data.Clear();
                data.SendKeys("Среда");
                //mail.SendKeys("+79033331111");
                data = driver.FindElementByName("FIRSTNAME");
                data.Clear();
                data.SendKeys("Бар");
                //Task.Delay(2000).Wait();
                //driver.SwitchTo().Window(driver.WindowHandles.ToList().Last());

                data = driver.FindElementByName("USERNAME");
                data.Clear();
                data.SendKeys("Furion");
                data = driver.FindElementByName("EMAIL");
                data.Clear();
                data.SendKeys("wormix@mail.ru");
                data = driver.FindElementByName("CITY");
                data.Clear();
                data.SendKeys("Азгард");

               
                data = driver.FindElementByName("PHONE");
                data.Clear();
                data.SendKeys("9077774577");
                data = driver.FindElementByName("PASSWORD");
                data.SendKeys("1234567");
                data = driver.FindElementByName("CONFIRM_PASSWORD");
                data.SendKeys("1234567");
                data = driver.FindElementByXPath("/html/body/div/div[2]/div[2]/div[3]/div/div[2]/form/input[43]");
                data.Click();
                Task.Delay(10000).Wait();
                driver.SwitchTo().Window(driver.WindowHandles.ToList().Last());
                data = driver.FindElementByXPath("/html/body/div[2]/div[2]/div[1]/button");
                data.Click();
                Console.ReadKey();




            }
        }
    }
}
