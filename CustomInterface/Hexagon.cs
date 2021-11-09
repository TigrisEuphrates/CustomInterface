using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    class Hexagon:Shape, IPointy, IDraw3D
    {
        //int a;
        //public int Points 
        //{
        //    get { return a; }
        //    set { a = 10; } 
        //}

        public Hexagon() { }
        public Hexagon(string name) : base(name) { }
        public override void Draw()
        {
            Console.WriteLine($"Drawing {PetName} the Hexagon");
        }
        public byte Points
        {
            get { return 6; }
        }
        public byte GetNumberOfPoints()
        {
            return Points;
        }
        public void Draw3D()
        {
            Console.WriteLine("Drawing Hexagon in 3D!");
        }
    }
}
