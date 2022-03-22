using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Figure> wallList;
        public Walls(int mapWidth, int mapHeight, char sym, ConsoleColor colour)
        {
            wallList = new List<Figure>();
            HorizontalLine upline = new HorizontalLine(0, mapWidth - 2, 0, sym, colour); //горизональные линии
            HorizontalLine downline = new HorizontalLine(0, mapWidth - 2, 24, sym, colour);
            VerticalLine leftline = new VerticalLine(0, mapHeight - 1, 0, sym, colour);//вертикальные линии
            VerticalLine rightline = new VerticalLine(0, mapHeight - 1, 78, sym, colour);
            wallList.Add(upline); //вверхние линии
            wallList.Add(downline);//нижнии линии
            wallList.Add(leftline);//левые линии
            wallList.Add(rightline);//правые линии
        }
        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
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
            foreach (var wall in wallList)
            {
                wall.Draw();
            }
        }

    }
}