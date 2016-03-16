using System;

public class Enemy
{
	public Double Health { get; set; }

	public Double Strength { get; set; }

	public Double IdleSpeed { get; set; }

	public Double HuntSpeed { get; set; }

	public int Range { get; set; }

	public bool Hunts { get; set; }

	public Point Position { get; set; }

	public bool Solid { get; set; }

	public string ImageName { get; set; }

	public PictureBox Container { get; set; }

	public bool Move(Map map, Point playerPosition)
	{
		throw new System.NotImplementedException();
	}
	public void Redraw()
	{
		throw new System.NotImplementedException();
	}
	public Enemy(PictureBox container, Double health, bool hunts, Double huntSpeed, Double idleSpeed, string imageName, int posX, int posY, int range, bool solid, Double Strength)
	{
	}
}

