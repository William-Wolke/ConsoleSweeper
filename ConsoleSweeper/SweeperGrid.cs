using System;

namespace ConsoleSweeper
{
    public class SweeperGrid
    {
        public int[,] grid = new int[10, 10];
        private Random generator = new Random();

        public SweeperGrid()
        {
            int mines = 17;

            for (int i = 10; i < grid.Length; i++)
            {
                for (int j = 10; j < grid.Length; j++)
                {
                    grid[i, j] = 9;

                }
            }

            for (int i = 0; i < mines; i++)
            {
                grid[generator.Next(0,10), generator.Next(0,10)] = 10;
            }


        }

        public bool CheckPosition (int x, int y) {

            bool mine = false;

            if (grid[x,y] == 9) {
                return mine;
            }

            else {
                mine = true;
                return mine;
            }
        }

    }


}
