using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTreasureHunt
{
    class TreasureHuntGame
    {
        private static Grid grid;
        private static Boolean promptInputFromUser = false;
        private static string gameMessage;
        private static Boolean gameOver = false;
        private static int numTiles = 10;
        private static int highestIndex = numTiles - 1;
        private static int treasureIndex = RandomInteger(numTiles);
        private static int keyIndex = RandomInteger(numTiles);

        static void Main(string[] args)
        {
            grid = new Grid(numTiles, treasureIndex);

            game();
        }
        public static void game()
        {
            if (promptInputFromUser)
            {
                System.Console.WriteLine("Select a tile by inputting a number between 0 and " + highestIndex);
                string input = System.Console.ReadLine();
                int inputIndex = Int32.Parse(input);
                Grid.tiles[inputIndex].uncover();
                if (inputIndex == treasureIndex)
                {
                    gameMessage = "Well done, treasure is uncoved, game over!";
                    gameOver = true;
                }
                else
                {
                    gameMessage = "no, that wasn't it. Try again";
                }
            }
            else
            {
                promptInputFromUser = true;
                gameMessage = "Uncover the treasure.";
            }
            System.Console.Clear();
            System.Console.WriteLine(gameMessage + "\n");
            System.Console.WriteLine(grid.renderGrid());
            if (!gameOver) game();
        }
        private static int RandomInteger(int max, int min = 0)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
