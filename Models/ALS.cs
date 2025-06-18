using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u23717662_HW01.Models
{
	public class ALS:Service
	{
        public override string ToString()
        {
            string res = "";
            res = Title + " ambulance is staffed by a Paramedic and is used to transport paitients who require high level of care";

            return res;
        }
    }
}