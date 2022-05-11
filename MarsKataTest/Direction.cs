using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsKataTest
{
    public class Direction
    {
        char direction;

        public Direction()
        {
      
        }
        public Direction(char dir)
        { 
        this.direction = dir;
        }
        public Direction TurnRight()
        {
            this.direction = this.TurnRight().direction;
            //if (this.direction == 'N')
            //    return new Direction('E');
            //else if (this.direction == 'S')
            //    return new Direction('O');
            //else if (this.direction == 'E')
            //    return new Direction('S');
            //else if (this.direction == 'O')
            //    return new Direction('N');

            throw new Exception("Problem");
        }

        public Direction TurnLeft()
        {
            this.direction = this.TurnLeft().direction;

            //if (this.direction == 'N')
            //    return new Direction('O');
            //if (this.direction == 'S')
            //    return new Direction('E');
            //if (this.direction == 'E')
            //    return new Direction('N');
            //if (this.direction == 'O')
            //    return new Direction('S');

            throw new Exception("Problem");
        }

        public Point GoBackward(Point coords)
        {
            return coords = this.GoBackward(coords);
            //if (this.direction == 'N')
            //    if(coords.y == 0)
            //        return new Point(coords.x, coords.y = 5);
            //    else
            //        return new Point(coords.x, coords.y-1);
            //if (this.direction == 'S')
            //    if (coords.y == 5)
            //        return new Point(coords.x, coords.y = 0);
            //    else
            //        return new Point(coords.x, coords.y+1);
            //if (this.direction == 'E')
            //    if (coords.x == 0)
            //        return new Point(coords.x = 5, coords.y);
            //    else
            //        return new Point(coords.x-1, coords.y);
            //if (this.direction == 'O')
            //    if (coords.x == 5)
            //        return new Point(coords.x = 0, coords.y);
            //    else
            //        return new Point(coords.x + 1, coords.y);
            throw new Exception("Problem");
        }

        public Point GoForward(Point coords)
        {
           return coords = this.GoForward(coords);
            //if (this.direction == 'N')
            //    if (coords.y == 5)
            //        return new Point(coords.x, coords.y = 0);
            //    else
            //        return new Point(coords.x, coords.y + 1);
            //if (this.direction == 'S')
            //    if (coords.y == 0)
            //        return new Point(coords.x, coords.y = 5);
            //    else
            //        return new Point(coords.x, coords.y - 1);
            //if (this.direction == 'E')
            //    if (coords.x == 5)
            //        return new Point(coords.x = 0, coords.y);
            //    else     
            //        return new Point(coords.x + 1, coords.y);
            //if (this.direction == 'O')
            //    if (coords.x == 0)
            //        return new Point(coords.x = 5, coords.y);
            //    else 
            //        return new Point(coords.x - 1, coords.y);

            throw new Exception("Problem");
        }

        public override bool Equals(object? obj)
        {
            return obj is Direction direction &&
                   this.direction == direction.direction;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(direction);
        }
    }
}
