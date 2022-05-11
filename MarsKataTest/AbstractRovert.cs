using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsKataTest
{
    public abstract class DirectionAbs
    {
        public abstract Direction move(char dir);
        public abstract Direction TurnLeft();
        public abstract Direction TurnRight();

        public abstract Point MoveForward(Point coords);
        public abstract Point MoveBackward(Point coords);
    }
}
