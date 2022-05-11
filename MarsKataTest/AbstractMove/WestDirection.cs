using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsKataTest
{
    abstract class WestDirection : DirectionAbs
    {
        public override Direction TurnLeft()
        {
            return new Direction('S');
        }
        public override Direction TurnRight()
        {
            return new Direction('N');
        }
        public override Point MoveForward(Point coords)
        {
            if (coords.x == 0)
                return new Point(coords.x = 5, coords.y);
            else
                return new Point(coords.x - 1, coords.y);
        }
        public override Point MoveBackward(Point coords)
        {
            if (coords.x == 5)
                return new Point(coords.x = 0, coords.y);
            else
                return new Point(coords.x + 1, coords.y);
        }

    }
}
