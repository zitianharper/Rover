using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover.Cons.Domain
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }
        public DirectionsEnum FaceDirection { get; set; }

        public Position(int x, int y, DirectionsEnum faceDirection)
        {
            X = x;
            Y = y;
            FaceDirection = faceDirection;
        }

    }
}
