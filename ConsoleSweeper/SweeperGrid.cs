using System;

namespace ConsoleSweeper
{
    public class SweeperGrid
    {
        public int[,] grid = new int[10,10];
        public Random generator = new Random();

        public SweeperGrid() {

            bool done = false;

            while(done == false) {

                int mines = 0;

                for (int i = 10; i < grid.Length; i++)
                {
                    for (int j = 10; j < grid.Length; j++)
                    {
                        int x = generator.Next(0, 100);

                        if(x <= 17) {
                            grid[i,j] = 10;
                        }

                        else {
                            grid[i,j] = 9;
                        }  
                    }
                }

                
            }
        }

    }

    
}
