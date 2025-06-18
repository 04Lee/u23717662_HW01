using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u23717662_HW01.Models
{
	public class MUV:Service
    {
        public override string ToString()
        {
            string res = "";
            res = Title + " Is a state-of-the art small of large van that is designed to facilitate the movement and transport of patients";

            return res;
        }
    }
}