﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumWebdriver.ComponentHelper
{
    public class ComboBoxHelper
    {
        private static SelectElement select;
        public static void SelectElement(By locator, int index)

            {
            select = new SelectElement(GenericHelper.GetElement(locator));
            select.SelectByIndex(index);
}

        public static void SelectElement(By locator, string visibletext)

        {
            select = new SelectElement(GenericHelper.GetElement(locator));
            select.SelectByValue(visibletext);
        }

        public static IList<string> GetAllitems(By locator)

        {
            select = new SelectElement(GenericHelper.GetElement(locator));
            return select.Options.Select((x) => x.Text).ToList();
        }


    }
}
