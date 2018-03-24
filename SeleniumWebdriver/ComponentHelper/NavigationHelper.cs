using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumWebdriver.Settings;

namespace SeleniumWebdriver.ComponentHelper
{
  public  class NavigationHelper
    {
        public static void NavigatetoURL(string url)
        {
            ObjectRepo.driver.Navigate().GoToUrl(url);

        }
    }
}
