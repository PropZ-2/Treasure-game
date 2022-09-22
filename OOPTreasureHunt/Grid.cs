using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTreasureHunt
{
    public class Grid
    {
        public static Tile[] tiles;
        private static int treasureIndex;

        public Grid(int numTiles, int ti)
        {
            treasureIndex = ti;
            tiles = new Tile[numTiles];
            for (int i = 0; i < numTiles; i++)
            {
                Tile aTile = new Tile();
                tiles[i] = aTile;
                if (i == treasureIndex)
                {
                    aTile.setAsTreasure();
                }
            }
        }
        public string renderGrid()
        {
            string theTiles = "";
            string tileCoords = "";
            int tileIndex = 0;
            foreach (Tile tile in tiles)
            {
                theTiles += "[" + tile.showTile() + "]";
                tileCoords += " " + tileIndex + " ";
                tileIndex++;
            }
            string theGrid = theTiles + "\n" + tileCoords + "\n";
            return theGrid;
        }
    }
}
