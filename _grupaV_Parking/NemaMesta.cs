using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _grupaV_Parking
{
    internal class NemaMesta : Exception
    {

        public NemaMesta(string msg = "Parking je pun!") 
            : base(msg) { }

        public NemaMesta(string msg, Exception inner)
            : base(msg, inner) { }

    }
}
