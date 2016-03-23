using System;
using System.Drawing;
using System.Windows.Forms;

public class Player : Entity
{
	public double Food { get; set; }

	public double MaxFood { get; set; }

    public Player(double maxHealth, double health, int speed, String imageName, int posX, int posY, int range, bool solid, double strength, String imageLocation, double maxFood, double food) : base(maxHealth, health, speed, imageName, posX, posY, range, solid, strength, imageLocation)
    {
        MaxFood = maxFood;
        Food = food;
    }
}