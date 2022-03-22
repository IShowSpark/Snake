using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator //создание еды
    {
        int mapWidht;
        int mapHeight;
        char sym;
        ConsoleColor colour;
        Random random = new Random(); //рандом 
        public FoodCreator(int mapWidht, int mapHeight, char sym, ConsoleColor colour)
        {
            this.mapWidht = mapWidht;
            this.mapHeight = mapHeight;
            this.sym = sym;
            this.colour = colour;
        }
        public Point CreateFood()
        {
            int x = random.Next(2, mapWidht - 2); //создается по разным частям карты
            int y = random.Next(2, mapHeight - 2);//создается по разным частям карты
            return new Point(x, y, sym, colour); //создание по x y еда
        }
    }
}