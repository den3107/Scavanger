public class Tile
{
	public string ImageName { get; set; }

	public Point Position { get; set; }

	public bool Passable { get; set; }

	public Tile(string imageName, bool passable, int posX, int posY)
	{
	}
}

