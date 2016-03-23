using System;
using System.Collections.Generic;
using System.Drawing;

namespace Scavanger
{
    public class Enemy : Entity
    {
        public int HuntSpeed { get; set; }

        public bool Hunts { get; set; }

        public Point playerLastSeen { get; private set; }

        private static Random rdm = new Random();

        public Enemy(double maxHealth, double health, int speed, String imageName, int posX, int posY, int range, bool solid, double strength, String imageLocation, int huntSpeed, bool hunts) : base(maxHealth, health, speed, imageName, posX, posY, range, solid, strength, imageLocation)
        {
            HuntSpeed = huntSpeed;
            Hunts = hunts;
            playerLastSeen = new Point(-1, -1);
        }

        public bool Move(World world, Direction canSeePlayer)
        {
            Direction result = CanAttackPlayer(world);
            if (result != Direction.None)
            {
                playerLastSeen = world.Player.Position;
                CurrentDirection = result;
                return true;
            }
            if (Hunts)
            {
                if (canSeePlayer != Direction.None)
                {
                    playerLastSeen = world.Player.Position;
                    ProcessMove(world, canSeePlayer);
                    return false;
                }
                if (!playerLastSeen.Equals(new Point(-1, -1)))
                {
                    result = MoveToPoint(world, playerLastSeen);
                    ProcessMove(world, result);
                    if (Position.Equals(playerLastSeen))
                    {
                        playerLastSeen = new Point(-1, -1);
                    }
                    return false;
                }
            }
            Direction[] possibleDirections = GetPossibleDirections(world);
            if (possibleDirections.Length > 0)
            {
                Direction dir = possibleDirections[rdm.Next(possibleDirections.Length)];
                ProcessMove(world, dir);
                if (CanSeePlayer(world) != Direction.None)
                {
                    playerLastSeen = world.Player.Position;
                }
                return false;
            }
            return false;
        }

        private Direction MoveToPoint(World world, Point p)
        {
            if (X == p.X)
            {
                if (Y < p.Y)
                {
                    return Direction.Down;
                }
                else if (Y > p.Y)
                {
                    return Direction.Up;
                }
            }
            else if (Y == p.Y)
            {
                if (X < p.X)
                {
                    return Direction.Right;
                }
                else if (X > p.X)
                {
                    return Direction.Left;
                }
            }
            return Direction.None;
        }

        private Direction[] GetPossibleDirections(World world)
        {
            List<Direction> list = new List<Direction>();
            if (world.IsMovePossible(this, Direction.Down))
            {
                list.Add(Direction.Down);
            }
            if (world.IsMovePossible(this, Direction.Left))
            {
                list.Add(Direction.Left);
            }
            if (world.IsMovePossible(this, Direction.Right))
            {
                list.Add(Direction.Right);
            }
            if (world.IsMovePossible(this, Direction.Up))
            {
                list.Add(Direction.Up);
            }
            return list.ToArray();
        }

        private Direction CanAttackPlayer(World world)
        {
            Player player = world.Player;
            if (X == player.X && Math.Abs(X - player.X) <= Range)
            {
                if (Y < player.Y)
                {
                    for (int i = Y + Range; i > Y; i--)
                    {
                        if (player.Y == i)
                        {
                            return Direction.Down;
                        }
                    }
                }
                else if (Y > player.Y)
                {
                    for (int i = Y - Range; i < Y; i++)
                    {
                        if (player.Y == i)
                        {
                            return Direction.Up;
                        }
                    }
                }
            }
            else if (Y == player.Y && Math.Abs(Y - player.Y) <= Range)
            {
                if (X < player.X)
                {
                    for (int i = X + Range; i > X; i--)
                    {
                        if (player.X == i)
                        {
                            return Direction.Right;
                        }
                    }
                }
                else if (X > player.X)
                {
                    for (int i = X - Range; i < X; i++)
                    {
                        if (player.X == i)
                        {
                            return Direction.Left;
                        }
                    }
                }
            }
            return Direction.None;
        }

        private void ProcessMove(World world, Direction dir)
        {
            if (world.IsMovePossible(this, dir))
            {
                base.ProcessMove(dir);
            }
        }

        public Direction CanSeePlayer(World world)
        {
            Player player = world.Player;
            if (X == player.X)
            {
                if (Y < player.Y)
                {
                    for (int i = Y + 1; i < world.Map.Tiles.GetLength(1); i++)
                    {
                        if (TileIsSolid(X, i, world))
                        {
                            return Direction.None;
                        }
                        else if (player.Y == i)
                        {
                            return Direction.Down;
                        }
                    }
                }
                else if (Y > player.Y)
                {
                    for (int i = Y - 1; i >= 0; i--)
                    {
                        if (TileIsSolid(X, i, world))
                        {
                            return Direction.None;
                        }
                        else if (player.Y == i)
                        {
                            return Direction.Up;
                        }
                    }
                }
            }
            else if (Y == player.Y)
            {
                if (X < player.X)
                {
                    for (int i = X + 1; i < world.Map.Tiles.GetLength(0); i++)
                    {
                        if (TileIsSolid(i, Y, world))
                        {
                            return Direction.None;
                        }
                        else if (player.X == i)
                        {
                            return Direction.Right;
                        }
                    }
                }
                else if (X > player.X)
                {
                    for (int i = X - 1; i >= 0; i--)
                    {
                        if (TileIsSolid(i, Y, world))
                        {
                            return Direction.None;
                        }
                        else if (player.X == i)
                        {
                            return Direction.Left;
                        }
                    }
                }
            }

            return Direction.None;
        }

        private bool TileIsSolid(int x, int y, World world)
        {
            return !world.Map.Tiles[x, y].Passable;
        }
    }
}