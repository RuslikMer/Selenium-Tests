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

                driver.Navigate().GoToUrl("https://eplaza.panasonic.ru/");
                driver.Manage().Window.Maximize();
                var login = driver.FindElementByXPath("/html/body/div[1]/header/nav/div/div/ul/li[2]/a");
                login.Click();
                Task.Delay(2000).Wait();
                driver.SwitchTo().Window(driver.WindowHandles.ToList().Last());
                login = driver.FindElementByName("USER_LOGIN");
                login.SendKeys("vortex@mail.ru");
               
                login = driver.FindElementByName("USER_PASSWORD");
                login.SendKeys("123456");
                login = driver.FindElementById("js_auth_button");
                login.Click();
                Task.Delay(10000).Wait();
                driver.Navigate().GoToUrl("https://eplaza.panasonic.ru/personal/personal_data/");
                login = driver.FindElementByName("NAME");
                login.Clear();
                login.SendKeys("Среда Тест");
               
                var mail = driver.FindElementByName("EMAIL");
                mail.Clear();
                mail.SendKeys("vortex@mail.ru");
                mail = driver.FindElementByName("PERSONAL_PHONE");
                mail.Clear();
                mail.SendKeys("+79033331111");
                mail = driver.FindElementByXPath("/html/body/div[1]/div/div/div/div[4]/div/div/form/div/div[7]/div[2]/span/a");
                mail.Click();
                Task.Delay(2000).Wait();
                driver.SwitchTo().Window(driver.WindowHandles.ToList().Last());
               
                mail = driver.FindElementByName("NEW_PASSWORD");
                mail.SendKeys("123456");
                mail = driver.FindElementByName("NEW_PASSWORD_CONFIRM");
                mail.SendKeys("123456");
                mail = driver.FindElementByXPath("/html/body/div[8]/div[1]/div[2]/div[2]/div[1]/div/div/form/div[2]/div[3]/div/a");
                mail.Click();
               
                Task.Delay(1000).Wait();
                mail = driver.FindElementByXPath("/html/body/div[1]/div/div/div/div[4]/div/div/form/div/div[8]/a");
                mail.Click();
                
                Console.ReadKey();




            }
        }
    }
}
