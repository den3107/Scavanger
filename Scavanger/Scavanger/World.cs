using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Input;

namespace Scavanger
{
    public class World
    {
        public int BoardHeight { get; set; }

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
                    if (i < speed)
                    {
                        Thread.Sleep(moveDelay);
                    }
                }
            }
        }

        public void MovePlayer()
        {
            for (int i = 0; i < Player.Speed; i++)
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

                if (PlayerAtEnd())
                {
                    break;
                }
            }
            Player tempPlayer = Player;
            tempPlayer = ProcessHunger(tempPlayer);
            tempPlayer = ProcessPickup(tempPlayer);
            lock(Player)
            {
                Player = tempPlayer;
            }
        }

        public bool IsMovePossible(Entity entity, Direction dir)
        {
            switch (dir)
            {
                case Direction.Down:
                    if (IsOccupied(entity.Solid, Map.Tiles[entity.X, entity.Y + 1], entity.X, entity.Y + 1))
                    {
                        return false;
                    }
                    break;
                case Direction.Left:
                    if (IsOccupied(entity.Solid, Map.Tiles[entity.X - 1, entity.Y], entity.X - 1, entity.Y))
                    {
                        return false;
                    }
                    break;
                case Direction.Right:
                    if (IsOccupied(entity.Solid, Map.Tiles[entity.X + 1, entity.Y], entity.X + 1, entity.Y))
                    {
                        return false;
                    }
                    break;
                case Direction.Up:
                    if (IsOccupied(entity.Solid, Map.Tiles[entity.X, entity.Y - 1], entity.X, entity.Y - 1))
                    {
                        return false;
                    }
                    break;
                default: return false;
            }
            return true;
        }

        private bool IsOccupied(bool isSolid, Tile tile, int checkX, int checkY)
        {
            if(EntityAt(checkX, checkY))
            {
                return true;
            }
            if(isSolid && !tile.Passable)
            {
                return true;
            }
            return false;
        }

        private bool IsHunting(Direction dir, Enemy enemy)
        {
            bool condition1 = dir != Direction.None;
            bool condition2 = !enemy.playerLastSeen.Equals(new Point(-1, -1));

            return condition1 || condition2;
        }

        private bool EntityAt(int x, int y)
        {
            foreach (Entity entity in Enemies)
            {
                if (entity.X == x && entity.Y == y)
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
            if (Player.Position == Map.End)
            {
                return true;
            }
            return false;
        }

        private Player ProcessHunger(Player player)
        {
            if (Player.Food < 1)
            {
                player.Health -= 10;
            }
            else
            {
                player.Food -= 5;
            }
            return player;
        }

        private Player ProcessPickup(Player player)
        {
            Pickup pickup = Map.RemovePickup(player.Position);

            if (pickup != null)
            {
                player.Food += pickup.FoodRecovery;
                player.Health += pickup.HealthRecovery;
                player.MaxFood += pickup.MaxFoodBonus;
                player.MaxHealth += pickup.MaxHealthBonus;
                player.Range += pickup.RangeBonus;
                player.Speed += pickup.SpeedBonus;
                player.Strength += pickup.StrengthBonus;

                if (player.Food > player.MaxFood)
                {
                    player.Food = player.MaxFood;
                }
                if (player.Health > player.MaxHealth)
                {
                    player.Health = player.MaxHealth;
                }
                if (player.Food < 0)
                {
                    player.Food = 0;
                }
                if (player.Health < 0)
                {
                    player.Health = 0;
                }
            }

            return player;
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
}