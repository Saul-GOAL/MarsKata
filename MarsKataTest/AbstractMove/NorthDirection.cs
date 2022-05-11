using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsKataTest
{
    abstract class NorthDirection : DirectionAbs
    {
        
        public override Direction TurnLeft()
        {
            return new Direction('O');
        }
        public override Direction TurnRight()
        {
            return new Direction('E');
        }
        public override Point MoveForward(Point coords)
        {
            if (coords.y == 5)
                return new Point(coords.x,coords.y = 0);
            else
                return new Point(coords.x, coords.y + 1);
        }
        public override Point MoveBackward(Point coords)
        {
            if (coords.y == 0)
                return new Point(coords.x, coords.y = 5);
            else
                return new Point(coords.x, coords.y - 1);
        }
    }
}
