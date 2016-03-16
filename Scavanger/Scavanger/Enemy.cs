using System;
using System.Drawing;

public class Enemy : Entity
{
	public double HuntSpeed { get; set; }

	public bool Hunts { get; set; }

    public Enemy(double maxHealth, double speed, String imageName, int posX, int posY, int range, bool solid, double strength, String imageLocation, double huntSpeed, bool hunts) : base (maxHealth, speed, imageName, posX, posY, range, solid, strength, imageLocation)
    {
        HuntSpeed = huntSpeed;
        Hunts = hunts;
    }

    public override bool Move(Map map, Point playerPosition)
	{
        throw new System.NotImplementedException();
    }
}