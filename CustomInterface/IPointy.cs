using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    interface IPointy
    {
        byte GetNumberOfPoints();
        byte Points { get; }

        //Error! Interfaces aren't able to have fields
        //public int numbOfPoints;
        //Error! Interfaces aren't able to have constructors
        //public IPointy() { numbOfPoints = 0; }
        //Error! Interfaces can't provide implementation of it's members 
        //byte GetNumberOfPoints() { return numbOfPoints; }
    }
}
