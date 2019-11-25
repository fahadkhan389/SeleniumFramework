using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.CustomerException
{
    public class NoSuitableDeviceFound : Exception

    {
        public NoSuitableDeviceFound(string msg) : base(msg)
        {
        }
    }
}
