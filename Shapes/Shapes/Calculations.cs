using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
   public class Calculations
    {
        public static double perimeterAverage(List<Ishape> Shapes)
        {
            return Shapes.Average(s => s.Perimeter());
        }
        public static double squareAverage(List<Ishape> Shapes)
        {
            return Shapes.Average(s => s.Square());
        }
        public static Ishape maxSquare(List<Ishape> Shapes)
        {
            return Shapes.Where(s => s.Square() == Shapes.Max(sh => sh.Square())).First();
        }
        public static TypeShapes typeShapeMaxAveragePerimeter(List<Ishape> Shapes)
        {
            Dictionary<TypeShapes, double> AveragePirimeterGroupShapes = new Dictionary<TypeShapes, double>();
            //добавляет пару тип-средний периметр, если присутствует тип фигуры в списке
            foreach (TypeShapes typeShape in Enum.GetValues(typeof(TypeShapes)))
            {
                if (Shapes.Exists(s => s.NameShape() == typeShape))
                    AveragePirimeterGroupShapes.Add(typeShape, Shapes.Where(s => s.NameShape() == typeShape).Average(d => d.Perimeter()));
            }
        /*    foreach (KeyValuePair<TypeShapes, double> kl in AveragePirimeterGroupShapes )
            {
                 Console.WriteLine(kl);
            }
           */
            return AveragePirimeterGroupShapes.First(x => x.Value == AveragePirimeterGroupShapes.Values.Max()).Key;
          }

    }
}
