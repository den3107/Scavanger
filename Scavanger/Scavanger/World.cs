using System;
using System.Collections.Generic;
using System.Drawing;

public class World
{
	public int ScreenHeight { get; set; }

	public int ScreenWidth { get; set; }

	public Map Map { get; set; }

	public List<Enemy> Enemies { get; set; }

	public Player Player { get; set; }

    public World(Map map, List<Enemy> enemies, Player player, int screenHeight, int screenWidth)
    {
        Map = map;
        Enemies = enemies;
        Player = player;
        ScreenHeight = screenHeight;
        ScreenWidth = screenWidth;
    }

    public void DrawEntities(Graphics g)
    {
        foreach (Enemy enemy in Enemies)
        {
            enemy.Draw(g);
        }
        Player.Draw(g);
    }

    public void MoveEnemies(double frameSpeed)
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
}