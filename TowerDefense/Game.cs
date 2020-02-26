using System;

namespace TowerDefense
{
    class Game
    {
        static void Main()
        {
            Map map = new Map(8, 5);
            Random _random = new Random();
            int numberOfInvaders = _random.Next(1, 4);

            try
            {
                Path path = new Path(
                    new[] {
                        new MapLocation(0, 2, map),
                        new MapLocation(1, 2, map),
                        new MapLocation(2, 2, map),
                        new MapLocation(3, 2, map),
                        new MapLocation(4, 2, map),
                        new MapLocation(5, 2, map),
                        new MapLocation(6, 2, map),
                        new MapLocation(7, 2, map)
                    }
                );

                Invader[] invaders = new Invader[numberOfInvaders];

                for (int i = 0; i < numberOfInvaders; i++)
                {
                    if (i % 2 == 0)
                    {
                        invaders[i] = new FastInvader(path);
                    }
                    else
                    {
                        invaders[i] = new Invader(path);
                    }
                }

                Tower[] towers = {
                    new StrongTower(new MapLocation(1, 3, map)),
                    new Tower(new MapLocation(3, 3, map)),
                    new SniperTower(new MapLocation(5, 3, map))
                };

                Level level = new Level(invaders)
                {
                    Towers = towers
                };

                bool playerWon = level.Play();

                Console.WriteLine("Player " + (playerWon ? "won" : "lost"));
            }
            catch (OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DefenseException)
            {
                Console.WriteLine("Unhandled DefenseException");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unhandled Exception: " + ex);
            }
        }
    }
}
