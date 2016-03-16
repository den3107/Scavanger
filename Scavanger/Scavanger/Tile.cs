using System;
using System.Drawing;

public class Tile
{
	public String ImageName { get; set; }

	public bool Passable { get; set; }

	public Tile(String imageName, bool passable)
	{
        ImageName = imageName;
        Passable = passable;
	}
}