using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_1_Grunderna
{
    public class Circle
    {
        double _radius;

        public Circle(double Radius)
        {
            this._radius = Radius;
        }

        public double getArea()
        {
            return _radius * _radius * Math.PI;
        }

        public double getCircumference()
        {
            return (_radius * 2) * Math.PI;
        }

        public double getVolume()
        {
            return (4 * Math.PI * (_radius * _radius * _radius) / 3);
        }
    }
}
