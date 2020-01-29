using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektKolokwium
{
    class BladDatyException : Exception
    {
        public BladDatyException(string msg) : base(msg)
        {

        }
    }
}
