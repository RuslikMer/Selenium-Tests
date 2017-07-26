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
                driver.Navigate().GoToUrl("https://eplaza.panasonic.ru/bitrix/admin/user_admin.php?lang=ru");
                driver.Manage().Window.Maximize();
                var mail = driver.FindElementByName("USER_LOGIN");
                mail.SendKeys("merikanov95@mail.ru");
                mail = driver.FindElementByName("USER_PASSWORD");
                mail.SendKeys("rorshach1994");
                //catalog = driver.FindElementByName("Login");
                mail.Submit();
                Task.Delay(20000).Wait();
                mail = driver.FindElementByName("find");
                mail.SendKeys("qwerty@g.ru");
                mail = driver.FindElementByCssSelector("html.bx-no-touch.bx-no-retina.bx-firefox.bx-boxshadow.bx-borderradius.bx-flexwrap.bx-boxdirection.bx-transition.bx-transform body#bx-admin-prefix div#window_wrapper table.adm-main-wrap tbody tr td.adm-workarea-wrap.adm-workarea-wrap-top div#adm-workarea.adm-workarea.adm-workarea-page form div#adm-filter-tab-wrap-tbl_user_filter.adm-filter-wrap.adm-current-filter table.adm-filter-main-table tbody tr td.adm-filter-main-table-cell div#tbl_user_filter_content.adm-filter-content.adm-filter-content-first div.adm-filter-content-table-wrap table#tbl_user_filter.adm-filter-content-table tbody tr#tbl_user_filter_row_miss-0 td.adm-filter-item-center div.adm-filter-alignment div.adm-filter-box-sizing span.adm-select-wrap select.adm-select option");
                mail.Click();
                mail = driver.FindElementByName("set_filter");
                mail.Click();
                mail = driver.FindElementByXPath("/html/body/div[1]/table/tbody/tr[2]/td[2]/div/div[2]/div[1]/form/table/tbody/tr/td[1]/label");
                mail.Click();
                mail = driver.FindElementById("action_delete_button");
                mail.Click();
                Task.Delay(1000).Wait();
                mail.Submit();

                Console.ReadKey();




            }
        }
    }
}
