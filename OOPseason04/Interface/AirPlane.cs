using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPseason04.Interface
{
    internal class AirPlane : IMoveble, IFlyable
    {
        void IMoveble.Forword()
        {
            Console.WriteLine("Move Forword on Ground ");
        }

        void IFlyable.Forword()
        {
            Console.WriteLine("Move Forword on Air ");
        }
    }
}
