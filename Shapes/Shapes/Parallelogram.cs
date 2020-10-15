using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Parallelogram : Ishape
    {
        private double a, b;
        private double angle;
        protected TypeShapes nameShape = TypeShapes.Параллелограмм;
        public Parallelogram(double side_a, double side_b, double angle) {
            a = side_a;
            b = side_b;
            this.angle = angle;
            }
        public double Perimeter() {
            return (a + b) * 2;
                }
        public double Square()
        {
            return a*b*Math.Sin(angle*Math.PI/180);
        }
        public TypeShapes NameShape(){
            return nameShape;
        }
    }
}
