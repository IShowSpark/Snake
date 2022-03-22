using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure //сама змейка
    {
        public Directions direction; //диектория
        public ConsoleColor colour; //цвет
        public Snake(Point tail, int length, Directions _direction, ConsoleColor colour)
        {
            direction = _direction;
            this.colour = colour;
            plist = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail, colour); //создаются точки для змейки
                p.Move(i, direction); //передвигаются точки
                plist.Add(p); //добавляются точки
            }
        }
        internal void Move() //передвежение
        {
            Point tail = plist.First(); //первый хвост
            plist.Remove(tail); //удаляем хвост
            Point head = GetNextPoint(); //следующая точка
            plist.Add(head); //добавляем голову
            tail.Clear(); //очистка хвоста
            head.Draw(); //голову рисуем
        }
        public Point GetNextPoint()
        {
            Point head = plist.Last(); //последняя голова
            Point nextPoint = new Point(head, colour); //создание точки
            nextPoint.Move(1, direction); //передвинуть на 1 вперед
            return nextPoint; //вернуть
        }
        internal bool IsHitTail() //если сам себя ударит
        {
            var head = plist.Last(); //голова 
            for (int i = 0; i < plist.Count - 2; i++) //делаем -2 от головы
            {
                if (head.IsHit(plist[i]))
                    return true;
            }
            return false;
        }

        public void HandleKey(ConsoleKey key) //это для управления змейки, то есть стрелочками ну или wasd кому как удобно
        {
            if (key == ConsoleKey.LeftArrow | key == ConsoleKey.A)
                direction = Directions.LEFT;
            else if (key == ConsoleKey.RightArrow | key == ConsoleKey.D)
                direction = Directions.RIGHT;
            else if (key == ConsoleKey.DownArrow | key == ConsoleKey.S)
                direction = Directions.DOWN;
            else if (key == ConsoleKey.UpArrow | key == ConsoleKey.W)
                direction = Directions.UP;
            else if (key == ConsoleKey.Escape)
                Console.ReadKey(true);
        }
        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                plist.Add(food);
                return true;
            }
            else
                return false;
        }
    }
}