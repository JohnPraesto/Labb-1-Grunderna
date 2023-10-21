using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_1_Grunderna
{
    internal class Triangle
    {
        double _side;

        public Triangle(double side)
        {
            this._side = side;
        }

        public double getArea()
        {
            return (_side * _side * Math.Sqrt(3)) / 4;
        }

        public double getCircumference()
        {
            return _side * 3;
        }

        public double getVolume()
        {
            return (_side * (_side * 2)) / 3;
        }
    }
}
