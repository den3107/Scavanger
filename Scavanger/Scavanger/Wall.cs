using System;
using System.Drawing;

namespace Scavanger
{
    public class Wall
    {
        public String ImageName { get; set; }

        public Wall(String imageName)
        {
            ImageName = imageName;
        }
    }
}