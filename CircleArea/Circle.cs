using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea
{
    internal class Circle
    {
        public int Radius { get ; set; }

        public Circle(int radius)
        {
            Radius = radius;
        }

        public double GetArea()
        {
            {
                return Radius * Radius * Math.PI;
            }
        }
        public double GetCircumference()
        {
            return Radius * 2  * Math.PI;
        }
        public double GetVolume()
        {
            return (4.0/3.0) * Math.PI * Math.Pow(Radius, 3);
        }

    }
}
