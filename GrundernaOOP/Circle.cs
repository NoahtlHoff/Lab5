using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Circle
    {
        private double radius;
        public Circle(double _radius)
        {
            radius = _radius;
        }
        public double GetArea()
        {
            double circleArea = Math.Round(radius * radius * Math.PI, 2);
            return circleArea;
        }
        public double GetCircumference()
        {
            double circleCircumference = Math.Round(2 * Math.PI * radius, 2);
            return circleCircumference;
        }
        public double GetSphereVolume()
        {
            double sphereVolume = Math.Round(4 / 3 * Math.PI * radius * radius * radius,2);
            return sphereVolume;
        }
    }
}
