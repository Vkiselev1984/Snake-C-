using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2
{
    class Walls
    {
        List<Figure> walllist;

        public Walls(int mapwidth, int mapHeight)
        {
            walllist = new List<Figure>();

            HorizontalLine upline = new HorizontalLine(0, mapwidth - 2, 0, '!');
            HorizontalLine downline = new HorizontalLine(0, mapwidth - 2, mapHeight - 1, '!');
            VerticalLine leftline = new VerticalLine(0, mapHeight - 1, 0, '!');
            VerticalLine rightline = new VerticalLine(0, mapHeight - 1, mapwidth - 2, '!');
            walllist.Add(upline);
            walllist.Add(downline);
            walllist.Add(rightline);
            walllist.Add(leftline);


        }

        internal bool IsHit(Figure figure)
        {
            foreach (var wall in walllist)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
          
        }

        public void Draw()
        {
            foreach (var wall in walllist)
            {
                wall.Draw();
            }
        }
    }
}

