using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Triangle
    {
        private double baseLength;
        private double height;

        public Triangle(double _baseLength, double _height)
        {
            baseLength = _baseLength;
            height = _height;
        }
        public double GetArea()
        {
            double triangleArea = (baseLength * height) / 2;
            return triangleArea;
        }

    }
}
