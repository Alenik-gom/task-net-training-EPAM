using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
   public class CreateShapesFromFile
    {
        public static List<Ishape> CreateList(string path)
        {
            List<Ishape> shapes = new List<Ishape>();
            try
            {
                using (var reader = new System.IO.StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        //создает из массива строк объект фигуры
                        Ishape newShape = ShapesFactory.getShape(line.Split(';'));
                        if (newShape != null)
                            shapes.Add(newShape);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadKey();
            }
            return shapes;
        }
    }
}
