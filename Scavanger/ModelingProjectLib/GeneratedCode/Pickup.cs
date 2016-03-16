using System;

public class Pickup
{
	public string ImageName { get; set; }

	public Point Position { get; set; }

	public Double FoodRecovery { get; set; }

	public Double HealthRecovery { get; set; }

	public Double MaxFoodBonus { get; set; }

	public Double MaxHealthBonus { get; set; }

	public int RangeBonus { get; set; }

	public Double SpeedBonus { get; set; }

	public Double StrengthBonus { get; set; }

	public PictureBox Container { get; set; }

	public Pickup(PictureBox container, Double foodRecovery, Double healthRecovery, string imageName, Double MaxFoodBonus, Double maxHealthBonus, int posX, int poxY, int rangeBonus, Double speedBonus, Double strengthBonus)
	{
	}
}

