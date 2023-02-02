using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_32_02_iida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float width, height;
            Rectangle rectAngle1 = new Rectangle(3, 5);
            RightTriangle rightTriangle = new RightTriangle(2, 8);
            Circle circle = new Circle(6);
            Triangle triangle = new Triangle(2,3,4);
            Surface[] surfaces = { rectAngle1, rightTriangle, circle, triangle };
            for (var i = 0; i < surfaces.Length; i++)
            {
                Console.WriteLine($"surfacesの面積は{surfaces[i].GetSurface()}");
                Console.WriteLine($"surfacesの周囲長は{surfaces[i].GetCircumference()}");
                surfaces[i].GetBounds(out width, out height);
                Console.WriteLine($"入る箱の大きさは横{width},縦{height}\n");
            }
        }
    }
}
