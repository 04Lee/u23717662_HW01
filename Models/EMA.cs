using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u23717662_HW01.Models
{
	public class EMA:Service
	{
        public override string ToString()
        {
            string res = "";
            res = Title + " are ambulances that are stationed at events , such as concerts, sports games and festivals to provide medical assistance";

            return res;
        }
    }
}