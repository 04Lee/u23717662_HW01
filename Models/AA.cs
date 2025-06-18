using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u23717662_HW01.Models
{
	public class AA:Service
	{
        public override string ToString()
        {
            string res = "";
            res = Title + " ambulance help in the transfer of patients across long distances in both emergency situations";

            return res;
        }
    }
}