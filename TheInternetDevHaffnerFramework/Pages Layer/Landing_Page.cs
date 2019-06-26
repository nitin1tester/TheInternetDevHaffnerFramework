using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheInternetDevHaffnerFramework.TestBase;

namespace TheInternetDevHaffnerFramework.Pages_Layer
{
    public class Landing_Page
    {
        public static string url = @"http://the-internet.herokuapp.com/";
        public static void Goto()
        {
            Browser.Goto(url);
        }
    }
}
