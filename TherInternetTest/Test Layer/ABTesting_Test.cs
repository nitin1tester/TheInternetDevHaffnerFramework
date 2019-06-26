using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheInternetDevHaffnerFramework.Pages_Layer;

namespace TherInternetTest
{
    [TestClass]
    public class ABTesting_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            Landing_Page.Goto();
            ABTesting_Pages.GotoABTesting();
        }
    }
}
