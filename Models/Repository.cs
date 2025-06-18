using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u23717662_HW01.Models
{
	public class Repository
	{
        public List<Service> GetService()
        {
            return new List<Service>()
            {
                new ALS
                {
                   Title ="Advanced Life Support",
                    Type = "ALS" ,
                },
                
                new BLS
                {
                    Title = "Basic Life Support",
                    Type = "BLS" ,
                }
            };
        }
    }
}