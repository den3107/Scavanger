using System.Collections.Generic;
using System.Drawing;

namespace Scavanger
{
    public class Map
    {
        public Point Start { get; set; }

        public Point End { get; set; }

        public Tile[,] Tiles { get; set; }

        public Wall[,] Walls { get; set; }

        public Pickup[,] Pickups { get; set; }

        public Map(Tile[,] tiles, Wall[,] walls, Pickup[,] pickups, int endX, int endY, int startX, int startY)
        {
            Tiles = tiles;
            Walls = walls;
            Pickups = pickups;
            Start = new Point(startX, startY);
            End = new Point(endX, endY);
        }

        public Pickup RemovePickup(Point position)
        {
            Pickup pickup = Pickups[position.X, position.Y];

            Pickups[position.X, position.Y] = null;

            return pickup;
        }

        public void Draw(Graphics g, int xOrig, int yOrig)
        {
            for (int x = 0; x < Tiles.GetLength(1); x++)
            {
                for (int y = 0; y < Tiles.GetLength(0); y++)
                {
                    Image img = new Bitmap(AssetLocation.Tile + Tiles[x, y].ImageName);
                    g.DrawImage(img, xOrig + (x * 32), yOrig + (y * 32));
                }
            }
        }
    }
}