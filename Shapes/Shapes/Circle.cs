using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
   public class Circle:Ishape
    {
        private TypeShapes nameShape= TypeShapes.Круг;
        double r;
        public Circle(double radius)
        {
            r = radius;
        }
        public double Perimeter()
        {
            return 2*Math.PI*r;
        }
        public double Square()
        {
            return Math.PI * r*r;
        }
        public TypeShapes NameShape()
        {
            return nameShape;
        }
    }
}
