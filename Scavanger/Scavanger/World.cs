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
        foreach (Enemy enemy in Enemies)
        {
            int speed = enemy.Speed;
            Direction result = enemy.CanSeePlayer(this);
            if (IsHunting(result, enemy))
            {
                speed = enemy.HuntSpeed;
            }
            for (int i = 0; i < speed; i++)
            {
                if (enemy.Move(this, result))
                {
                    Player.Health -= enemy.Strength;
                    if (PlayerDead())
                    {
                        return;
                    }
                    break;
                }
                result = enemy.CanSeePlayer(this);
                if (IsHunting(result, enemy))
                {
                    speed = enemy.HuntSpeed;
                }
                Thread.Sleep(moveDelay);
            }
        }
    }

	public void MovePlayer()
	{
        for(int i = 0; i < Player.Speed; i++)
        {
            bool moved = false;
            while (!moved)
            {
                if (IsMovePossible(Player, keyPressed))
                {
                    Player.ProcessMove(keyPressed);
                    keyPressed = Direction.None;
                    moved = true;
                }
            }

            if(PlayerAtEnd())
            {
                break;
            }
        }
        ProcessFood();
	}

    public bool IsMovePossible(Entity entity, Direction dir)
    {
        if (entity.Solid)
        {
            switch (dir)
            {
                case Direction.Down:
                    if (!Map.Tiles[entity.X, entity.Y + 1].Passable || EntityAt(entity.X, entity.Y + 1))
                    {
                        return false;
                    }
                    break;
                case Direction.Left:
                    if (!Map.Tiles[entity.X - 1, entity.Y].Passable || EntityAt(entity.X - 1, entity.Y))
                    {
                        return false;
                    }
                    break;
                case Direction.Right:
                    if (!Map.Tiles[entity.X + 1, entity.Y].Passable || EntityAt(entity.X + 1, entity.Y))
                    {
                        return false;
                    }
                    break;
                case Direction.Up:
                    if (!Map.Tiles[entity.X, entity.Y - 1].Passable || EntityAt(entity.X, entity.Y - 1))
                    {
                        return false;
                    }
                    break;
                default: return false;
            }
        }
        return true;
    }

    private bool IsHunting(Direction dir, Enemy enemy)
    {
        bool condition1 = dir != Direction.None;
        bool condition2 = !enemy.playerLastSeen.Equals(new Point(-1, -1));

        return condition1 || condition2;
    }

    private bool EntityAt(int x, int y)
    {
        foreach(Entity entity in Enemies)
        {
            if(entity.X == x && entity.Y == y)
            {
                return true;
            }
        }
        if (Player.X == x && Player.Y == y)
        {
            return true;
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
            Player.Health -= 10;
        }
        else
        {
            Player.Food -= 5;
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