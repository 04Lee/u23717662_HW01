using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u23717662_HW01.Models
{
	public class BLS:Service
	{
        public override string ToString()
        {
            string res = "";
            res = Title + " ambulance is provided to transport patients who are in a non life threatening condition";

            return res;
        }
    }
}