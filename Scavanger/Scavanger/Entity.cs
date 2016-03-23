using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scavanger
{
    public abstract class Entity
    {
        public double Health { get; set; }

        public double MaxHealth { get; set; }

        public double Strength { get; set; }

        public int Speed { get; set; }

        public int Range { get; set; }

        public Point Position { get; set; }

        public int X { get { return Position.X; } set { Position = new Point(value, Position.Y); } }

        public int Y { get { return Position.Y; } set { Position = new Point(Position.X, value); } }

        public bool Solid { get; set; }

        public String ImageName { get; set; }

        public string ImageLocation { get; set; }

        public Direction CurrentDirection { get; set; }

        public Entity(double maxHealth, double health, int speed, String imageName, int posX, int posY, int range, bool solid, double strength, String imageLocation)
        {
            Health = health;
            MaxHealth = maxHealth;
            Strength = strength;
            Speed = speed;
            Range = range;
            Position = new Point(posX, posY);
            Solid = solid;
            ImageName = imageName;
            ImageLocation = imageLocation;
            CurrentDirection = Direction.Down;
        }

        public void Draw(Graphics g, int xOrig, int yOrig)
        {
            Bitmap bmp = new Bitmap(ImageLocation + ImageName);
            Image img = bmp.Clone(new Rectangle(32, (int) CurrentDirection * 32, 32, 32), bmp.PixelFormat);
            g.DrawImage(img, xOrig + (X * 32), yOrig + (Y * 32));
        }

        public void ProcessMove(Direction dir)
        {
            switch (dir)
            {
                case Direction.Down:
                    CurrentDirection = Direction.Down;
                    Y++;
                    break;
                case Direction.Left:
                    CurrentDirection = Direction.Left;
                    X--;
                    break;
                case Direction.Right:
                    CurrentDirection = Direction.Right;
                    X++;
                    break;
                case Direction.Up:
                    CurrentDirection = Direction.Up;
                    Y--;
                    break;
            }
        }
    }
}
