using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Square:Rectangle
    {
       
        public Square(double side_a) : base(side_a, side_a) {
             nameShape = TypeShapes.Квадрат;
        }
        }
}
