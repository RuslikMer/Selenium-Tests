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
using System.Timers;

namespace ConsoleApplication2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            using (var driver = new ChromeDriver())
            {

                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://eplaza.panasonic.ru/products/digital_av/av_accessories/head_phone/RP-HT090/");
                driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                var to = driver.FindElementByXPath("/html/body/div[1]/div/div/div/div[3]/div/div/div[2]/div[2]/div[1]/div[2]/table/tbody/tr/td[3]/div/div/span/span/a[1]");
                to.Click();

                Task.Delay(2000).Wait();
                

                var quantity = driver.FindElementByXPath("/html/body/div[1]/div/div/div/div[3]/div/div[2]/div[2]/div[3]/div/span[2]");
                quantity.Click();
                quantity.Click();
                Task.Delay(2000).Wait();
                to = driver.FindElementByXPath("/html/body/div[1]/div/div/div/div[3]/div/div[2]/div[4]/a");
                to.Click();
                var auth = driver.FindElementByXPath("/html/body/div[1]/div/div/div/div[3]/div/div[2]/form/div[1]/div/div[1]/div[2]/div/a[2]");
                auth.Click();
                auth = driver.FindElementByName("USER_LOGIN");
                auth.SendKeys("botadmin@p33.org");
                auth = driver.FindElementByName("USER_PASSWORD");
                auth.SendKeys("123456");
                auth = driver.FindElementById("js_auth_button");
                auth.Click();
                Task.Delay(10000).Wait();
                var city = driver.FindElementByXPath("/html/body/div[3]/div/div/div/div[3]/div/div[2]/form/div[1]/div/div[1]/div[2]/div[2]/div/a/span");
                city.Click();
                driver.SwitchTo().Window(driver.WindowHandles.ToList().Last());

                //to = driver.FindElementByXPath("/html/body/div[3]/div/div/div/div[3]/div/div[2]/form/div[1]/div/div[1]/div[2]/div[2]/div/a/span");
                //to.Click();




                //driver.SwitchTo().Window(driver.WindowHandles.ToList().Last());
                Task.Delay(3000).Wait();
                //driver.SwitchTo().Window(driver.WindowHandles.ToList().Last());
                city = driver.FindElementByXPath("/html/body/div[11]/div[1]/div[2]/div[2]/div[1]/div/div/div[2]/div[2]/div[1]/ul/li[1]/a");
                city.Click();
                Task.Delay(2000).Wait();
                to = driver.FindElementByName("ORDER_PROP_5");
                to.SendKeys("Testing");
                to = driver.FindElementByName("ORDER_PROP_4");
                to.SendKeys("111111");
                //to = driver.FindElementByXPath("/html/body/div[3]/div/div/div/div[3]/div/div[2]/form/div[1]/div/div[8]/a");
                to.Submit();

                driver.Navigate().GoToUrl("https://eplaza.panasonic.ru/bitrix/admin/sale_order.php?lang=ru");
                Task.Delay(1000).Wait();
                var mail = driver.FindElementByName("USER_LOGIN");
                mail.Clear();
                mail.SendKeys("Bot");
                mail = driver.FindElementByName("USER_PASSWORD");
                mail.SendKeys("123456");
                mail.Submit();
                Task.Delay(10000).Wait();
                var nmail = driver.FindElementByName("filter_user_login");
                nmail.SendKeys("@mail.ru");
                mail = driver.FindElementById("tbl_sale_order_filterset_filter");
                mail.Click();
                Task.Delay(5000).Wait();
                mail = driver.FindElementByXPath("//*[@id=\"tbl_sale_order\"]/tbody/tr/td[15]/a[2]");
                mail.Click();
                mail = driver.FindElementByXPath("//*[@id=\"tbl_sale_buyers_profile_tab1\"]/tbody/tr/td[1]/a");
                mail.Click();
                mail = driver.FindElementById("btn_delete");
                mail.Click();
                IAlert alert = driver.SwitchTo().Alert();
                alert.Accept();
                driver.Navigate().GoToUrl("https://eplaza.panasonic.ru/bitrix/admin/user_admin.php?lang=ru");
                Task.Delay(5000).Wait();
                mail = driver.FindElementByName("find");
                mail.SendKeys("@mail.ru");
                mail = driver.FindElementByName("set_filter");
                mail.Click();
                Task.Delay(4000).Wait();
                mail = driver.FindElementByXPath("/html/body/table/tbody/tr[2]/td[2]/div/div[2]/div[1]/form/table/tbody/tr/td[3]/a");
                mail.Click();
                mail = driver.FindElementById("btn_delete");
                mail.Click();
                driver.SwitchTo().Window(driver.WindowHandles.ToList().Last());
                Task.Delay(1000).Wait();
                alert = driver.SwitchTo().Alert();
                alert.Accept();
                Console.ReadKey();

            }
        }
    }
}