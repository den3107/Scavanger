using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Entity
{
    public double Health { get; set; }

    public double MaxHealth { get; set; }

    public double Strength { get; set; }

    public double Speed { get; set; }

    public int Range { get; set; }

    public Point Position { get; set; }

    public bool Solid { get; set; }

    public String ImageName { get; set; }

    public string ImageLocation { get; set; }

    public Direction currentDirection { get; set; }

    public Entity(double maxHealth, double speed, String imageName, int posX, int posY, int range, bool solid, double strength, String imageLocation)
    {
        Health = maxHealth;
        MaxHealth = maxHealth;
        Strength = strength;
        Speed = speed;
        Range = range;
        Position = new Point(posX, posY);
        Solid = solid;
        ImageName = imageName;
        ImageLocation = imageLocation;
        currentDirection = Direction.Down;
    }

    public abstract bool Move(Map map, Point playerPosition);

    public void Draw(Graphics g, int xOrig, int yOrig)
    {
        Bitmap bmp = new Bitmap(ImageLocation + ImageName);
        Image img = bmp.Clone(new Rectangle(32, (int) currentDirection * 32, 32, 32), bmp.PixelFormat);
        g.DrawImage(img, xOrig + (Position.X * 32), yOrig + (Position.Y * 32));
    }
}
