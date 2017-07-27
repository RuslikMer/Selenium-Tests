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

                driver.Navigate().GoToUrl("https://eplaza.panasonic.ru/bitrix/admin/sale_order.php?lang=ru");
                driver.Manage().Window.Maximize();
                var mail = driver.FindElementByName("USER_LOGIN");
                mail.SendKeys("Bot");
                mail = driver.FindElementByName("USER_PASSWORD");
                mail.SendKeys("123456");
                mail.Submit();
                Task.Delay(10000).Wait();
                mail = driver.FindElementByName("filter_account_number");
                mail.SendKeys("113579");
                mail = driver.FindElementById("tbl_sale_order_filterset_filter");
                mail.Click();
                Task.Delay(3000).Wait();
                mail = driver.FindElementByXPath("/html/body/table/tbody/tr[2]/td[2]/div/div[4]/div[1]/form/table/tbody/tr/td[3]/table/tbody/tr/td[2]/b/a");
                mail.Click();
                mail = driver.FindElementById("btn_delete");
                mail.Click();
                IAlert alert = driver.SwitchTo().Alert();
                alert.Accept();
                driver.Navigate().GoToUrl("https://eplaza.panasonic.ru/bitrix/admin/user_admin.php?lang=ru");
                Task.Delay(5000).Wait();
                mail = driver.FindElementByName("find");
                mail.SendKeys("qwert@g.ro");
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
