using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    abstract class Shape
    {
        public string PetName { get; set; }
        public Shape(string name = "NoName")
        {
            PetName = name;
        }
        abstract public void Draw();
        //virtual public void Draw()
        //{
        //    Console.WriteLine("Inside Shape.Draw()");
        //}
        //interface GetNumberOfPoints
        //{
        //    int MyProperty { get; set; }
        //}
    }
}
