using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheInternetDevHaffnerFramework.TestBase;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TheInternetDevHaffnerFramework.Pages_Layer
{
    public class ABTesting_Pages
    {
        public static void GotoABTesting()
        {
            Browser.webDriver.FindElement(By.XPath("")).Click();
        }
    }
} 
