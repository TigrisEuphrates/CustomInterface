using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    class Circle:Shape
    {
        public Circle() { }
        public Circle(string name) : base(name) { }
        public override void Draw()
        {
            Console.WriteLine($"Drawing {PetName} the Circle");
        }
    }
    class ThreeDCircle:Circle, IDraw3D
    {
        public new string PetName { get; set; }
        new public void Draw3D()
        {
            Console.WriteLine("Drawing a 3D Circle");
        }
    }
}
