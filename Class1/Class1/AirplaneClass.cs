using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    class AirplaneClass
    {
        private Color color;
        private Point position;
        private string location;
       private int destination;
       private string land;
        public AirplaneClass(Point position, int destination, Color color)
        {
            this.position = position;
            this.destination = destination;
            this.color = color;
        }
        public void setdestination( string loc)
        {
           
            this.location = loc;
        
        }
        public void landing(string landing)
        {
            this.land = landing;
        }
        public string getlandinfo()
        {
            return this.land;
        }

        public Color getColor()
        {

            return this.color;
        }

        public string getDestination()
        {
            return this.location;
        }

        public int getPositionX()
        {
            return this.position.X;
        }

        public int getPositionY()
        {
            return this.position.Y;
        }

        public void setPosition(int x, int y)
        {
            this.position.X = x;
            this.position.Y = y;
        }

        public void setDestination(int destination)
        {
            this.destination = destination;
        }

        public void movePlane(int xDelta, int yDelta)
        {
            this.position.X += xDelta;
            this.position.Y += yDelta;
        }
    }
}
