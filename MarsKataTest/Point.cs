using System;

namespace MarsKataTest
{
    public class Point
    {
        public int x;
        public int y;


        public Point(int x, int y)
           { 
            this.x = 0;
            this.y = 0; 
        }    

        public override bool Equals(object? obj)
        {
            return obj is Point point &&
                   x == point.x &&
                   y == point.y;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(x, y);
        }

    }
    
}
