using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTreasureHunt
{
    public class Tile
    {
        private string defaultTile = "default";
        private string uncoveredDefaultTile = "miss";
        private string treasureTile = "treasure";
        private string uncoveredTrasureTile = "found";
        private Dictionary<string, string> tileStates = new Dictionary<string, string>();
        private string tileState;

        public Tile()
        {
            tileStates.Add(defaultTile, " ");
            tileStates.Add(treasureTile, " ");
            tileStates.Add(uncoveredDefaultTile, "!");
            tileStates.Add(uncoveredTrasureTile, "$");
            tileState = defaultTile;
        }
        public void uncover()
        {
            if (tileState == treasureTile)
            {
                tileState = uncoveredTrasureTile;
            }
            else
            {
                tileState = uncoveredDefaultTile;
            }
        }
        public void setAsTreasure()
        {
            tileState = treasureTile;
        }
        public string showTile()
        {
            string tileView = tileStates[tileState];
            return tileView;
        }
    }
}
