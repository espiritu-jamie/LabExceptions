using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabExceptions
{
    internal class Circle
    {
        public double Radius
        {
            get; set;
        }

        public void SetRadius(double radius)
        {
            if (radius <= 0)
            {
                throw new InvalidRadiusException(radius);
            }

            Radius = radius;
        }

        public override string ToString()
        {
            return $"The circle has a valid radius of {Radius}.";
        }
    }
}
