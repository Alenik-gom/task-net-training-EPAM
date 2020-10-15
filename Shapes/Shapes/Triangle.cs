using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
   public class Triangle:Ishape
    {
        private double a, b,c;
        private TypeShapes nameShape = TypeShapes.Треугольник;
        public Triangle(double side_a, double side_b, double side_с)
        {
            a = side_a;
            b = side_b;
            c = side_с;
        }
        public double Perimeter()
        {
            return a + b+c;
        }
        public double Square()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }
        public TypeShapes NameShape()
        {
            return nameShape;
        }
    }
}
