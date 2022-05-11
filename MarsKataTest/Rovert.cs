using System;

namespace MarsKataTest
{
    internal class Rovert
    {
        public Point coordenates;
        

        // public char direction = 'N';
        public Direction direction;

        public Rovert(Point coords, char direction)
        {
            this.coordenates = coords;
            this.direction = new Direction(direction);
        }

        internal void Command(char v)
        {
            if (v == 'L')
            {
                this.direction = this.direction.TurnLeft();
            }
            else if (v == 'R')
            {
                this.direction = this.direction.TurnRight();
            }
            else if (v == 'F')
            {
                this.coordenates = this.direction.GoForward(this.coordenates);
            }
            else if (v == 'B')
            {
                this.coordenates = this.direction.GoBackward(this.coordenates);
            }
            else
            {
                Console.WriteLine("Houston, we have a problem");
            }
                
        }
  

        public Rovert StateRover(Rovert original)
        {
            return original;
        }


        public override int GetHashCode()
        {
            return HashCode.Combine(coordenates, direction);
        }
    }
}