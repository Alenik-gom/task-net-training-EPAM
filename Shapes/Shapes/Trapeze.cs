using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Trapeze:Ishape
    {
        private double a, b, c, d, h;
        private TypeShapes nameShape = TypeShapes.Трапеция;
        public Trapeze(double side_a, double side_b, double side_с, double side_d, double h)
        {
            a = side_a;
            b = side_b;
            c = side_с;
            d = side_d;
            this.h = h;
        }
        public double Perimeter()
        {
            return a + b + c+d;
        }
        public double Square()
        {
           return (a+b)*h/2;
        }
        public TypeShapes NameShape()
        {
            return nameShape;
        }
    }
}
