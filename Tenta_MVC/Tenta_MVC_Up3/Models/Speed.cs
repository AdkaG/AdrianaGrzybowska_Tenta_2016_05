using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tenta_MVC_Up3.Models
{
    public class Speed
    {
        public double GetCurrentSpeed(double distance, double time)
        {
            if (distance > 0 && time > 0)
            {
                return distance/time;
            }
            throw new Exception();


            //throw  new NotImplementedException();
        }
    }
}