using System;

public class Player
{
	public Double Strength { get; set; }

	public Double Health { get; set; }

	public string ImageName { get; set; }

	public Point Position { get; set; }

	public int Range { get; set; }

	public Double Speed { get; set; }

	public Double MaxHealth { get; set; }

	public Double Food { get; set; }

	public Double MaxFood { get; set; }

	public PictureBox Container { get; set; }

	public void Redraw()
	{
		throw new System.NotImplementedException();
	}
	public Player(PictureBox container, string imageName, Double maxFood, Double maxHealth, int posX, int poxY, int range, Double speed, Double strength)
	{
	}
}

