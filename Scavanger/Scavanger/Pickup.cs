using System;
using System.Drawing;
using System.Windows.Forms;

namespace Scavanger
{
    public class Pickup
    {
        public String ImageName { get; set; }

        public double FoodRecovery { get; set; }

        public double HealthRecovery { get; set; }

        public double MaxFoodBonus { get; set; }

        public double MaxHealthBonus { get; set; }

        public int RangeBonus { get; set; }

        public int SpeedBonus { get; set; }

        public double StrengthBonus { get; set; }

        public Pickup(double foodRecovery, double healthRecovery, String imageName, double maxFoodBonus, double maxHealthBonus, int rangeBonus, int speedBonus, double strengthBonus)
        {
            ImageName = imageName;
            FoodRecovery = foodRecovery;
            HealthRecovery = healthRecovery;
            MaxFoodBonus = maxFoodBonus;
            MaxHealthBonus = maxHealthBonus;
            RangeBonus = rangeBonus;
            SpeedBonus = speedBonus;
            StrengthBonus = strengthBonus;
        }
    }
}