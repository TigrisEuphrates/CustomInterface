using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    class Program
    {
        static void DrawIn3D(IDraw3D itf3d)
        {
            Console.WriteLine("Drawing IDraw3D compatible type");
            itf3d.Draw3D();
        }
        static IPointy FindFirstPointyShape(Shape[] shapes)
        {
            foreach (Shape s in shapes)
            {
                if (s is IPointy ip)
                    return ip;
            }
            return null;
        }
        static void Main(string[] args)
        {
            Hexagon hex = new Hexagon();
            Console.WriteLine($"Points: {hex.Points}");
            Console.WriteLine();

            Circle c = new Circle("Lisa");
            IPointy itfPt = null;
            try
            {
                itfPt = (IPointy) c;
                Console.WriteLine(itfPt.Points);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine();

            Hexagon hex2 = new Hexagon("Peter");
            IPointy itfPt2 = hex2 as IPointy;
            if (itfPt2 != null)
            {
                Console.WriteLine($"Points: {hex.Points}");
            }
            else
            {
                Console.WriteLine("Not pointy...");
            }
            Console.WriteLine();

            Shape[] myShapes = { new Hexagon(), new Circle(), new Triangle("Joe"), new Circle("JoJo") };
            for (int i = 0; i < myShapes.Length; i++)
            {
                myShapes[i].Draw();
                if (myShapes[i] is IPointy ip)
                    Console.WriteLine($"Points: {ip.Points}");
                else
                    Console.WriteLine($"{myShapes[i].PetName} is not pointy!");
                if (myShapes[i] is IDraw3D)
                    DrawIn3D((IDraw3D)myShapes[i]);
                Console.WriteLine();
            }
            IPointy firstPointyItem = FindFirstPointyShape(myShapes);
            Console.WriteLine($"The item has {firstPointyItem.Points} points");
            Console.WriteLine();

            IPointy[] myPointyObjects = { new Hexagon(), new Knife(), new Triangle(), new Fork(), new PitchFork() };
            foreach (IPointy i in myPointyObjects)
                Console.WriteLine($"Object has {i.Points} points.");
            Console.WriteLine();
        }
    }
}
