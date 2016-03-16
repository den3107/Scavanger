using System.Collections.Generic;

public class Map
{
	public Point Start { get; set; }

	public Point End { get; set; }

	public int Height { get; set; }

	public int Width { get; set; }

	public Tile[] Tiles { get; set; }

	public Wall[] Walls { get; set; }

	public List<Pickup> Pickups { get; set; }

	public Pickup RemovePickup(Point position)
	{
		throw new System.NotImplementedException();
	}
	public Map(Tile[] tiles, Wall[] walls, Pickup[] pickups)
	{
	}
}

