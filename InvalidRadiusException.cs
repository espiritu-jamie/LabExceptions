using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabExceptions
{
    internal class InvalidRadiusException : Exception
    {
        public double Radius
        {
            get; set;
        }
        public InvalidRadiusException() : base("Invalid radius")
        {
            
        }

        public InvalidRadiusException(double radius) :base("The radius " + radius + " is not valid.")
        {
            this.Radius = radius;
        }

    }
}
