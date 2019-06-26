using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TheInternetDevHaffnerFramework.TestBase
{
    public static class Browser
    {
        public static IWebDriver webDriver = new ChromeDriver();

        internal static void Goto(string url)
        {
            webDriver.Url = url;
        }
    }
}
