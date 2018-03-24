using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.TestScript.PageNavigation
{
    [TestClass]
   public class TestPageNavigation
    {
        [TestMethod]
        public void OpenPage()
        {

            NavigationHelper.NavigatetoURL(ObjectRepo.config.GetWebsite());
            Console.WriteLine("Tile of the page:{0}",WindowHelper.GetTitle());
        }
    }
}
