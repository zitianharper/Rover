using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover.Cons.Domain
{
    public class PlateauSize
    {
        public int PlateauX { get; set; }
        public int PlateauY { get; set; }

        public PlateauSize(int plateauX, int plateauY)
        {
            PlateauX = plateauX;
            PlateauY = plateauY;
        }

    }
}
