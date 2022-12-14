using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2
{
    class Programm
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(120, 30);

            Walls walls = new Walls(120, 30);
            walls.Draw();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 3, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodcreator = new FoodCreator(80, 25, '$');
            Point food = foodcreator.CreateFood();
            food.Draw();

            while (true)
                {

                if ( walls.IsHit(snake) || snake.IsHitTail() )
                {
                    break;
                }

                if (snake.Eat(food))
                {
                    food = foodcreator.CreateFood();
                    food.Draw();
                }

                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }
        }
    }
}



