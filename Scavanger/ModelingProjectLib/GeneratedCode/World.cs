using System;
using System.Collections.Generic;

public class World
{
	public int ScreenHeight { get; set; }

	public int ScreenWidth { get; set; }

	public Map Map { get; set; }

	public List<Enemy> Enemies { get; set; }

	public Player Player { get; set; }

	public void MoveEnemies(Double frameSpeed)
	{
		throw new System.NotImplementedException();
	}
	public void MovePlayer()
	{
		throw new System.NotImplementedException();
	}
	public bool PlayerAtEnd()
	{
		throw new System.NotImplementedException();
	}
	public World(Map map, List<Enemy> enemies, Player player, int screenHeight, int screenWidth)
	{
	}
}

