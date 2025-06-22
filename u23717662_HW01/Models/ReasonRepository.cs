using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u23717662_HW01.Models
{
    public class ReasonRepository
    {
        public static List<Reason> Reasons = new List<Reason>
        {
            new Reason
            {
                ReasonID = 1,
                Description = "Urgent medical condition"
            },
            new Reason
            {
                ReasonID = 2,
                Description = "Non-life-threatening event"
            },
            new Reason
            {
                ReasonID = 3,
                Description = "Standard transit"
            },
            new Reason
            {
                ReasonID = 4,
                Description = "Alternative"
            }
        };
    }
}