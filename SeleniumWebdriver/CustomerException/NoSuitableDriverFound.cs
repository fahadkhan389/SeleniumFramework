using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.CustomerException
{
    public class NoSuitableDriverFound : Exception

    {
        public NoSuitableDriverFound(string msg) : base(msg)
        {
        }
    }
}
