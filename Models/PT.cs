using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u23717662_HW01.Models
{
	public class PT:Service
	{
        public override string ToString()
        {
            string res = "";
            res = Title + " is the most basic type of transport for patients requiring ambulatory support to and from the hospital ";
            return res;
        }
    }
}