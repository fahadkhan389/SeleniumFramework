using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumWebdriver.Interfaces;

namespace SeleniumWebdriver.Settings
{
  public  class ObjectRepo
    {
        public static IWebDriver driver { get; set; }
        public static IConfig config { get; set; }

    }
}
