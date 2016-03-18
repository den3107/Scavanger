using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Input;

public class World
{
	public int  BoardHeight { get; set; }

	public int BoardWidth { get; set; }

	public Map Map { get; set; }

	public List<Enemy> Enemies { get; set; }

	public Player Player { get; set; }

    public Direction keyPressed { get; set; }

    private int xOrig;
    private int yOrig;

    public World(Map map, List<Enemy> enemies, Player player, int boardHeight, int boardWidth)
    {
        Map = map;
        Enemies = enemies;
        Player = player;
        BoardHeight = boardHeight;
        BoardWidth = boardWidth;

        xOrig = 0;
        yOrig = 0;
        if (Map.Tiles.GetLength(0) < boardHeight)
        {
            yOrig = (boardHeight - Map.Tiles.GetLength(0)) * 32 / 2;
        }
        if (Map.Tiles.GetLength(1) < boardWidth)
        {
            xOrig = (boardWidth - Map.Tiles.GetLength(1)) * 32 / 2;
        }

        keyPressed = Direction.None;
    }

    public void DrawMap(Graphics g)
    {
        Map.Draw(g, xOrig, yOrig);
    }

    public void DrawEntities(Graphics g)
    {
        foreach (Enemy enemy in Enemies)
        {
            enemy.Draw(g, xOrig, yOrig);
        }
        Player.Draw(g, xOrig, yOrig);
    }

    public void MoveEnemies(int moveDelay)
	{

	}

	public void MovePlayer()
	{
        bool moved = false;
        while (!moved)
        {
            switch (keyPressed)
            {
                case Direction.Down:
                    Player.currentDirection = Direction.Down;
                    keyPressed = Direction.None;
                    if (IsMovePossible(Player, Direction.Down))
                    {
                        Point p = Player.Position;
                        p.Y++;
                        Player.Position = p;
                        moved = true;
                        break;
                    }
                    break;
                case Direction.Left:
                    Player.currentDirection = Direction.Left;
                    keyPressed = Direction.None;
                    if (IsMovePossible(Player, Direction.Left))
                    {
                        Point p = Player.Position;
                        p.X--;
                        Player.Position = p;
                        moved = true;
                        break;
                    }
                    break;
                case Direction.Right:
                    Player.currentDirection = Direction.Right;
                    keyPressed = Direction.None;
                    if (IsMovePossible(Player, Direction.Right))
                    {
                        Point p = Player.Position;
                        p.X++;
                        Player.Position = p;
                        moved = true;
                        break;
                    }
                    break;
                case Direction.Up:
                    Player.currentDirection = Direction.Up;
                    keyPressed = Direction.None;
                    if (IsMovePossible(Player, Direction.Up))
                    {
                        Point p = Player.Position;
                        p.Y--;
                        Player.Position = p;
                        moved = true;
                        break;
                    }
                    break;
            }
        }
        ProcessFood();
	}

    private bool IsMovePossible(Entity entity, Direction dir)
    {
        if (entity.Solid)
        {
            switch (dir)
            {
                case Direction.Down:
                    if (!Map.Tiles[entity.Position.X, entity.Position.Y + 1].Passable || EntityAt(entity.Position.X, entity.Position.Y + 1))
                    {
                        return false;
                    }
                    break;
                case Direction.Left:
                    if (!Map.Tiles[entity.Position.X - 1, entity.Position.Y].Passable || EntityAt(entity.Position.X - 1, entity.Position.Y))
                    {
                        return false;
                    }
                    break;
                case Direction.Right:
                    if (!Map.Tiles[entity.Position.X + 1, entity.Position.Y].Passable || EntityAt(entity.Position.X + 1, entity.Position.Y))
                    {
                        return false;
                    }
                    break;
                case Direction.Up:
                    if (!Map.Tiles[entity.Position.X, entity.Position.Y - 1].Passable || EntityAt(entity.Position.X, entity.Position.Y - 1))
                    {
                        return false;
                    }
                    break;
                default: return false;
            }
        }
        return true;
    }

    private bool EntityAt(int x, int y)
    {
        foreach(Entity entity in Enemies)
        {
            if(entity.Position.X == x && entity.Position.Y == y)
            {
                return true;
            }
        }
        return false;
    }

	public bool PlayerAtEnd()
	{
        if(Player.Position == Map.End)
        {
            return true;
        }
        return false;
	}

    private void ProcessFood()
    {
        if(Player.Food < 1)
        {
            Player.Health--;
        }
        else
        {
            Player.Food--;
        }
    }

    public bool PlayerDead()
    {
        if (Player.Health <= 0)
        {
            return true;
        }
        return false;
    }
}