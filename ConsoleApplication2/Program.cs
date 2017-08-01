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

                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://eplaza.panasonic.ru/products/digital_av/av_accessories/head_phone/RP-TCM105E/");
                driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                var to = driver.FindElementByXPath("/html/body/div[1]/div/div/div/div[3]/div/div/div[2]/div[2]/div[1]/div[2]/table/tbody/tr/td[3]/div/div/span/span/a[1]");
                to.Click();

                Task.Delay(2000).Wait();
                driver.SwitchTo().Window(driver.WindowHandles.ToList().Last());

                var popap = driver.FindElementById("cboxClose");
                popap.Click();
                Task.Delay(2000).Wait();
                to = driver.FindElementByXPath("/html/body/div[1]/div/div/div/div[3]/div/div[2]/div[4]/a");
                to.Click();
                var registration = driver.FindElementByName("NEW_EMAIL");

                string s = "";
                Random rand = new Random();
                for (int i = 0; i < 6; i++)
                {
                    s += Convert.ToChar(rand.Next(65, 90));
                }

                registration.SendKeys(s + "@mail.ru");
                driver.SwitchTo().Window(driver.WindowHandles.ToList().Last());

                var city = driver.FindElementByXPath("//*[@id=\"process_order\"]/div[1]/div/div[2]/div[2]/div[2]/div/a/span");
                city.Click();
                Task.Delay(2000).Wait();
                var city2 = driver.FindElementByXPath("/html/body/div[3]/div[1]/div[2]/div[2]/div[1]/div/div/div[2]/div[2]/div[1]/ul/li[1]/a");
                city2.Click();
                Task.Delay(2000).Wait();
                var adress = driver.FindElementByXPath("//*[@id=\"process_order\"]/div[1]/div/div[2]/div[4]/div[2]/input");
                adress.SendKeys("Тестовая");
                Task.Delay(500).Wait();
                var index = driver.FindElementByXPath("//*[@id=\"process_order\"]/div[1]/div/div[2]/div[5]/div[2]/input");
                index.SendKeys("123456");
                Task.Delay(500).Wait();
                var password = driver.FindElementByXPath("//*[@id=\"process_order\"]/div[1]/div/div[3]/div[3]/div[2]/input");
                password.SendKeys("Cent73");
                Task.Delay(500).Wait();
                var password2 = driver.FindElementByXPath("//*[@id=\"process_order\"]/div[1]/div/div[3]/div[4]/div[2]/input");
                password2.SendKeys("Cent73");
                Task.Delay(500).Wait();
                var name = driver.FindElementByXPath("//*[@id=\"process_order\"]/div[1]/div/div[3]/div[5]/div[2]/input");
                name.SendKeys("Тест");
                Task.Delay(500).Wait();
                var famali = driver.FindElementByXPath("//*[@id=\"process_order\"]/div[1]/div/div[3]/div[6]/div[2]/input");
                famali.SendKeys("Тестов");
                Task.Delay(500).Wait();
                var namber = driver.FindElementByXPath("//*[@id=\"process_order\"]/div[1]/div/div[3]/div[7]/div[2]/input");
                namber.SendKeys("92933087899");
                Task.Delay(500).Wait();
                var pol = driver.FindElementByXPath("/html/body/div[1]/div/div/div/div[3]/div/div[2]/form/div[1]/div/div[3]/div[8]/div[2]/div/div/select/option[2]");
                pol.Click();
                pol.Submit();
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
                nmail.SendKeys(s + "@mail.ru");
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
                mail.SendKeys(s + "@mail.ru");
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
